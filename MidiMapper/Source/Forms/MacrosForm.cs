using System;
using System.Windows.Forms;
using MidiMapper.Controller;
using MidiMapper.Macros;

namespace MidiMapper.Forms
{
    public partial class MacrosForm : Form
    {
        private readonly MidiMapperController _controller;
        private readonly Profile _profile;

        public MacrosForm(MidiMapperController controller)
        {
            InitializeComponent();

            _controller = controller;
            _profile = _controller.Profile;

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
            ManageMacroForm newMacroForm = new ManageMacroForm(_controller);
            newMacroForm.ShowDialog();
            LoadMacrosList();
        }

        private void EditMacroButton_Click(object sender, EventArgs e)
        {
            editMacroButton.Enabled = false;
            deleteMacroButton.Enabled = false;

            Macro selectedMacro = _profile.GetMacroAtIndex(macrosList.SelectedIndex);
            ManageMacroForm editMacroForm = new ManageMacroForm(_controller, selectedMacro);
            editMacroForm.ShowDialog();
            LoadMacrosList();
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
