using System;
using System.Windows.Forms;
using InputManager;
using MidiMapper.Enums;
using MidiMapper.Exceptions;

namespace MidiMapper.Macros
{
    public class KeyboardPressMacro : Macro
    {
        private readonly Keys _kbdKey;

        public KeyboardKeys Key { get; private set; }

        public KeyboardPressMacro(string macroName, string note, KeyboardKeys kbdKey) : base(macroName, note)
        {
            Key = kbdKey;
            string enumName = Enum.GetName(typeof(Keys), (int) kbdKey);
            _kbdKey = (Keys) Enum.Parse(typeof(Keys), enumName, true);
        }

        public override void Execute() => Keyboard.KeyDown(_kbdKey);

        public override void Stop() => Keyboard.KeyUp(_kbdKey);

        public override string GetMacroTaskDescription() => $"Presses '{Key}' keyboard key";

        public override MacroType GetMacroType() => MacroType.KbdPress;

        public override string SerializeMacro() => SerializeMacro(MacroName, Note, MacroType.KbdPress, _kbdKey.ToString());

        public static KeyboardPressMacro DeserializeMacro(string macroName, string note, string options)
        {
            if (!Enum.TryParse(options, true, out KeyboardKeys key))
                throw new DeserializeMacroException($"'{options}' is not a valid keyboard key");
            
            return new KeyboardPressMacro(macroName, note, key);
        }
    }
}
