using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using MidiMapper.Controller;
using MidiMapper.Macros;

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
            string[] keyboardKeys = Enum.GetValues(typeof(Keys))
                .Cast<Keys>()
                .Select(key => key.ToString())
                .ToArray();
            keyboardKeysListBox.Items.AddRange(keyboardKeys);

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
            noteNameLabel.Text = macroToEdit.Note;

            noteNameListBox.Text = macroToEdit.Note.Substring(0, macroToEdit.Note.Length - 1); // Extract Pitch
            octaveListBox.Text = $"{macroToEdit.Note[macroToEdit.Note.Length - 1]}"; // Extract Octave

            deleteMacroButton.Visible = true;
        }

        #region Macro Function Controls
        private void KeyboardPressRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            keyboardKeysListBox.Visible = mousePressRadioButton.Checked || keyboardPressRadioButton.Checked;
            if (!keyboardPressRadioButton.Checked) return;

            string[] keyboardKeys = Enum.GetValues(typeof(Keys))
                .Cast<Keys>()
                .Select(key => key.ToString())
                .ToArray();

            keyboardKeysListBox.Items.Clear();
            keyboardKeysListBox.Items.AddRange(keyboardKeys);
        }

        private void MousePressRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            keyboardKeysListBox.Visible = mousePressRadioButton.Checked || keyboardPressRadioButton.Checked;
            if (!mousePressRadioButton.Checked) return;

            string[] mouseButtons = Enum.GetValues(typeof(MouseButtons))
                .Cast<MouseButtons>()
                .Select(button => button.ToString())
                .ToArray();

            keyboardKeysListBox.Items.Clear();
            keyboardKeysListBox.Items.AddRange(mouseButtons);
        }

        private void MouseMoveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mouseMoveX.Visible = mouseMoveRadioButton.Checked;
            mouseMoveY.Visible = mouseMoveRadioButton.Checked;
            if (!mouseMoveRadioButton.Checked) return;


        }
        #endregion

        #region Piano Keys Controls
        private void OnKeyPressed(string note, int velocity, Macro macro)
        {
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
            // TODO: Error handling (check if note has conflicts)
            string macroName = macroNameTextBox.Text;
            string note = noteNameLabel.Text;

            // Create or Edit macro
            if (_isEdit) _controller.Profile.RemoveMacro(_macro.Note);

            Macro newMacro = null;
            switch (macroTypePanel.Controls.OfType<RadioButton>().First(button => button.Checked).Name)
            {
                case "keyboardPressRadioButton":
                    newMacro = new KeyboardPressMacro(macroName, note, 
                        (Keys) Enum.Parse(typeof(Keys), (string) keyboardKeysListBox.SelectedItem));
                    break;
                case "mousePressRadioButton":
                    newMacro = new KeyboardPressMacro(macroName, note,
                        (Keys) Enum.Parse(typeof(Keys), (string)keyboardKeysListBox.SelectedItem));
                    break;
                case "mouseMoveRadioButton":
                    newMacro = new KeyboardPressMacro(macroName, note,
                        (Keys) Enum.Parse(typeof(Keys), (string)keyboardKeysListBox.SelectedItem));
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
