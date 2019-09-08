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
        private bool isCreatingMacro = false;

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
            isCreatingMacro = true;
            setCreateMacrosLayoutVisible(true);
            createMacroButton.Enabled = false;
            nameTxtBox.Focus();
        }

        private void setCreateMacrosLayoutVisible(bool state)
        {
            nameTxtBox.Visible = state;
            keybindTxtBox.Visible = state;
            pitchTxtBox.Visible = state;
            createMacroButton.Visible = state;
        }

        //TODO: improve it, probably not best way to do it
        private void RefreshButtonTimer_Tick(object sender, EventArgs e)
        {
            if (isCreatingMacro && nameTxtBox.Text != String.Empty && keybindTxtBox.Text != String.Empty && pitchTxtBox.Text != String.Empty)
                createMacroButton.Enabled = true;
            else
                createMacroButton.Enabled = false;
        }

        private void CreateMacroButton_Click(object sender, EventArgs e)
        {
            /*
            if (nameTxtBox.Text == String.Empty)
            {
                MessageBox.Show("Macro name is empty", "Error");
                return;
            }
            //TODO: Change for special cases later
            if (!(keybindTxtBox.Text.Length == 1))
            {
                MessageBox.Show("Invalid keybind format", "Error");
                return;
            }
            if (pitchTxtBox.Text == )
            {
                return;
            } */
        }
    }
}
