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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Program.Run();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Program.PressKeyTest();
        }
    }
}
