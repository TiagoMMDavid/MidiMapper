using System;
using System.Windows.Forms;

namespace MidiMapper.Source.Forms.Controls
{
    public partial class PianoControl : UserControl
    {
        public string Note { get => noteNameLabel.Text; }

        public PianoControl()
        {
            InitializeComponent();
            UpdateNote("C", "4");
        }

        public void UpdateNote(string pitch, string octave)
        {
            noteNameListBox.Text = pitch;
            octaveListBox.Text = octave;
            noteNameLabel.Text = $"{pitch}{octave}";
        }

        private void NoteNameListBox_SelectedIndexChanged(object sender, EventArgs e) =>
            UpdateNote((string) noteNameListBox.SelectedItem, (string) octaveListBox.SelectedItem);

        private void OctaveListBox_SelectedIndexChanged(object sender, EventArgs e) =>
            UpdateNote((string) noteNameListBox.SelectedItem, (string) octaveListBox.SelectedItem);

        #region Piano Keys Buttons Callbacks
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
    }
}
