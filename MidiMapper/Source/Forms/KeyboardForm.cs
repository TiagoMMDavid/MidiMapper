using System;
using System.Windows.Forms;
using InputManager;
using MidiMapper.Enums;

namespace MidiMapper.Source.Forms
{
    public partial class KeyboardForm : UserControl
    {
        public KeyboardKeys Key { get; }

        public KeyboardForm()
        {
            InitializeComponent();

            // Add keyboard keys to listBox
            string[] keyboardKeys = Enum.GetNames(typeof(KeyboardKeys));
            keysListBox.Items.AddRange(keyboardKeys);
        }
    }
}
