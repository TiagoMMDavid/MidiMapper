using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MidiMapper.Enums;

namespace MidiMapper.Source.Forms.Controls
{
    public partial class KeyboardControl : UserControl
    {
        public KeyboardKeys? Key { get; private set; }

        public KeyboardControl()
        {
            InitializeComponent();

            // Add keyboard keys to listBox
            string[] keyboardKeys = Enum.GetNames(typeof(KeyboardKeys));
            keysListBox.Items.Insert(0, "Select a Key");
            keysListBox.Text = "Select a Key";
            keysListBox.Items.AddRange(keyboardKeys);
            keysListBox.SelectedIndexChanged += KeysListBox_SelectedIndexChanged;

            // Add an event button handler to every button inside the keyboard panel
            List<Button> keyboardButtons = keyboardPanel.Controls.OfType<Button>().Where(b => b.Enabled).ToList();
            foreach(Button button in keyboardButtons)
            {
                string enumName = button.Name.Substring(0, button.Name.IndexOf("Button")); // Remove "button" from name

                KeyboardKeys key = (KeyboardKeys) Enum.Parse(typeof(KeyboardKeys), enumName, true);
                button.Click += (object sender, EventArgs e) =>
                {
                    // OnClickHandler
                    UpdateKey(key);
                };
            }
        }

        public void UpdateKey(KeyboardKeys key)
        {
            keysListBox.Text = key.ToString();
            Key = key;
        }

        private void KeysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Remove placeholder
            keysListBox.Items.Remove("Select a Key");
        }
    }
}
