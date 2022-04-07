using Microsoft.AspNetCore.Identity;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Ef.Repositories
{
    public  class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRepository(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<bool> CreateAsync(User user, string password)
        {
            var register = await _userManager.CreateAsync(user, password);

            if (register.Succeeded)
            {
                var defaultrole = await _roleManager.FindByNameAsync("Customer");
                if (defaultrole != null)
                {
                    IdentityResult roleresult = await _userManager.AddToRoleAsync(user, defaultrole.Name);
                    if (roleresult.Succeeded)
                        return true;
                }
                return true;
            }
            return false;   
        }

        public async Task<bool> Exists(User user)
        {
            return await _userManager.FindByNameAsync(user.UserName) != null;
        }

        public async Task<(bool isRegistered,string UserId)> LoginAsync(User user, string password)
        {

            var entity = await _userManager.FindByNameAsync(user.UserName);

            if (entity == null)
                return (false, null);// exception user could not found.
            
            var signInResult = await _signInManager.PasswordSignInAsync(entity, password, true, false);

            if (!signInResult.Succeeded)
                return (false, null);

            return (true,entity.Id);
        }

        public async Task SignoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public bool isSigned(ClaimsPrincipal principal)
        {
            return _signInManager.IsSignedIn(principal);
        }
    }
}
