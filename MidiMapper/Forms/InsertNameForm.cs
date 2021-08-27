using System;
using System.Windows.Forms;

namespace MidiMapper.Forms
{
    public partial class InsertNameForm : Form
    {
        private bool _nameAccepted = false;

        public InsertNameForm(string formName, string txtBoxText, string button1, string button2)
        {
            InitializeComponent();
            Text = formName;
            txtBox.Text = txtBoxText;
            okButton.Text = button1;
            cancelButton.Text = button2;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length == 0)
            {
                MessageBox.Show("Invalid name", "Error");
                return;
            }
            
            _nameAccepted = true;
            Close();
        }

        public string GetName()
        {
            return _nameAccepted ? txtBox.Text : null;
        }
    }
}
