using System;
using System.Runtime.Serialization;

namespace _1703HW
{
    [Serializable]
    internal class StringEmptyException : ApplicationException
    {
        public string Word { get; set; }
        public StringEmptyException(string word)
        {
            this.Word = word;
        }

        public StringEmptyException(string message, string word) : base(message)
        {
            this.Word = word;
        }

        public StringEmptyException(string message, Exception innerException, string word) : base(message, innerException)
        {
            this.Word = word;
        }

        protected StringEmptyException(SerializationInfo info, StreamingContext context, string word) : base(info, context)
        {
            this.Word = word;
        }
    }
}