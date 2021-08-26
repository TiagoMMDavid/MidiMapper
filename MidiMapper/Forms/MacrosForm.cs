using System;
using System.Windows.Forms;
using MidiMapper.Controller;
using MidiMapper.Macros;

namespace MidiMapper.Forms
{
    public partial class MacrosForm : Form
    {
        private Profile _profile;

        public MacrosForm(Profile profile)
        {
            InitializeComponent();

            this._profile = profile;
            this.KeyDown += MacrosForm_KeyDown;
            refreshMacros();
        }

        private void refreshMacros()
        {
            macrosList.Items.Clear();
            if (_profile.MacrosCount == 0)
            {
                macrosList.Enabled = false;
                macrosList.Items.Add("No macros");
            }
            else
            {
                macrosList.Enabled = true;
                for (int i = 0; i < _profile.MacrosCount; i++)
                {
                    // TODO: Customize macro description
                    macrosList.Items.Add(_profile.GetMacroAtIndex(i).GetMacroInfo());
                }
            }
        }

        private void MacrosList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (macrosList.SelectedIndex < 0 || macrosList.SelectedIndex > macrosList.Items.Count)
            {
                delMacroButton.Enabled = false;
                return;
            }

            if (_profile.MacrosCount > 0)
                delMacroButton.Enabled = true;
        }

        private void DelMacroButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedMacro();
        }

        private void NewMacroButton_Click(object sender, EventArgs e)
        {
            /*
            //TODO: Change order to: bind key -> midi key -> macro name 
            InsertNameForm insertMacroNameForm = new InsertNameForm("Create Macro", "Insert macro name", "Ok", "Cancel");
            insertMacroNameForm.ShowDialog();
            string macroName = insertMacroNameForm.GetName();
            if (macroName == null)
                return;

            PianoForm pianoForm = new PianoForm();
            pianoForm.ShowDialog();
            Pitch macroPitch = pianoForm.GetPitch();
            if (macroPitch == 0)
                return;

            // TODO: GUI to pick keybind for the macro
            //KeybindForm keybindForm = new KeybindForm(); */
        }

        // Listen to keyboard events
        private void MacrosForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteSelectedMacro();
        }

        private void DeleteSelectedMacro()
        {
            if (macrosList.SelectedIndex < 0 || macrosList.SelectedIndex >= macrosList.Items.Count)
                return;

            Macro macro = _profile.GetMacroAtIndex(macrosList.SelectedIndex);
            macrosList.Items.RemoveAt(macrosList.SelectedIndex);
            _profile.RemoveMacro(macro.Note);
            delMacroButton.Enabled = false;

            if (_profile.MacrosCount <= 1)
            {
                if (_profile.MacrosCount == 0)
                {
                    macrosList.Items.Add("No macros");
                    macrosList.Enabled = false;
                }
            }
        }
    }
}
