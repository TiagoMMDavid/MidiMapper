using System;
using InputManager;
using MidiMapper.Enums;
using MidiMapper.Exceptions;

namespace MidiMapper.Macros
{
    public class MousePressMacro : Macro
    {
        private readonly Mouse.MouseKeys _mouseButton;
        private readonly string _keyName;

        public MousePressMacro(string macroName, string note, MouseButtons mouseButton) : base(macroName, note)
        {
            _keyName = mouseButton.ToString();
            string enumName = Enum.GetName(typeof(Mouse.MouseKeys), (int) mouseButton);
            _mouseButton = (Mouse.MouseKeys) Enum.Parse(typeof(Mouse.MouseKeys), enumName, true);
        }

        public override void Execute() => Mouse.ButtonDown(_mouseButton);

        public override void Stop() => Mouse.ButtonUp(_mouseButton);

        public override string GetMacroTaskDescription() => $"Presses '{_keyName}' mouse button";

        public override MacroType GetMacroType() => MacroType.MousePress;

        public override string SerializeMacro() => SerializeMacro(MacroName, Note, MacroType.MousePress, _mouseButton.ToString());

        public static MousePressMacro DeserializeMacro(string macroName, string note, string options)
        {
            if (!Enum.TryParse(options, true, out MouseButtons mKey))
                throw new DeserializeMacroException($"'{options}' is not a valid mouse key");
                
            return new MousePressMacro(macroName, note, mKey);
        }
    }
}
