using System;
using MidiMapper.Utils;
using MidiMapper.Exceptions;

namespace MidiMapper.Macros
{
    public abstract class Macro
    {
        public const char SerializeDelimiter = ';';
        public const int SerializeParamsCount = 4;
        public const int SerializeNameIndex = 0, SerializeNoteIndex = 1, SerializeTypeIndex = 2, SerializeOptionsIndex = 3;

        public const int MaxMacroNameSize = 25;

        public string MacroName { get; }
        public string Note { get; }

        protected Macro(string macroName, string note)
        {
            if (!MidiUtils.IsNoteNameValid(note))
                throw new ArgumentException($"'{note}' is not a valid note name");

            if (macroName.Length > MaxMacroNameSize)
                throw new ArgumentException($"Macro must not exceed {MaxMacroNameSize} characters");
            
            MacroName = macroName;
            Note = note;
        }

        public abstract void Execute();

        public abstract void Stop();
        
        public abstract string GetMacroTaskDescription();

        public abstract MacroType GetMacroType();

        public abstract string SerializeMacro();

        protected static string SerializeMacro(string macroName, string note, MacroType type, string macroOptions)
        {
            // Appends all macro information with a delimiter in between values
            return $"{macroName}{SerializeDelimiter}{note}{SerializeDelimiter}" +
                   $"{type}{SerializeDelimiter}{macroOptions}";
        }
        
        public enum MacroType
        {
            KbdPress,
            MousePress,
            MouseMove
        }

        public static Macro DeserializeMacro(string macroName, string note, MacroType type, string options)
        {
            switch(type)
            {
                case MacroType.KbdPress:
                    return KeyboardPressMacro.DeserializeMacro(macroName, note, options);
                case MacroType.MousePress:
                    return MousePressMacro.DeserializeMacro(macroName, note, options);
                case MacroType.MouseMove:
                    return MouseMovementMacro.DeserializeMacro(macroName, note, options);
                default:
                    throw new DeserializeMacroException($"Macro type '{type}' is not valid");
            }
        }
    }
}
