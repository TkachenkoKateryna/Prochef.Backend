using System;
using System.Collections.Generic;
using System.Text;

namespace Prochef.Application.Exceptions
{
    public class AlreadyExistsException<T> : Exception
    {
        public AlreadyExistsException(string message) : base(message)
        {
        }
    }
}
