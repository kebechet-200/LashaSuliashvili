using PersonManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Services.Abstractions
{
    public interface IUserService
    {
        Task<(Status, UserServiceModel)> AuthenticationAsync(string username, string password);

        Task<Status> CreateAsync(UserServiceModel user);
        Task<Status> IsConfirmed(string token);
        Task<Status> PasswordReset(PasswordResetModel entity);
    }
}
