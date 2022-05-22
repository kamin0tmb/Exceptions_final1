using System;
using System.Runtime.Serialization;

namespace Exceptions_final
{
    [Serializable]
    internal class MyOwnException : Exception
    {
        public MyOwnException()
        {
        }
        public MyOwnException(string message) : base(message)
        {
        }

    }
}