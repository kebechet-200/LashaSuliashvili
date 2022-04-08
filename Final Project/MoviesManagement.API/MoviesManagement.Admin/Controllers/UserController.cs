using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Services.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesManagement.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {

        public IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult GiveRole()
        {
            return View();
        }

        public async Task<List<IActionResult>> GetAllAsync()
        {
            var users = await _userService.
        }
    }
}
