using Mapster;
using PersonManagement.Data;
using PersonManagement.DataADO.Implementations;
using PersonManagement.Domain.POCO;
using PersonManagement.Services.Abstractions;
using PersonManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }


        public async Task<(Status, UserServiceModel)> AuthenticationAsync(string username, string password)
        {
            var result = await _repo.GetAsync(username, password).ConfigureAwait(false);

            if (result == null)
                return (Status.Unauth, null);

            return (Status.Success, result.Adapt<UserServiceModel>());
        }

        public async Task<Status> CreateAsync(UserServiceModel user)
        {
            if (await _repo.Exists(user.Username))
            {
                return Status.AlreadyExists;
            }
            await _repo.CreateAsync(user.Adapt<User>()).ConfigureAwait(false);
            return Status.Success;
        }

        public async Task<Status> IsConfirmed(string token)
        {
            if (!await _repo.IsMatchToken(token))
            {
                return Status.NotFound;
            }
            else return Status.Success;
        }

        public async Task<Status> PasswordReset(PasswordResetModel entity)
        {
            var passwordResetUser = entity.Adapt<UserPasswordReset>();
            if (!await _repo.PasswordReset(passwordResetUser))
            {
                return Status.NotFound;
            }
            return Status.Success;
        }
    }
}
