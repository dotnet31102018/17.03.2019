using System;
using System.Runtime.Serialization;

namespace _1703HW
{
    [Serializable]
    public class StringAlreadyExistException : Exception
    {
        public StringAlreadyExistException()
        {
        }

        public StringAlreadyExistException(string message) : base(message)
        {
        }

        public StringAlreadyExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StringAlreadyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}