using Microsoft.AspNetCore.Mvc;

namespace MatricAdminPanel.Authentication
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Loginalt()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Registeralt()
        {
            return View();
        }
        public IActionResult RePassword()
        {
            return View();
        }
        public IActionResult RePasswordalt()
        {
            return View();
        }
        public IActionResult LockScreen()
        {
            return View();
        }
        //public IActionResult Loginalt()
        //{
        //    return View();
        //}
    }
}
