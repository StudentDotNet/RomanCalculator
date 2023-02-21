using System;
using System.Runtime.Serialization;

namespace RomanCalculator.Exceptions
{
    [Serializable]
    public class RomanCalculatorException : Exception
    {
        public RomanCalculatorException() { }

        protected RomanCalculatorException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public RomanCalculatorException(string message) : base(message) { }

        public RomanCalculatorException(string message, Exception innerException) : base(message, innerException) { }
    }
}
