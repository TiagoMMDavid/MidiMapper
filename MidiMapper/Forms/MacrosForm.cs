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

        #region Macros List
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
                Macro macro = _profile.GetMacroAtIndex(i);
                string macroDesc = $"{$"[{macro.Note}]", -8}{macro.MacroName, -28}{macro.GetMacroTaskDescription()}";
                macrosList.Items.Add(macroDesc);
            }
        }

        private void MacrosList_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteMacroButton.Enabled = macrosList.SelectedIndex != -1;
            editMacroButton.Enabled = macrosList.SelectedIndex != -1; ;
        }
        #endregion

        #region Macro Buttons
        private void NewMacroButton_Click(object sender, EventArgs e)
        {
            MacroForm newMacroForm = new MacroForm(_profile, newMacro =>
            {
                // Called when new macro has been created
                // TODO:
            });
            newMacroForm.ShowDialog();
        }

        private void EditMacroButton_Click(object sender, EventArgs e)
        {
            Macro selectedMacro = _profile.GetMacroAtIndex(macrosList.SelectedIndex);
            MacroForm editMacroForm = new MacroForm(selectedMacro, _profile, newMacro =>
            {
                // Called when new macro has been edited
                // TODO:
            });
            editMacroForm.ShowDialog();
        }

        private void DeleteMacroButton_Click(object sender, EventArgs e) => DeleteSelectedMacro();
        #endregion

        // Listen to keyboard events
        private void MacrosForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Delete:
                    // Delete selected macro when pressing delete key
                    DeleteSelectedMacro();
                    break;
                case Keys.Escape:
                    // Close Form
                    this.Close();
                    break;
            }
        }

        private void DeleteSelectedMacro()
        {
            if (macrosList.SelectedIndex == -1) return;

            Macro macro = _profile.GetMacroAtIndex(macrosList.SelectedIndex);
            macrosList.Items.RemoveAt(macrosList.SelectedIndex);
            _profile.RemoveMacro(macro.Note);
            editMacroButton.Enabled = false;
            deleteMacroButton.Enabled = false;
            
            if (_profile.MacrosCount != 0) return;
            macrosList.Items.Add("No macros");
            macrosList.Enabled = false;
        }
    }
}
