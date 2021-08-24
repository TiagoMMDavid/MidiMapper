using System;
using System.Windows.Forms;

namespace MidiMapper.Forms
{
    public partial class InsertNameForm : Form
    {
        private bool nameAccepted = false;

        public InsertNameForm(String formName, String txtBoxText, String button1, String button2)
        {
            InitializeComponent();
            this.Text = formName;
            txtBox.Text = txtBoxText;
            okButton.Text = button1;
            cancelButton.Text = button2;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length == 0)
            {
                MessageBox.Show("Invalid name", "Error");
                return;
            }
            nameAccepted = true;
            this.Close();
        }

        public string GetName()
        {
            return (nameAccepted == true ? txtBox.Text : null);
        }
    }
}
