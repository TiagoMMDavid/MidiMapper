using System;
using InputManager;
using System.Windows.Forms;

namespace MidiMapper.Macros
{
    class MouseMovementMacro : Macro
    {
        private int _xAxis;
        private int _yAxis;

        private Timer _timer;
        private const int TimerInterval = 1;
        bool _timerRunning = false;

        public MouseMovementMacro(string macroName, string note, int xAxis, int yAxis) : base(macroName, note)
        {
            this._xAxis = xAxis;
            this._yAxis = yAxis;

            _timer = new Timer();
            _timer.Interval = TimerInterval;
            _timer.Enabled = true;
            _timer.Tick += new EventHandler(Timer_Tick);
        }

        public override void Execute()
        {
            _timerRunning = true;
        }

        public override void Stop()
        {
            _timerRunning = false;
        }

        private void Timer_Tick(object Sender, EventArgs e)
        {
            if (_timerRunning)
                Mouse.MoveRelative(_xAxis, _yAxis);
        }

        public override string SerializeMacro()
        {
            return String.Format("{0};{1};{2};({3},{4})", MacroName, Note, MacroType.Mouse_Move.ToString(), _xAxis, _yAxis);
        }

        public override string GetMacroInfo()
        {
            return String.Format("{0}: Moves mouse by ({1},{2})", MacroName, _xAxis, _yAxis);
        }
    }
}
