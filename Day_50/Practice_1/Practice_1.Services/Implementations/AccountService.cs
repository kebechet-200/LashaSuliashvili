using EstateManagement.Data;
using Practice_1.Services.Abstractions;
using Practice1.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IJWTService _jwtService;
        private readonly IAccountRepository _repo;

        public AccountService(IJWTService jwtService, IAccountRepository repo)
        {
            _jwtService = jwtService;
            _repo = repo;
        }

        public async Task<string> AuthenticateLoginAsync(string username, string password)
        {
            var user = await _repo.GetAsync(username, password);

            if (user != null)
                return _jwtService.GenerateSecurityToken(user.Username);

            return "Username Or Password was wrong.";
        }
    }
}
