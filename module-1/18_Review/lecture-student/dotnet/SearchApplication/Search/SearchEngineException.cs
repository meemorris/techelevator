using System;

namespace SearchApplication.Search
{
    public class SearchEngineException : Exception
    {
        public SearchEngineException() : base()
        {
        }
        public SearchEngineException(string message) : base(message)
        {
        }
        public SearchEngineException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
