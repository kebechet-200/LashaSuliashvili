using Mapster;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Models;
using MoviesManagement.Web.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoviesManagement.Web.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _service;
        private string userId = string.Empty;

        public TicketController(ITicketService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Buy(int movieId)
        {
            userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = new TicketRequestViewModel { MovieId = movieId, UserId = userId };
            await _service.BuyTicketAsync(data.Adapt<TicketModel>());
            return View();
        }

        public async Task<IActionResult> Reserve(int movieId)
        {
            userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = new TicketRequestViewModel { MovieId = movieId, UserId = userId };
            await _service.TicketReservationAsync(data.Adapt<TicketModel>());
            return View();
        }

        public async Task<IActionResult> Cancel(int movieId)
        {
            userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = new TicketRequestViewModel { MovieId = movieId, UserId = userId };
            await _service.CancelTicketAsync(data.Adapt<TicketModel>());
            return View();
        }
    }
}
