using Microsoft.AspNetCore.Mvc;

namespace DesafioMentoria.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
