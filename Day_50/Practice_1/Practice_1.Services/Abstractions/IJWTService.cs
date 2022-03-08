using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1.Services.Abstractions
{
    public interface IJWTService
    {
        string GenerateSecurityToken(string Username);
    }
}
