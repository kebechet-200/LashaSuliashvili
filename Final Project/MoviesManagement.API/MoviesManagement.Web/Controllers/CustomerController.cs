using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesManagement.Web.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomerController : Controller
    {
        private readonly IMovieService _service;

        public CustomerController(IMovieService service)
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
            var entity = await _service.GetAsync(id);
            return View(entity.Adapt<MovieViewModel>());
        }
    }
}
