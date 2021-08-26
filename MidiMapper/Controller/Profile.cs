using System;
using System.Collections.Specialized;
using System.Text;
using System.IO;
using MidiMapper.Macros;

namespace MidiMapper.Controller
{
    public class Profile
    {
        public string ProfileName { get; set; }
        public int MacrosCount { get => _macros.Count; }

        private OrderedDictionary _macros;

        public Profile(string profileName)
        {
            this.ProfileName = profileName;
            this._macros = new OrderedDictionary();
        }

        public void AddMacro(string note, Macro macro)
        {
            if (_macros.Contains(note))
                throw new ArgumentException(String.Format("Macro in note '{0}' already exists!", note));

            _macros.Add(note, macro);
        }

        public Macro GetMacro(string note)
        {
            Macro macro = _macros[note] as Macro;
            if (macro == null)
                throw new ArgumentException(String.Format("Macro in note '{0}' does not exist!", note));

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
                throw new ArgumentException(String.Format("Macro in note '{0}' does not exist!", note));

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
            {
                stringBuilder.AppendLine(macro.SerializeMacro());
            }
            return stringBuilder.ToString();
        }

        public static Profile GetProfileFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read profile name
                Profile profile = new Profile(reader.ReadLine());

                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    // Ignore empty lines
                    if (String.IsNullOrWhiteSpace(line))
                        continue;

                    // TODO: Do not hardcode index values and throw exception if macro is invalid
                    string[] serializedMacro = line.Split(Macro.SerializeDelimiter);
                    string note = serializedMacro[1];
                    Macro.MacroType type = (Macro.MacroType) Enum.Parse(typeof(Macro.MacroType), serializedMacro[2]);

                    profile.AddMacro(note, Macro.DeserializeMacro(serializedMacro[0], note, type, serializedMacro[3]));
                }

                return profile;
            }
        }
    }
}
