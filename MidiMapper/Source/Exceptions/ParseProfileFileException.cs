using System;

namespace MidiMapper.Exceptions
{
    [Serializable]
    public class ParseProfileFileException : Exception 
    {
        public ParseProfileFileException() { }

        public ParseProfileFileException(string message) : base(message) { }

        public ParseProfileFileException(string message, Exception inner) : base(message, inner) { }
    }
}
