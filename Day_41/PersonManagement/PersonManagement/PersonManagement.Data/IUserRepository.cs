using PersonManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Data
{
    public interface IUserRepository
    {
        Task<User> GetAsync(string username, string password);
        Task CreateAsync(User user);
        Task<bool> Exists(string username);
        Task<bool> IsMatchToken(string token);
        Task<bool> PasswordReset(UserPasswordReset passwordResetUser);
    }
}
