using System;
using System.Collections.Generic;
using System.Text;
using Prochef.Application.Dtos.Response.JWTToken;

namespace Prochef.Core.Dtos.Response
{
    public class RestaurantResponse
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public ChainResponse Chain { get; set; }
    }
}
