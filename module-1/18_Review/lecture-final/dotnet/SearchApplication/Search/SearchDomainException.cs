using System;

namespace SearchApplication.Search
{
    public class SearchDomainException : Exception
    {
        public SearchDomainException() : base()
        {
        }
        public SearchDomainException(string message) : base(message)
        {
        }
        public SearchDomainException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
