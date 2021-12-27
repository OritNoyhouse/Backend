using System;
using System.Runtime.Serialization;

namespace Bll
{
    [Serializable]
    internal class noIdExists : Exception
    {
        public noIdExists(int idDoctor)
        {
        }

        public noIdExists(string message) : base(message)
        {
        }

        public noIdExists(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected noIdExists(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}