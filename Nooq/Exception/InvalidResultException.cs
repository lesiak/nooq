using System.Runtime.Serialization;

namespace Nooq.Exception
{
    public class InvalidResultException: DataAccessException
    {
        public InvalidResultException()
        {
        }

        protected InvalidResultException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public InvalidResultException(string message) : base(message)
        {
        }

        public InvalidResultException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}