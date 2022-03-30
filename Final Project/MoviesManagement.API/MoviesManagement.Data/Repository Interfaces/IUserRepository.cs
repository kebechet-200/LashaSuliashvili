using MoviesManagement.Domain.POCO;
using System.Threading.Tasks;


namespace MoviesManagement.Data.Repository_Interfaces
{
    public interface IUserRepository
    {
        Task<bool> CreateAsync(User user);
        Task<bool> Exists(User user);
        Task<(bool isRegistered, string UserId)> LoginAsync(User user);
    }
}
