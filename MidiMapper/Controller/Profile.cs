using System;
using System.Collections.Specialized;
using System.Text;
using System.IO;
using MidiMapper.Macros;
using MidiMapper.Exceptions;
using MidiMapper.Utils;

namespace MidiMapper.Controller
{
    public class Profile
    {
        public string ProfileName { get; set; }
        public int MacrosCount { get => _macros.Count; }

        private OrderedDictionary _macros; // Dictionary<string, Macro> (key is the noteName)

        public Profile(string profileName)
        {
            this.ProfileName = profileName;
            this._macros = new OrderedDictionary();
        }

        public void AddMacro(string note, Macro macro)
        {
            if (!MidiUtils.IsNoteNameValid(note))
                throw new ArgumentException(note + " is not a valid note name");

            if (_macros.Contains(note))
                throw new ArgumentException(String.Format("Macro in note '{0}' already exists", note));

            _macros.Add(note, macro);
        }

        public Macro GetMacro(string note)
        {
            Macro macro = _macros[note] as Macro;
            if (macro == null)
                throw new ArgumentException(String.Format("Macro in note '{0}' does not exist", note));

            return macro;
        }

        public Macro GetMacroAtIndex(int idx)
        {
            if (idx < 0 || idx > _macros.Count)
                throw new IndexOutOfRangeException("Invalid index");

            return _macros[idx] as Macro;
        }

        public void RemoveMacro(string note)
        {
            if (!_macros.Contains(note))
                throw new ArgumentException(String.Format("Macro in note '{0}' does not exist", note));

            _macros.Remove(note);
        }

        public Macro ExecuteMacroIfExists(string note, int velocity)
        {
            Macro macro = _macros[note] as Macro;
            macro?.Execute();

            return macro;
        }

        public Macro StopMacroIfExists(string note)
        {
            Macro macro = _macros[note] as Macro;
            macro?.Stop();

            return macro;
        }

        public string SerializeProfile()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(ProfileName).AppendLine().AppendLine();
            foreach (Macro macro in _macros.Values)
                stringBuilder.AppendLine(macro.SerializeMacro());

            return stringBuilder.ToString();
        }

        public static Profile ParseProfileFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read profile name
                string profileName = reader.ReadLine();
                if (profileName == null || String.IsNullOrWhiteSpace(profileName))
                    throw new ParseProfileFileException("First line of file must be the profile name");

                Profile profile = new Profile(profileName);

                string line;
                int lineNumber = 1;
                while ((line = reader.ReadLine()) != null) 
                {
                    lineNumber++;

                    // Ignore empty lines
                    if (String.IsNullOrWhiteSpace(line))
                        continue;

                    Macro macro = ParseMacro(line, lineNumber, out string note);
                    try
                    {
                        profile.AddMacro(note, macro);
                    } catch (ArgumentException)
                    {
                        throw new ParseProfileFileException("Notes can only be defined once [" + note + " is repeated]");
                    }
                }

                return profile;
            }
        }

        private static Macro ParseMacro(string serializedMacro, int lineNumber, out string note)
        {
            string[] parameters = serializedMacro.Split(Macro.SerializeDelimiter);
            if (parameters.Length != Macro.SerializeParamsCount)
                throw new ParseProfileFileException(GetErrorMessage("Macro needs to have exactly " + Macro.SerializeParamsCount + " parameters", lineNumber));

            string macroName = parameters[Macro.SerializeNameIndex];
            if (String.IsNullOrWhiteSpace(macroName))
                throw new ParseProfileFileException(GetErrorMessage("Macro name can not be empty", lineNumber, Macro.SerializeNameIndex + 1));

            note = parameters[Macro.SerializeNoteIndex];
            if (!MidiUtils.IsNoteNameValid(note))
                throw new ParseProfileFileException(GetErrorMessage("Invalid note name", lineNumber, Macro.SerializeNoteIndex + 1));

            Macro.MacroType type;
            try
            {
                string typeName = parameters[Macro.SerializeTypeIndex].ToUpper();
                type = (Macro.MacroType) Enum.Parse(typeof(Macro.MacroType), typeName);
            } catch (ArgumentException)
            {
                throw new ParseProfileFileException(GetErrorMessage("Invalid macro type", lineNumber, Macro.SerializeTypeIndex + 1));
            }

            string macroOptions = parameters[Macro.SerializeOptionsIndex];
            if (String.IsNullOrWhiteSpace(macroOptions))
                throw new ParseProfileFileException(GetErrorMessage("Macro options can not be empty", lineNumber, Macro.SerializeOptionsIndex + 1));

            try
            {
                return Macro.DeserializeMacro(macroName, note, type, macroOptions);
            } catch (DeserializeMacroException ex)
            {
                throw new ParseProfileFileException(GetErrorMessage(ex.Message, lineNumber, Macro.SerializeOptionsIndex + 1));
            }
        }

        private static string GetErrorMessage(string message, int lineNumber, int? paramNumber = null)
        {
            if (paramNumber != null) 
                return String.Format("{0} [Line {1} - Param {2}]", message, lineNumber, paramNumber);

            return String.Format("{0} [Line {1}]", message, lineNumber);
        }
    }
}
