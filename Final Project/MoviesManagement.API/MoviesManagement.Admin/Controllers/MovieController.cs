using Microsoft.AspNetCore.Mvc;

namespace MoviesManagement.Admin.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
