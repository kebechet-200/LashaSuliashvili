using Mapster;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Web.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoviesManagement.Web.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IMovieService _service;

        public HomeController(IMovieService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var moviesEntity = await _service.GetAllAsync();
            return View(moviesEntity.Adapt<List<MovieViewModel>>());
        }

        public async Task<IActionResult> Details(int id)
        {
            ViewBag.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var entity = await _service.GetFullAsync(id);
            return View(entity.Adapt<MovieViewModel>());
        }
    }
}
