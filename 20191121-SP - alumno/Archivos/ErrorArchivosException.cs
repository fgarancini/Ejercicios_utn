using System;
using System.Runtime.Serialization;

namespace Archivos
{
    [Serializable]
    public class ErrorArchivosException : Exception
    {
        public ErrorArchivosException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public ErrorArchivosException(string message) : base(message)
        {
        }

    }
}