using Microsoft.AspNetCore.Mvc;

namespace BerberSalonu.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
