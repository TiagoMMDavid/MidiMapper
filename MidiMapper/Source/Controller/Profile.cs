﻿using System;
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
        public const int MaxProfileNameSize = 30;
        
        public string ProfileName { get; set; }
        public int MacrosCount => _macros.Count;

        private readonly OrderedDictionary _macros; // Dictionary<string, Macro> (key is the noteName)

        public Profile(string profileName)
        {
            if (profileName.Length > MaxProfileNameSize)
                throw new ArgumentException($"Profile name must not exceed {MaxProfileNameSize} characters");
            
            ProfileName = profileName;
            _macros = new OrderedDictionary();
        }

        public void AddMacro(string note, Macro macro)
        {
            if (!MidiUtils.IsNoteNameValid(note))
                throw new ArgumentException($"'{note}' is not a valid note name");

            if (_macros.Contains(note))
                throw new ArgumentException($"Macro in note '{note}' already exists");

            _macros.Add(note, macro);
        }

        public bool HasMacro(string note) => _macros.Contains(note);

        public Macro GetMacro(string note) => _macros[note] as Macro;

        public Macro GetMacroAtIndex(int idx)
        {
            if (idx < 0 || idx > _macros.Count)
                throw new IndexOutOfRangeException("Invalid index");

            return _macros[idx] as Macro;
        }

        public void RemoveMacro(string note)
        {
            if (!_macros.Contains(note))
                throw new ArgumentException($"Macro in note '{note}' does not exist");

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
                if (profileName == null || string.IsNullOrWhiteSpace(profileName))
                    throw new ParseProfileFileException("First line of file must be the profile name");
                if (profileName.Length > MaxProfileNameSize)
                    throw new ParseProfileFileException($"Profile name must not exceed {MaxProfileNameSize} characters [Line 1]");

                Profile profile = new Profile(profileName);

                string line;
                int lineNumber = 1;
                while ((line = reader.ReadLine()) != null) 
                {
                    lineNumber++;

                    // Ignore empty lines
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    Macro macro = ParseMacro(line, lineNumber, out string note);
                    try
                    {
                        profile.AddMacro(note, macro);
                    } catch (ArgumentException)
                    {
                        throw new ParseProfileFileException($"Notes can only be defined once ['{note}' is repeated]");
                    }
                }

                return profile;
            }
        }

        private static Macro ParseMacro(string serializedMacro, int lineNumber, out string note)
        {
            string[] parameters = serializedMacro.Split(Macro.SerializeDelimiter);
            if (parameters.Length != Macro.SerializeParamsCount)
                throw new ParseProfileFileException(GetErrorMessage($"Macro needs to have exactly {Macro.SerializeParamsCount} parameters", lineNumber));

            // Parse and validate macro name
            string macroName = parameters[Macro.SerializeNameIndex];
            if (string.IsNullOrWhiteSpace(macroName) || macroName.Length > Macro.MaxMacroNameSize)
                throw new ParseProfileFileException(GetErrorMessage(
                    $"Macro name size needs to be between 1-{Macro.MaxMacroNameSize} characters", lineNumber, Macro.SerializeNameIndex + 1)
                );

            // Parse and validate note name
            note = parameters[Macro.SerializeNoteIndex];
            if (!MidiUtils.IsNoteNameValid(note))
                throw new ParseProfileFileException(GetErrorMessage("Invalid note name", lineNumber, Macro.SerializeNoteIndex + 1));

            // Parse and validate macro type
            string typeName = parameters[Macro.SerializeTypeIndex].Replace("_", "");
            if (!Enum.TryParse(typeName, true, out Macro.MacroType type))
                throw new ParseProfileFileException(GetErrorMessage("Invalid macro type", lineNumber, Macro.SerializeTypeIndex + 1));

            // Parse and validate macro options
            string macroOptions = parameters[Macro.SerializeOptionsIndex];
            if (string.IsNullOrWhiteSpace(macroOptions))
                throw new ParseProfileFileException(GetErrorMessage("Macro options must not be empty", lineNumber, Macro.SerializeOptionsIndex + 1));
            
            try
            {
                // Deserialize macro
                return Macro.DeserializeMacro(macroName, note, type, macroOptions);
            } catch (DeserializeMacroException ex)
            {
                throw new ParseProfileFileException(GetErrorMessage(ex.Message, lineNumber, Macro.SerializeOptionsIndex + 1));
            }
        }

        private static string GetErrorMessage(string message, int lineNumber, int? paramNumber = null)
        {
            return paramNumber == null ? 
                $"{message} [Line {lineNumber}]" :
                $"{message} [Line {lineNumber} - Param {paramNumber}]";
        }
    }
}
