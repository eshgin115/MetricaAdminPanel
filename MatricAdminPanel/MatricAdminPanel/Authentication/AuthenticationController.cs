using Microsoft.AspNetCore.Mvc;

namespace MatricAdminPanel.Authentication
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
