using Microsoft.AspNetCore.Mvc;

namespace BerberSalonu.Controllers
{
    public class RandevuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
