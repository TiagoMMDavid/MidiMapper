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

        public override string SerializeMacro()
        {
            return String.Format("{0};{1};{2};{3}", MacroName, Note, MacroType.KBD_Press.ToString(), _kbdKey.ToString());
        }

        public override string GetMacroInfo()
        {
            return String.Format("{0}: Presses '{1}' key", MacroName, _kbdKey);
        }
    }
}
