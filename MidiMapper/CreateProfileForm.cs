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
    public partial class CreateProfileForm : Form
    {
        private App app;

        public CreateProfileForm()
        {
            InitializeComponent();
        }

        public CreateProfileForm(App app)
        {
            InitializeComponent();
            this.app = app;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (insertNameTxtBox.Text.Length == 0)
            {
                MessageBox.Show("Invalid profile name", "Error");
                return;
            }
            app.CreateProfile(insertNameTxtBox.Text);
            this.Close();
        }
    }
}
