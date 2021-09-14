using System;
using System.Windows.Forms;

namespace MidiMapper.Source.Forms.Controls
{
    public partial class MousePressControl : UserControl
    {
        public Enums.MouseButtons? MouseButton { get; private set; }

        public MousePressControl()
        {
            InitializeComponent();

            // Add mouse buttons to listBox
            string[] mouseButtons = Enum.GetNames(typeof(Enums.MouseButtons));
            buttonsListBox.Items.Insert(0, "Select a Button");
            buttonsListBox.Text = "Select a Button";
            buttonsListBox.Items.AddRange(mouseButtons);
            buttonsListBox.SelectedIndexChanged += ButtonsListBox_SelectedIndexChanged;
        }

        public void UpdateButton(Enums.MouseButtons button)
        {
            MouseButton = button;
            buttonsListBox.Text = button.ToString();
        }

        private void ButtonsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Remove placeholder
            buttonsListBox.Items.Remove("Select a Button");

            MouseButton = (Enums.MouseButtons) Enum.Parse(typeof(Enums.MouseButtons), buttonsListBox.Text, true);
        }

        #region Mouse Buttons
        private void LeftButton_Click(object sender, EventArgs e) => UpdateButton(Enums.MouseButtons.LeftButton);

        private void MiddleButton_Click(object sender, EventArgs e) => UpdateButton(Enums.MouseButtons.MiddleButton);

        private void RightButton_Click(object sender, EventArgs e) => UpdateButton(Enums.MouseButtons.RightButton);
        #endregion
    }
}
