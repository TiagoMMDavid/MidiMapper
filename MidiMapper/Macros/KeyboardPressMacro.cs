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

        public override string GetMacroInfo()
        {
            return GetMacroInfo(MacroName, $"Presses '{_kbdKey}' keyboard key", Note);
        }

        public override string SerializeMacro()
        {
            return SerializeMacro(MacroName, Note, MacroType.KBD_PRESS, _kbdKey.ToString());
        }

        public static KeyboardPressMacro DeserializeMacro(string macroName, string note, string options)
        {
            try
            {
                return new KeyboardPressMacro(macroName, note, (Keys) Enum.Parse(typeof(Keys), options));
            }
            catch (ArgumentException)
            {
                throw new DeserializeMacroException($"'{options}' is not a valid keyboard key");
            }
        }
    }
}
