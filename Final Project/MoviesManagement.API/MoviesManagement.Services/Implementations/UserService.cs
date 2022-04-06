using Mapster;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Enum;
using MoviesManagement.Services.Exceptions;
using MoviesManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<string> AuthenticateAsync(UserModel user)
        {
            var userEntity = user.Adapt<User>();
            if (!await _repo.Exists(userEntity))
                throw new UserDoesNotExist("მომხმარებელი ვერ მოიძებნა");
            
            var entity = await _repo.LoginAsync(userEntity);

            if (!entity.isRegistered)
                throw new InvalidLoginAttemptException("იუზერნეიმი ან პაროლი არასწორია.");

            return entity.UserId;
        }

        public async Task<RegisterStatus> CreateAsync(UserModel user)
        {
            var entity = user.Adapt<User>();
            if (!await _repo.CreateAsync(entity))
                return RegisterStatus.RegisterFailed;

            return RegisterStatus.RegisteredSuccessfully;
        }
    }
}
