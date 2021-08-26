using System;
using System.Windows.Forms;
using InputManager;

namespace MidiMapper.Macros
{
    public abstract class Macro
    {
        public const char SerializeDelimiter = ';';

        public string MacroName { get; set; }
        public string Note { get; }

        public Macro(string macroName, string note)
        {
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
            return String.Format("{0};{1};{2};{3}", macroName, note, type.ToString(), macroOptions);
        }

        public enum MacroType
        {
            KBD_Press,
            Mouse_Move,
            Mouse_Press
        }

        public static Macro DeserializeMacro(string macroName, string note, MacroType type, string options)
        {
            switch(type)
            {
                case MacroType.KBD_Press:
                    return new KeyboardPressMacro(macroName, note, (Keys) Enum.Parse(typeof(Keys), options));
                case MacroType.Mouse_Press:
                    return new MousePressMacro(macroName, note, (Mouse.MouseKeys) Enum.Parse(typeof(Mouse.MouseKeys), options));
                case MacroType.Mouse_Move:
                    string[] mouseMovement = options.Trim('(', ')').Split(',');
                    int x = int.Parse(mouseMovement[0]);
                    int y = int.Parse(mouseMovement[1]);

                    return new MouseMovementMacro(macroName, note, x, y);
                default:
                    throw new ArgumentException(String.Format("Macro type '{0}' is not valid!", type.ToString()));
            }
        }
    }
}
