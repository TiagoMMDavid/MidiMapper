using System;
using System.Windows.Forms;

namespace MidiMapper.Forms
{
    public partial class PianoForm : Form
    {
        private bool isPitchSet;
        //private Pitch pitch;
        private String key;

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
            pitchTxtBox.Text = key + octaveTrackBar.Value;
            okButton.Enabled = true;
        }

        private void OctaveTrackBar_Scroll(object sender, EventArgs e)
        {
            RefreshTxtBox();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            String pitchString = pitchTxtBox.Text;

            //TODO: fix possible wrong inputs format cases
            //If String is not correct return
            if (pitchString.Length != 2 && pitchString.Length != 7)
            {
                MessageBox.Show("Invalid pitch", "Error");
                return;
            }

            //pitch = (Pitch)Enum.Parse(typeof(Pitch), pitchString);
            isPitchSet = true;
            this.Close();
        }

        #region piano buttons methods
        private void CButton_Click(object sender, EventArgs e)
        {
            key = "C";
            RefreshTxtBox();
        }

        private void CSharpButton_Click(object sender, EventArgs e)
        {
            key = "CSharp";
            RefreshTxtBox();
        }

        private void DButton_Click(object sender, EventArgs e)
        {
            key = "D";
            RefreshTxtBox();
        }

        private void DSharpButton_Click(object sender, EventArgs e)
        {
            key = "DSharp";
            RefreshTxtBox();
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            key = "E";
            RefreshTxtBox();
        }

        private void FButton_Click(object sender, EventArgs e)
        {
            key = "F";
            RefreshTxtBox();
        }

        private void FSharpButton_Click(object sender, EventArgs e)
        {
            key = "FSharp";
            RefreshTxtBox();
        }

        private void GButton_Click(object sender, EventArgs e)
        {
            key = "G";
            RefreshTxtBox();
        }

        private void GSharpButton_Click(object sender, EventArgs e)
        {
            key = "GSharp";
            RefreshTxtBox();
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            key = "A";
            RefreshTxtBox();
        }

        private void ASharpButton_Click(object sender, EventArgs e)
        {
            key = "ASharp";
            RefreshTxtBox();
        }

        private void BButton_Click(object sender, EventArgs e)
        {
            key = "B";
            RefreshTxtBox();
        }
        #endregion

        /*
        public Pitch GetPitch()
        {
            return (isPitchSet ? pitch : 0);
        }
        */
    }
}
