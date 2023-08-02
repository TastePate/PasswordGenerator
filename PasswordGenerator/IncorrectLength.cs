using System;
using System.Runtime.Serialization;

namespace PasswordGenerator
{
    [Serializable]
    internal class IncorrectLength : Exception
    {
        public IncorrectLength()
        {
        }

        public IncorrectLength(string message) : base(message)
        {
        }

        public IncorrectLength(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectLength(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}