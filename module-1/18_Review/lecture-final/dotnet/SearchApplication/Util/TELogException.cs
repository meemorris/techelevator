using System;

namespace SearchApplication.Util
{
    public class TELogException : Exception
    {
        public TELogException() : base()
        {
        }
        public TELogException(string message) : base(message)
        {
        }
        public TELogException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
