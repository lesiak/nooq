using System.Runtime.Serialization;

namespace Nooq.Exception
{
    public class TooManyRowsException: InvalidResultException
    {
        public TooManyRowsException()
        {
        }

        protected TooManyRowsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public TooManyRowsException(string message) : base(message)
        {
        }

        public TooManyRowsException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}