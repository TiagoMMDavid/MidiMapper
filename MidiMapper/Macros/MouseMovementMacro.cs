using System;
using InputManager;
using System.Windows.Forms;
using MidiMapper.Exceptions;

namespace MidiMapper.Macros
{
    public class MouseMovementMacro : Macro
    {
        private readonly int _xAxis;
        private readonly int _yAxis;

        private readonly Timer _timer;
        private const int TimerInterval = 1;

        public MouseMovementMacro(string macroName, string note, int xAxis, int yAxis) : base(macroName, note)
        {
            _xAxis = xAxis;
            _yAxis = yAxis;

            _timer = new Timer
            {
                Interval = TimerInterval, 
                Enabled = false,
            };
            _timer.Tick += Timer_Tick;
        }

        public override void Execute()
        {
            _timer.Enabled = true;
        }

        public override void Stop()
        {
            _timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Timer only ticks when the macro is being executed
            Mouse.MoveRelative(_xAxis, _yAxis);
        }

        public override string GetMacroInfo()
        {
            return GetMacroInfo(MacroName, $"Moves mouse by ({_xAxis},{_yAxis})", Note);
        }

        public override string SerializeMacro()
        {
            return SerializeMacro(MacroName, Note, MacroType.MOUSE_MOVE, $"({_xAxis},{_yAxis})");
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
