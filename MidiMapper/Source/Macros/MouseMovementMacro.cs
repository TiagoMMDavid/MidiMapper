using System;
using System.Timers;
using InputManager;
using MidiMapper.Exceptions;

namespace MidiMapper.Macros
{
    public class MouseMovementMacro : Macro
    {
        private const int TimerInterval = 1;
        private readonly Timer _timer;

        public int X { get; private set; }
        public int Y { get; private set; }

        public MouseMovementMacro(string macroName, string note, int xAxis, int yAxis) : base(macroName, note)
        {
            X = xAxis;
            Y = yAxis;

            _timer = new Timer()
            {
                Interval = TimerInterval,
                AutoReset = true
            };
            _timer.Elapsed += Timer_OnTimedEvent;
        }

        public override void Execute() => _timer.Start();

        public override void Stop() => _timer.Stop();

        // Event is only called when the macro is being executed
        private void Timer_OnTimedEvent(object sender, ElapsedEventArgs e) => Mouse.MoveRelative(X, Y);

        public override string GetMacroTaskDescription() => $"Moves mouse by ({X},{Y})";

        public override MacroType GetMacroType() => MacroType.MouseMove;

        public override string SerializeMacro() => SerializeMacro(MacroName, Note, MacroType.MouseMove, $"({X},{Y})");

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
