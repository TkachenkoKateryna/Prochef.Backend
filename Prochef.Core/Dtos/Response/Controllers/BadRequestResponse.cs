using System;
using System.Collections.Generic;
using System.Text;

namespace Prochef.Core.Dtos.Response.Controllers
{
    public class BadRequestResponseMessage
    {
        public BadRequestResponseMessage(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
