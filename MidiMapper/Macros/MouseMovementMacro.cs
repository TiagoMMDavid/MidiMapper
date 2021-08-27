using System;
using InputManager;
using System.Windows.Forms;
using MidiMapper.Exceptions;

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
            return SerializeMacro(MacroName, Note, MacroType.MOUSE_MOVE, String.Format("({0},{1})", _xAxis, _yAxis));
        }

        public static MouseMovementMacro DeserializeMacro(string macroName, string note, string options)
        {
            // Extract (x,y)
            string[] mouseMovement = options.Trim('(', ')').Split(',');
            if (mouseMovement.Length != 2)
                throw new DeserializeMacroException("Invalid coordinates format");

            try
            {
                int x = int.Parse(mouseMovement[0]);
                int y = int.Parse(mouseMovement[1]);
                return new MouseMovementMacro(macroName, note, x, y);
            }
            catch (FormatException)
            {
                throw new DeserializeMacroException("x and/or y is not an integer");
            }
        }
    }
}
