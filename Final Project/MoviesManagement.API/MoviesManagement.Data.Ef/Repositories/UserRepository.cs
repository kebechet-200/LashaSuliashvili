using Microsoft.AspNetCore.Identity;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Ef.Repositories
{
    public  class UserRepository : IUserRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserRepository(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> CreateAsync(User user)
        {
            var register = await _userManager.CreateAsync(user, user.Password);

            if (!register.Succeeded)
                throw new System.Exception();

            return true;
        }

        public async Task<bool> Exists(User user)
        {
            return await _userManager.FindByNameAsync(user.UserName) != null;
        }

        public async Task<(bool isRegistered,string UserId)> LoginAsync(User user)
        {

            IdentityUser entity = await _userManager.FindByNameAsync(user.UserName);

            if (entity == null)
                return (false, null);// exception user could not found.
            
            var signInResult = await _signInManager.PasswordSignInAsync(entity, user.Password, false, false);

            if (!signInResult.Succeeded)
                return (false, null);

            return (true,entity.Id);

        }
    }
}
