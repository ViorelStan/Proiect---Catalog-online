using System.Runtime.Serialization;

namespace Proiect___Catalog_online.Exceptions
{
        [Serializable]
        internal class IdNotFoundException : Exception
        {
            public IdNotFoundException()
            {
            }

            public IdNotFoundException(string? message) : base(message)
            {
            }

            public IdNotFoundException(string? message, Exception? innerException) : base(message, innerException)
            {
            }

            protected IdNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }