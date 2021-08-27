using System;
using System.Windows.Forms;

namespace MidiMapper.Forms
{
    public partial class PianoForm : Form
    {
        private bool _isNoteSet;
        private string _noteName;

        public PianoForm()
        {
            InitializeComponent();
        }

        private void PitchTxtBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
        }

        private void RefreshTxtBox()
        {
            pitchTxtBox.Text = $"{_noteName}{octaveTrackBar.Value}";
            okButton.Enabled = true;
        }

        private void OctaveTrackBar_Scroll(object sender, EventArgs e)
        {
            RefreshTxtBox();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string note = pitchTxtBox.Text;
            
            //If String is not correct return
            if (note.Length != 2 && note.Length != 7)
            {
                MessageBox.Show("Invalid note", "Error");
                return;
            }
            
            _isNoteSet = true;
            Close();
        }

        #region Piano keys callback methods
        private void CButton_Click(object sender, EventArgs e)
        {
            _noteName = "C";
            RefreshTxtBox();
        }

        private void CSharpButton_Click(object sender, EventArgs e)
        {
            _noteName = "C#";
            RefreshTxtBox();
        }

        private void DButton_Click(object sender, EventArgs e)
        {
            _noteName = "D";
            RefreshTxtBox();
        }

        private void DSharpButton_Click(object sender, EventArgs e)
        {
            _noteName = "D#";
            RefreshTxtBox();
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            _noteName = "E";
            RefreshTxtBox();
        }

        private void FButton_Click(object sender, EventArgs e)
        {
            _noteName = "F";
            RefreshTxtBox();
        }

        private void FSharpButton_Click(object sender, EventArgs e)
        {
            _noteName = "F#";
            RefreshTxtBox();
        }

        private void GButton_Click(object sender, EventArgs e)
        {
            _noteName = "G";
            RefreshTxtBox();
        }

        private void GSharpButton_Click(object sender, EventArgs e)
        {
            _noteName = "G#";
            RefreshTxtBox();
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            _noteName = "A";
            RefreshTxtBox();
        }

        private void ASharpButton_Click(object sender, EventArgs e)
        {
            _noteName = "A#";
            RefreshTxtBox();
        }

        private void BButton_Click(object sender, EventArgs e)
        {
            _noteName = "B";
            RefreshTxtBox();
        }
        #endregion
        
        public string GetNote()
        {
            return _isNoteSet ? $"{_noteName}{octaveTrackBar.Value}" : null;
        }
    }
}
