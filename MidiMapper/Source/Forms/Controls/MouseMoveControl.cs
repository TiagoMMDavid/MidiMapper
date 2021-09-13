using System;
using System.Windows.Forms;

namespace MidiMapper.Source.Forms.Controls
{
    public partial class MouseMoveControl : UserControl
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public MouseMoveControl()
        {
            InitializeComponent();
        }

        public void UpdateAxis(int x, int y)
        {
            X = x; Y = y;
            mouseMoveX.Value = x; mouseMoveY.Value = y;
        }

        private void MouseMoveX_ValueChanged(object sender, EventArgs e) => 
            UpdateAxis((int) mouseMoveX.Value, (int) mouseMoveY.Value);

        private void MouseMoveY_ValueChanged(object sender, EventArgs e) =>
            UpdateAxis((int)mouseMoveX.Value, (int) mouseMoveY.Value);
    }
}
