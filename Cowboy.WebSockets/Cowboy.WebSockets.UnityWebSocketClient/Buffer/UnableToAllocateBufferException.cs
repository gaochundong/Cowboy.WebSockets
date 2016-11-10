using System;

namespace Cowboy.WebSockets
{
    [Serializable]
    public class UnableToAllocateBufferException : Exception
    {
        public UnableToAllocateBufferException()
            : base("Cannot allocate buffer after few trials.")
        {
        }
    }
}
