using Microsoft.AspNetCore.Mvc;

namespace BerberSalonu.Controllers
{
    public class CalisanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
