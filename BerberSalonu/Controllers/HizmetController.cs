using Microsoft.AspNetCore.Mvc;

namespace BerberSalonu.Controllers
{
    public class HizmetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
