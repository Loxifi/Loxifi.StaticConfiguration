using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Loxifi.Exceptions
{
    /// <summary>
    /// Thrown when an error occurs deserializing a configuration
    /// </summary>
    public class DeserializationException : Exception
    {
        internal DeserializationException()
        {
        }

        internal DeserializationException(string message) : base(message)
        {
        }

        internal DeserializationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        internal DeserializationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
