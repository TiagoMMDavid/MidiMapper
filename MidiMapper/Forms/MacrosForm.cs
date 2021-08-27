using System;
using System.Windows.Forms;
using MidiMapper.Controller;
using MidiMapper.Macros;

namespace MidiMapper.Forms
{
    public partial class MacrosForm : Form
    {
        private readonly Profile _profile;

        public MacrosForm(Profile profile)
        {
            InitializeComponent();

            _profile = profile;
            KeyDown += MacrosForm_KeyDown;
            LoadMacrosList();
        }

        private void LoadMacrosList()
        {
            macrosList.Items.Clear();
            if (_profile.MacrosCount == 0)
            {
                macrosList.Enabled = false;
                macrosList.Items.Add("No macros");
                return;
            }

            // Fill macros list
            macrosList.Enabled = true;
            for (int i = 0; i < _profile.MacrosCount; i++)
            {
                // TODO: Customize macro description
                macrosList.Items.Add(_profile.GetMacroAtIndex(i).GetMacroInfo());
            }
        }

        private void MacrosList_SelectedIndexChanged(object sender, EventArgs e)
        {
            delMacroButton.Enabled = macrosList.SelectedIndex != -1;
        }

        private void DelMacroButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedMacro();
        }
        
        // Listen to keyboard events
        private void MacrosForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Delete selected macro when pressing delete key
            if (e.KeyCode == Keys.Delete) DeleteSelectedMacro();
        }

        private void NewMacroButton_Click(object sender, EventArgs e)
        {
            // TODO: New macro functionality
            InsertNameForm insertMacroNameForm = new InsertNameForm("Create Macro", "Insert macro name", "Ok", "Cancel");
            insertMacroNameForm.ShowDialog();
            string macroName = insertMacroNameForm.GetName();
            if (macroName == null) return;

            PianoForm pianoForm = new PianoForm();
            pianoForm.ShowDialog();
            
            // KeybindForm keybindForm = new KeybindForm();
        }

        private void DeleteSelectedMacro()
        {
            if (macrosList.SelectedIndex == -1) return;

            Macro macro = _profile.GetMacroAtIndex(macrosList.SelectedIndex);
            macrosList.Items.RemoveAt(macrosList.SelectedIndex);
            _profile.RemoveMacro(macro.Note);
            delMacroButton.Enabled = false;
            
            if (_profile.MacrosCount != 0) return;
            macrosList.Items.Add("No macros");
            macrosList.Enabled = false;
        }
    }
}
