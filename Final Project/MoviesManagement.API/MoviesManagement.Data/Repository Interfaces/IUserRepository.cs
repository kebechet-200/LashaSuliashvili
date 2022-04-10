using MoviesManagement.Domain.POCO;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;


namespace MoviesManagement.Data.Repository_Interfaces
{
    public interface IUserRepository
    {
        Task<bool> CreateAsync(User user, string password);
        Task<bool> Exists(string userId);
        Task<bool> ExistsName(string UserName);
        Task<(bool isRegistered, string UserId)> LoginAsync(User user, string password);

        Task SignoutAsync();

        Task<List<User>> GetAllAsync(); // maq
        Task<List<UserRoles>> GetAllUserWithRoles();
        Task<User> GetUserWithTicketsAsync(string id);
        Task<User> GetAsync(string id); // maq
        Task UpdateAsync(User user); // maq
        Task DeleteAsync(string id); // maq

        Task ChangeRoleAsync(string id);
    }
}
