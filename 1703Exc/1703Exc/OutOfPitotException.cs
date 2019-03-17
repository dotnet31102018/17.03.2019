using System;
using System.Runtime.Serialization;

namespace _1703Exc
{
    [Serializable]
    internal class OutOfPitotException : DishNotValidException
    {
        public OutOfPitotException()
        {
        }

        public OutOfPitotException(string message) : base(message)
        {
        }

        public OutOfPitotException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OutOfPitotException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}