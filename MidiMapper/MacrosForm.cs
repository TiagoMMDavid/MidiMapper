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
    public partial class MacrosForm : Form
    {
        private App app;
        private Profile profile;

        public MacrosForm(App app)
        {
            InitializeComponent();

            this.app = app;
            this.profile = app.GetProfile();

            refreshMacros();
        }

        private void refreshMacros()
        {
            macrosList.Items.Clear();
            if (profile.GetMacroCount() == 0)
            {
                macrosList.Enabled = false;
                macrosList.Items.Add("No macros");
            }
            else
            {
                macrosList.Enabled = true;
                for (int i = 0; i < profile.GetMacroCount(); i++)
                    macrosList.Items.Add(profile.GetMacroAtIndex(i));
            }
        }

        private void MacrosList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (macrosList.SelectedIndex < 0 || macrosList.SelectedIndex > macrosList.Items.Count)
                return;

            if (profile.GetMacroCount() > 0)
                delMacroButton.Enabled = true;
        }

        private void DelMacroButton_Click(object sender, EventArgs e)
        {
            Macro macro = profile.GetMacroAtIndex(macrosList.SelectedIndex);
            profile.RemoveMacro(macro);
            macrosList.Items.Remove(macro);

            if (profile.GetMacroCount() <= 1)
            {
                delMacroButton.Enabled = false;
                if (profile.GetMacroCount() == 0)
                {
                    macrosList.Items.Add("No macros");
                    macrosList.Enabled = false;
                }
            }
        }

        private void NewMacroButton_Click(object sender, EventArgs e)
        {

        }
    }
}
