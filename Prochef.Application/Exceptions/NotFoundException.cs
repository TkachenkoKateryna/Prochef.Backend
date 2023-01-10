using System;
using System.Collections.Generic;
using System.Text;

namespace Prochef.Application.Exceptions
{
    public class NotFoundException<T> : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
