using System.Windows.Forms;
using InputManager;
using System;

namespace MidiMapper.Macros
{
    class KeyboardPressMacro : Macro
    {
        private Keys _kbdKey;

        public KeyboardPressMacro(string macroName, string note, Keys kbdKey) : base(macroName, note)
        {
            this._kbdKey = kbdKey;
        }

        public override void Execute()
        {
            Keyboard.KeyDown(_kbdKey);
        }

        public override void Stop()
        {
            Keyboard.KeyUp(_kbdKey);
        }

        public override string GetMacroInfo()
        {
            return GetMacroInfo(MacroName, String.Format("Presses '{0}' key", _kbdKey), Note);
        }

        public override string SerializeMacro()
        {
            return SerializeMacro(MacroName, Note, MacroType.KBD_Press, _kbdKey.ToString());
        }
    }
}
