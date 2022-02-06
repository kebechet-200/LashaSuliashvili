using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonManagement.Models.Request;
using PersonManagement.Services.Abstractions;
using PersonManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonManagement.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
       
        [Route("Register")]
        [HttpPost]
        public async Task<IActionResult> Register(AccountCreateRequest user)
        {
            var result = await _userService.CreateAsync(user.Adapt<UserServiceModel>());

            return StatusCode((int)result);
        }

        [Route("LogIn")]
        [HttpPost]
        public async Task<IActionResult> LogIn(AccountLogInRequest user)
        {
            var result = await _userService.AuthenticationAsync(user.Username, user.Password);

            return StatusCode((int)result.Item1, result.Item2);
        }

        [Route("Confirmation")]
        public async Task<IActionResult> Confirmation(string token)
        {
            var isConfirmed = await _userService.IsConfirmed(token);

            if (isConfirmed == Status.NotFound)
            {
                return BadRequest("This link is expired or something went wrong. try again later");
            }
            return Ok("Registration was successful !!!");
        }

        [Route("PasswordReset")]
        [HttpPost]
        public async Task<IActionResult> PasswordReset(AccountPasswordResetRequest passwordReset)
        {
            var entity = passwordReset.Adapt<PasswordResetModel>();

            var result = await _userService.PasswordReset(entity);

            if (!(result == Status.Success))
            {
                return BadRequest("Something went wrong");
            }
            return Ok("Password Changed");
        }

    }
}
