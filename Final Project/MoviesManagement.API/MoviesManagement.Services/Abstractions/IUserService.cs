using MoviesManagement.Services.Enum;
using MoviesManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Services.Abstractions
{
    public interface IUserService
    {
        Task<RegisterStatus> CreateAsync(UserModel user);
        Task<string> AuthenticateAsync(UserModel user);
        Task SignoutAsync();
        bool isSigned(ClaimsPrincipal principal);
    }
}
