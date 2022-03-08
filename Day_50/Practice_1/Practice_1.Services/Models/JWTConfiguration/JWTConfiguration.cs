using System;
using System.Collections.Generic;
using System.Text;

namespace EstateManagement.Services.Models.JWTConfiguration
{
    public class JWTConfiguration
    {
        public string Secret { get; set; }
        public int ExpirationInMinutes { get; set; }
    }
}
