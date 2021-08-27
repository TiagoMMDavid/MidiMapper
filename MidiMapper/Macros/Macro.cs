using System;
using System.Windows.Forms;
using InputManager;
using MidiMapper.Utils;
using MidiMapper.Exceptions;

namespace MidiMapper.Macros
{
    public abstract class Macro
    {
        public const char SerializeDelimiter = ';';
        public const int SerializeParamsCount = 4;
        public const int SerializeNameIndex = 0, SerializeNoteIndex = 1, SerializeTypeIndex = 2, SerializeOptionsIndex = 3; 

        public string MacroName { get; set; }
        public string Note { get; }

        public Macro(string macroName, string note)
        {
            if (!MidiUtils.IsNoteNameValid(note))
                throw new ArgumentException(note + " is not a valid note name");

            this.MacroName = macroName;
            this.Note = note;
        }

        public abstract void Execute();

        public abstract void Stop();

        // TODO: Maybe stop using GetMacroInfo and replace it with GetMacroDescription instead (Describes the macro function)
        public abstract string GetMacroInfo();

        public abstract string SerializeMacro();

        public static string GetMacroInfo(string macroName, string macroDescription, string note)
        {
            return String.Format("{0}: {1} [{2}]", macroName, macroDescription, note);
        }

        public static string SerializeMacro(string macroName, string note, MacroType type, string macroOptions)
        {
            // Appends all macro information with a delimiter in between values
            return String.Format("{1}{0}{2}{0}{3}{0}{4}", SerializeDelimiter, macroName, note, type.ToString(), macroOptions);
        }

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
                    throw new DeserializeMacroException("Macro type '" + type.ToString() + " is not valid!");
            }
        }
    }
}
