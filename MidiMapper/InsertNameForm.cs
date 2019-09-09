using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiMapper
{
    public partial class InsertNameForm : Form
    {
        bool nameAccepted = false;

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
