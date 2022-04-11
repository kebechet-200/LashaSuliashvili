using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Admin.Models;
using MoviesManagement.Services.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesManagement.Admin.Controllers
{
    [Authorize(Roles = "Moderator,Admin")]
    public class MovieController : Controller
    {
        public IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetAllAsync();
            return View(movies.Adapt<List<MovieViewModel>>());
        }

        public async Task<IActionResult> Details(int id)
        {
            var movie = await _movieService.GetAsync(id);
            return View(movie.Adapt<MovieViewModel>());
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View();
        } 
    }
}
