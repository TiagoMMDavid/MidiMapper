using InputManager;
using System;

namespace MidiMapper.Macros
{
    class MousePressMacro : Macro
    {
        // TODO: add MouseButtons and scroll with the other enums present in Mouse class
        private Mouse.MouseKeys _mouseKey;

        public MousePressMacro(string macroName, string note, Mouse.MouseKeys mouseKey) : base(macroName, note)
        {
            this._mouseKey = mouseKey;
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
            return GetMacroInfo(MacroName, String.Format("Presses '{0}' mouse button", _mouseKey), Note);
        }

        public override string SerializeMacro()
        {
            return SerializeMacro(MacroName, Note, MacroType.Mouse_Press, _mouseKey.ToString());
        }
    }
}
