using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Services.Abstractions
{
    public interface IAccountService
    {
        Task<string> AuthenticateLoginAsync(string username, string password);
    }
}
