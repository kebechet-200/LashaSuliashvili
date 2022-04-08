using MoviesManagement.Domain.POCO;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;


namespace MoviesManagement.Data.Repository_Interfaces
{
    public interface IUserRepository
    {
        Task<bool> CreateAsync(User user, string password);
        Task<bool> Exists(User user);
        Task<(bool isRegistered, string UserId)> LoginAsync(User user, string password);

        Task SignoutAsync();

        Task<List<User>> GetAllAsync();
        Task<User> GetFullAsync(string id);
        Task<User> GetAsync(string id);
        Task UpdateAsync(User user);
        Task DeleteAsync(string id);

        Task ChangeRoleAsync(string id);
    }
}
