using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice_1.Models.Request.Account;
using Practice_1.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var token = await _service.AuthenticateLoginAsync(request.Username, request.Password);

            return Ok(token);
        }
    }
}
