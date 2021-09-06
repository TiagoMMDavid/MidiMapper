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
            noteNameListBox.Text = "C";
            octaveListBox.Text = "4";

            // Add keyboard keys to listBox
            string[] keyboardKeys = Enum.GetNames(typeof(KeyboardKeys));
            keysListBox.Items.AddRange(keyboardKeys);

            _controller = controller;
            _controller.MacrosExecuting = false;
            _controller.AddKeyPressedListener(OnKeyPressed);

            this.FormClosing += ManageMacroForm_FormClosing;
            this.KeyDown += test;
        }

        private void test(object sender, KeyEventArgs e)
        {
            Console.WriteLine(Enum.GetName(typeof(Keys), e.KeyCode));
        }

        // Constructor for macro edition
        public ManageMacroForm(MidiMapperController controller, Macro macroToEdit) : this(controller)
        {
            _macro = macroToEdit;
            _isEdit = true;
            
            okButton.Text = "Edit Macro";
            macroNameTextBox.Text = macroToEdit.MacroName;
            noteNameLabel.Text = macroToEdit.Note;

            noteNameListBox.Text = macroToEdit.Note.Substring(0, macroToEdit.Note.Length - 1); // Extract Pitch
            octaveListBox.Text = $"{macroToEdit.Note[macroToEdit.Note.Length - 1]}"; // Extract Octave

            deleteMacroButton.Visible = true;
        }

        #region Macro Function Controls
        private void KeyboardPressRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            keysListBox.Visible = mousePressRadioButton.Checked || keyboardPressRadioButton.Checked;
            if (!keyboardPressRadioButton.Checked) return;

            keysListBox.Items.Clear();
            string[] keyboardKeys = Enum.GetNames(typeof(KeyboardKeys));
            keysListBox.Items.AddRange(keyboardKeys);
        }

        private void MousePressRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            keysListBox.Visible = mousePressRadioButton.Checked || keyboardPressRadioButton.Checked;
            if (!mousePressRadioButton.Checked) return;

            string[] mouseButtons = Enum.GetNames(typeof(Enums.MouseButtons));
            keysListBox.Items.Clear();
            keysListBox.Items.AddRange(mouseButtons);
        }

        private void MouseMoveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mouseMoveX.Visible = mouseMoveRadioButton.Checked;
            mouseMoveY.Visible = mouseMoveRadioButton.Checked;
            mouseXLabel.Visible = mouseMoveRadioButton.Checked;
            mouseYLabel.Visible = mouseMoveRadioButton.Checked;

            if (!mouseMoveRadioButton.Checked) return;


        }
        #endregion

        #region Piano Keys Controls
        private void OnKeyPressed(string note, int velocity, Macro macro)
        {
            // Make sure changes are being made by the UI Thread
            if (noteNameLabel.InvokeRequired)
            {
                Action safeCall = delegate { OnKeyPressed(note, velocity, macro); };
                noteNameLabel.Invoke(safeCall);
                return;
            }

            midiTipLabel.Visible = false; // Set tip to invisible after pressing a key
            string pitch = note.Substring(0, note.Length - 1);
            string octave = $"{note[note.Length - 1]}";
            UpdateNote(pitch, octave);
        }

        private void UpdateNote(string pitch, string octave)
        {
            noteNameListBox.Text = pitch;
            octaveListBox.Text = octave;
            noteNameLabel.Text = $"{pitch}{octave}";
        }

        #region Piano Keys Buttons Callbacks
        private void OctaveListBox_SelectedIndexChanged(object sender, EventArgs e) =>
            UpdateNote((string) noteNameListBox.SelectedItem, (string) octaveListBox.SelectedItem);

        private void CButton_Click(object sender, EventArgs e) => 
            UpdateNote("C", (string) octaveListBox.SelectedItem);

        private void CSharpButton_Click(object sender, EventArgs e) => 
            UpdateNote("C#", (string) octaveListBox.SelectedItem);

        private void DButton_Click(object sender, EventArgs e) => 
            UpdateNote("D", (string) octaveListBox.SelectedItem);

        private void DSharpButton_Click(object sender, EventArgs e) => 
            UpdateNote("D#", (string) octaveListBox.SelectedItem);

        private void EButton_Click(object sender, EventArgs e) => 
            UpdateNote("E", (string) octaveListBox.SelectedItem);

        private void FButton_Click(object sender, EventArgs e) => 
            UpdateNote("F", (string) octaveListBox.SelectedItem);

        private void FSharpButton_Click(object sender, EventArgs e) => 
            UpdateNote("F#", (string) octaveListBox.SelectedItem);

        private void GButton_Click(object sender, EventArgs e) => 
            UpdateNote("G", (string) octaveListBox.SelectedItem);

        private void GSharpButton_Click(object sender, EventArgs e) => 
            UpdateNote("G#", (string) octaveListBox.SelectedItem);

        private void AButton_Click(object sender, EventArgs e) => 
            UpdateNote("A", (string) octaveListBox.SelectedItem);

        private void ASharpButton_Click(object sender, EventArgs e) => 
            UpdateNote("A#", (string) octaveListBox.SelectedItem);

        private void BButton_Click(object sender, EventArgs e) => 
            UpdateNote("B", (string) octaveListBox.SelectedItem);
        #endregion
        #endregion

        #region Ok/Cancel/Delete Buttons
        private void OkButton_Click(object sender, EventArgs e)
        {
            string macroName = macroNameTextBox.Text;
            string note = noteNameLabel.Text;

            bool createConflict = !_isEdit && _controller.Profile.HasMacro(note);
            bool editConflict = note != _macro?.Note && _controller.Profile.HasMacro(note);
            if (createConflict || editConflict)
            {
                string msg = $"Note [{note}] is already in use by another macro!";
                MessageBox.Show(msg, "Macro Conflict", MessageBoxButtons.OK);
                return;
            }

            // Create or Edit macro
            if (_isEdit) _controller.Profile.RemoveMacro(_macro.Note);

            Macro newMacro = null;
            switch (macroTypePanel.Controls.OfType<RadioButton>().First(button => button.Checked).Name)
            {
                case "keyboardPressRadioButton":
                    newMacro = new KeyboardPressMacro(macroName, note, 
                        (KeyboardKeys) Enum.Parse(typeof(KeyboardKeys), (string) keysListBox.SelectedItem));
                    break;
                case "mousePressRadioButton":
                    newMacro = new MousePressMacro(macroName, note,
                        (Enums.MouseButtons) Enum.Parse(typeof(Enums.MouseButtons), (string) keysListBox.SelectedItem));
                    break;
                case "mouseMoveRadioButton":
                    newMacro = new MouseMovementMacro(macroName, note,
                        (int) mouseMoveX.Value, (int) mouseMoveY.Value);
                    break;
            }

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
