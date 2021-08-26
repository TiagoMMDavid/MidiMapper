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

        public override string GetMacroInfo()
        {
            return GetMacroInfo(MacroName, String.Format("Moves mouse by ({0},{1})", _xAxis, _yAxis), Note);
        }

        public override string SerializeMacro()
        {
            return SerializeMacro(MacroName, Note, MacroType.Mouse_Move, String.Format("({0},{1})", _xAxis, _yAxis));
        }
    }
}
