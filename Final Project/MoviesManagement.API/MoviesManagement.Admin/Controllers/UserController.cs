using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Admin.Models;
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

        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetAllUserWithRoles();
            return View(users.Adapt<List<GetUserWithRolesViewModel>>());
        }

        public IActionResult GiveRole()
        {
            return View();
        }

    }
}
