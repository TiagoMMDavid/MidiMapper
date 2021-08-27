using InputManager;
using System;
using MidiMapper.Exceptions;

namespace MidiMapper.Macros
{
    class MousePressMacro : Macro
    {
        // TODO: add MouseButtons and scroll with the other enums present in Mouse class
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

        public override string GetMacroInfo()
        {
            return GetMacroInfo(MacroName, $"Presses '{_mouseKey}' mouse button", Note);
        }

        public override string SerializeMacro()
        {
            return SerializeMacro(MacroName, Note, MacroType.MOUSE_PRESS, _mouseKey.ToString());
        }

        public static MousePressMacro DeserializeMacro(string macroName, string note, string options)
        {
            try
            {
                return new MousePressMacro(macroName, note, (Mouse.MouseKeys) Enum.Parse(typeof(Mouse.MouseKeys), options));
            }
            catch (ArgumentException)
            {
                throw new DeserializeMacroException($"'{options}' is not a valid mouse key");
            }
        }
    }
}
