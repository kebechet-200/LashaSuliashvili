using MoviesManagement.Domain.POCO;
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
        bool isSigned(ClaimsPrincipal principal);
    }
}
