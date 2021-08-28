using System;
using System.Windows.Forms;
using InputManager;
using MidiMapper.Exceptions;

namespace MidiMapper.Macros
{
    public class KeyboardPressMacro : Macro
    {
        private readonly Keys _kbdKey;

        public KeyboardPressMacro(string macroName, string note, Keys kbdKey) : base(macroName, note)
        {
            _kbdKey = kbdKey;
        }

        public override void Execute()
        {
            Keyboard.KeyDown(_kbdKey);
        }

        public override void Stop()
        {
            Keyboard.KeyUp(_kbdKey);
        }

        public override string GetMacroTaskDescription()
        {
            return $"Presses '{_kbdKey}' keyboard key";
        }

        public override string SerializeMacro()
        {
            return SerializeMacro(MacroName, Note, MacroType.KbdPress, _kbdKey.ToString());
        }

        public static KeyboardPressMacro DeserializeMacro(string macroName, string note, string options)
        {
            if (!Enum.TryParse(options, false, out Keys key))
                throw new DeserializeMacroException($"'{options}' is not a valid keyboard key");
            
            return new KeyboardPressMacro(macroName, note, key);
        }
    }
}
