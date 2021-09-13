using System;
using System.Windows.Forms;
using System.Linq;
using MidiMapper.Controller;
using MidiMapper.Macros;
using MidiMapper.Enums;

namespace MidiMapper.Forms
{
    public partial class ManageMacroForm : Form
    {
        private readonly MidiMapperController _controller;
        private readonly Macro _macro;
        private readonly bool _isEdit;

        // Constructor for new macro creation
        public ManageMacroForm(MidiMapperController controller)
        {
            InitializeComponent();
            macroNameTextBox.MaxLength = Macro.MaxMacroNameSize;

            _controller = controller;
            _controller.MacrosExecuting = false;
            _controller.AddKeyPressedListener(OnKeyPressed);

            this.FormClosing += ManageMacroForm_FormClosing;
        }

        // Constructor for macro edition
        public ManageMacroForm(MidiMapperController controller, Macro macroToEdit) : this(controller)
        {
            _macro = macroToEdit;
            _isEdit = true;
            
            okButton.Text = "Edit Macro";
            macroNameTextBox.Text = macroToEdit.MacroName;
            deleteMacroButton.Visible = true;

            string pitch = macroToEdit.Note.Substring(0, macroToEdit.Note.Length - 1); // Extract Pitch
            string octave = $"{macroToEdit.Note[macroToEdit.Note.Length - 1]}"; // Extract Octave
            pianoForm.UpdateNote(pitch, octave);
            UpdateMacroFunctionality(macroToEdit);
        }

        private void UpdateMacroFunctionality(Macro macro)
        {
            switch (macro.GetMacroType())
            {
                case Macro.MacroType.KbdPress:
                    keyboardPressRadioButton.Checked = true;
                    keyboardForm.UpdateKey((macro as KeyboardPressMacro).Key);
                    break;
                case Macro.MacroType.MousePress:
                    mousePressRadioButton.Checked = true;
                    mousePressForm.UpdateButton((macro as MousePressMacro).MouseButton);
                    break;
                case Macro.MacroType.MouseMove:
                    mouseMoveRadioButton.Checked = true;
                    MouseMovementMacro mouseMacro = macro as MouseMovementMacro;
                    mouseMoveForm.UpdateAxis(mouseMacro.X, mouseMacro.Y);
                    break;
            }
        }

        #region Macro Function Controls

        private void KeyboardPressRadioButton_CheckedChanged(object sender, EventArgs e) =>
            keyboardForm.Visible = keyboardPressRadioButton.Checked;

        private void MousePressRadioButton_CheckedChanged(object sender, EventArgs e) =>
            mousePressForm.Visible = mousePressRadioButton.Checked;

        private void MouseMoveRadioButton_CheckedChanged(object sender, EventArgs e) =>
            mouseMoveForm.Visible = mouseMoveRadioButton.Checked;

        #endregion

        #region Piano Keys Controls
        private void OnKeyPressed(string note, int velocity, Macro macro)
        {
            // Make sure changes are being made by the UI Thread
            if (pianoForm.InvokeRequired)
            {
                Action safeCall = delegate { OnKeyPressed(note, velocity, macro); };
                pianoForm.Invoke(safeCall);
                return;
            }

            midiTipLabel.Visible = false; // Set tip to invisible after pressing a key
            string pitch = note.Substring(0, note.Length - 1);
            string octave = $"{note[note.Length - 1]}";
            pianoForm.UpdateNote(pitch, octave);
        }
        #endregion

        #region Ok/Cancel/Delete Buttons
        private void OkButton_Click(object sender, EventArgs e)
        {
            string macroName = macroNameTextBox.Text;
            string note = pianoForm.Note;

            bool createConflict = !_isEdit && _controller.Profile.HasMacro(note);
            bool editConflict = note != _macro?.Note && _controller.Profile.HasMacro(note);
            if (createConflict || editConflict)
            {
                string msg = $"Note [{note}] is already in use by another macro!";
                MessageBox.Show(msg, "Macro Conflict", MessageBoxButtons.OK);
                return;
            }

            // Create or Edit macro
            Macro newMacro = null;
            // Check which radio button is checked
            switch (macroTypePanel.Controls.OfType<RadioButton>().First(button => button.Checked).Name)
            {
                case "keyboardPressRadioButton":
                    if (keyboardForm.Key == null)
                    {
                        MessageBox.Show("Keyboard key must not be empty", "Keyboard Key Error", MessageBoxButtons.OK);
                        return;
                    }
                    newMacro = new KeyboardPressMacro(macroName, note, (KeyboardKeys) keyboardForm.Key);
                    break;
                case "mousePressRadioButton":
                    if (mousePressForm.MouseButton == null)
                    {
                        MessageBox.Show("Mouse Button must not be empty", "Mouse Button Error", MessageBoxButtons.OK);
                        return;
                    }
                    newMacro = new MousePressMacro(macroName, note, (Enums.MouseButtons) mousePressForm.MouseButton);
                    break;
                case "mouseMoveRadioButton":
                    if (mouseMoveForm.X == 0 && mouseMoveForm.Y == 0)
                    {
                        MessageBox.Show("Mouse Movement must not be (0, 0)", "Mouse Movement Error", MessageBoxButtons.OK);
                        return;
                    }
                    newMacro = new MouseMovementMacro(macroName, note, mouseMoveForm.X, mouseMoveForm.Y);
                    break;
            }

            // TODO: Replace this with a single EditMacro function
            if (_isEdit) _controller.Profile.RemoveMacro(_macro.Note);
            _controller.Profile.AddMacro(note, newMacro);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteMacroButton_Click(object sender, EventArgs e)
        {
            _controller.Profile.RemoveMacro(_macro.Note);
            this.Close();
        }
        #endregion

        private void ManageMacroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _controller.RemoveKeyPressedListener(OnKeyPressed);
            _controller.MacrosExecuting = true;
        }
    }
}
