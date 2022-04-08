using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Ef.Repositories
{
    public  class UserRepository : IUserRepository
    {
        private readonly IBaseRepository<User> _baseRepository;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRepository(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager, IBaseRepository<User> baseRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _baseRepository = baseRepository;
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

        public async Task<List<User>> GetAllAsync()
        {
            return await _baseRepository.Table.ToListAsync();
        }

        public async Task<User> GetAsync(string id)
        {
            return await _baseRepository.Table.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> GetFullAsync(string id)
        {
            return await _baseRepository.Table.Include(x => x.Tickets).SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(User user)
        {
            await _baseRepository.UpdateAsync(user);
        }

        public async Task DeleteAsync(string id)
        {
            var user = await this.GetAsync(id);
            if (user != null)
                await _baseRepository.RemoveAsync(user);
        }

        public async Task ChangeRoleAsync(string id, )
        {
            var user = await this.GetAsync(id);

            var roles = await _userManager.GetRolesAsync(user);
        }
    }
}
