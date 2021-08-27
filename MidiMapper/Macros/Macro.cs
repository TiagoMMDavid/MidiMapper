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

        public string MacroName { get; }
        public string Note { get; }

        protected Macro(string macroName, string note)
        {
            if (!MidiUtils.IsNoteNameValid(note))
                throw new ArgumentException($"'{note}' is not a valid note name");

            MacroName = macroName;
            Note = note;
        }

        public abstract void Execute();

        public abstract void Stop();

        // TODO: Maybe stop using GetMacroInfo and replace it with GetMacroDescription instead (Describes the macro function)
        public abstract string GetMacroInfo();

        public abstract string SerializeMacro();

        protected static string GetMacroInfo(string macroName, string macroDescription, string note)
        {
            return $"{macroName}: {macroDescription} [{note}]";
        }

        protected static string SerializeMacro(string macroName, string note, MacroType type, string macroOptions)
        {
            // Appends all macro information with a delimiter in between values
            return $"{macroName}{SerializeDelimiter}{note}{SerializeDelimiter}" +
                   $"{type.ToString()}{SerializeDelimiter}{macroOptions}";
        }

        // TODO: Change to suggested convention name
        public enum MacroType
        {
            KBD_PRESS,
            MOUSE_PRESS,
            MOUSE_MOVE
        }

        public static Macro DeserializeMacro(string macroName, string note, MacroType type, string options)
        {
            switch(type)
            {
                case MacroType.KBD_PRESS:
                    return KeyboardPressMacro.DeserializeMacro(macroName, note, options);
                case MacroType.MOUSE_PRESS:
                    return MousePressMacro.DeserializeMacro(macroName, note, options);
                case MacroType.MOUSE_MOVE:
                    return MouseMovementMacro.DeserializeMacro(macroName, note, options);
                default:
                    throw new DeserializeMacroException($"Macro type '{type}' is not valid");
            }
        }
    }
}
