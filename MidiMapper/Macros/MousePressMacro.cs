using InputManager;
using System;
using MidiMapper.Exceptions;

namespace MidiMapper.Macros
{
    public class MousePressMacro : Macro
    {
        private readonly Mouse.MouseKeys _mouseKey;

        public MousePressMacro(string macroName, string note, Mouse.MouseKeys mouseKey) : base(macroName, note)
        {
            _mouseKey = mouseKey;
        }

        public override void Execute()
        {
            Mouse.ButtonDown(_mouseKey);
        }

        public override void Stop()
        {
            Mouse.ButtonUp(_mouseKey);
        }

        public override string GetMacroTaskDescription()
        {
            return $"Presses '{_mouseKey}' mouse button";
        }

        public override string SerializeMacro()
        {
            return SerializeMacro(MacroName, Note, MacroType.MousePress, _mouseKey.ToString());
        }

        public static MousePressMacro DeserializeMacro(string macroName, string note, string options)
        {
            if (!Enum.TryParse(options, false, out Mouse.MouseKeys mKey))
                throw new DeserializeMacroException($"'{options}' is not a valid mouse key");
                
            return new MousePressMacro(macroName, note, mKey);
        }
    }
}
