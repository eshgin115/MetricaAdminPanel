using Microsoft.AspNetCore.Mvc;

namespace MatricAdminPanel.Apps.Controllers
{
    public class AppsController : Controller
    {
        public ActionResult Chat()
        {
            return View();
        }
        public ActionResult ContactList()
        {
            return View();
        }
        public ActionResult Calendar()
        {
            return View();
        }
        public ActionResult Invoice()
        {
            return View();
        }
    }
}
