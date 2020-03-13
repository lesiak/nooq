using System.Runtime.Serialization;

namespace Nooq.Exception
{
    public class DataAccessException : System.Exception
    {
        public DataAccessException()
        {
        }

        protected DataAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public DataAccessException(string message) : base(message)
        {
        }

        public DataAccessException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}