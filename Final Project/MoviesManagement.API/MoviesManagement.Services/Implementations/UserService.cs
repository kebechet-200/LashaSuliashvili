using Mapster;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Enum;
using MoviesManagement.Services.Exceptions;
using MoviesManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
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
            if (!await _repo.ExistsName(userEntity.UserName))
                throw new UserDoesNotExist("მომხმარებელი ვერ მოიძებნა");
            
            var entity = await _repo.LoginAsync(userEntity, user.Password);

            if (!entity.isRegistered)
                throw new InvalidLoginAttemptException("იუზერნეიმი ან პაროლი არასწორია.");

            return entity.UserId;
        }

        public Task ChangeRoleAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<RegisterStatus> CreateAsync(UserModel user)
        {
            var entity = user.Adapt<User>();
            if (!await _repo.CreateAsync(entity, user.Password))
                return RegisterStatus.RegisterFailed;

            return RegisterStatus.RegisteredSuccessfully;
        }

        public async Task DeleteAsync(string id)
        {
            if (id == null || !await _repo.Exists(id))
                throw new UserDoesNotExist("მომხმარებელი ვერ მოიძებნა");

            await _repo.DeleteAsync(id);
        }

        public async Task<List<UserModel>> GetAllAsync()
        {
            var users = await _repo.GetAllAsync();
            if (users == null)
                throw new UserDoesNotExist("მომხმარებლები ვერ მოიძებნა");
            return users.Adapt<List<UserModel>>();
        }

        public async Task<List<UserRolesModel>> GetAllUserWithRoles()
        {
            var usersWithRoles = await _repo.GetAllUserWithRoles();
            if (usersWithRoles == null)
                throw new UserDoesNotExist("მომხმარებლები ვერ მოიძებნა");

            return usersWithRoles.Adapt<List<UserRolesModel>>();
        }

        public async Task<UserModel> GetAsync(string id)
        {
            if (id == null || !await _repo.Exists(id))
                throw new UserDoesNotExist($"შემოწოდებული id {id} მომხმარებელი ვერ იძებნება");

            var user = await _repo.GetAsync(id);

            return user.Adapt<UserModel>();
        }

        public async Task<UserModel> GetUserWithTicketsAsync(string id)
        {
            if (id == null || !await _repo.Exists(id))
                throw new UserDoesNotExist("მომხმარებელი ვერ იძებნება");

            var usersWithTickets = await _repo.GetUserWithTicketsAsync(id);

            return usersWithTickets.Adapt<UserModel>();
        }

        public async Task SignoutAsync()
        {
            await _repo.SignoutAsync();
        }

        public async Task UpdateAsync(UserModel user)
        {
            if (user == null || !await _repo.Exists(user.Id))
                throw new UserDoesNotExist("მომხმარებელი ვერ მოიძებნა");

            await _repo.UpdateAsync(user.Adapt<User>());
        }
    }
}
