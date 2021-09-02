using System;
using System.Windows.Forms;
using MidiMapper.Controller;
using MidiMapper.Macros;

namespace MidiMapper.Forms
{
    public delegate void Consumer(string key);

    public partial class MacroForm : Form
    {
        private readonly Profile _profile;
        private readonly bool _isEdit;

        private MacroForm()
        {
            InitializeComponent();
            macroNameTextBox.MaxLength = Macro.MaxMacroNameSize;
        }

        // Constructor for new macro creation
        public MacroForm(Profile profile, Consumer cons) : this()
        {
            _profile = profile;

            noteNameListBox.Text = "C";
            octaveListBox.Text = "4";

            cons.C
        }

        // Constructor for macro edition
        public MacroForm(Macro macro, Profile profile) : this()
        {
            _profile = profile;
            _isEdit = true;
            
            okButton.Text = "Edit Macro";
            macroNameTextBox.Text = macro.MacroName;
            noteNameLabel.Text = macro.Note;

            noteNameListBox.Text = macro.Note.Substring(0, macro.Note.Length - 1); // Extract Pitch
            octaveListBox.Text = $"{macro.Note[macro.Note.Length - 1]}"; // Extract Octave
        }

        private void UpdateNote(string pitch, string octave)
        {
            noteNameListBox.Text = pitch;
            octaveListBox.Text = octave;
            noteNameLabel.Text = $"{pitch}{octave}";
        }

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

        private void OkButton_Click(object sender, EventArgs e)
        {
            // Validate macro

        }
    }
}
