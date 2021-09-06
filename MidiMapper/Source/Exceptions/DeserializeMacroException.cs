using System;

namespace MidiMapper.Exceptions
{
    [Serializable]
    public class DeserializeMacroException : Exception 
    {
        public DeserializeMacroException() { }

        public DeserializeMacroException(string message) : base(message) { }

        public DeserializeMacroException(string message, Exception inner) : base(message, inner) { }
    }
}
