using Microsoft.AspNetCore.Mvc;

namespace BookingApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
