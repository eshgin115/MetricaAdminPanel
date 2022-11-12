using Microsoft.AspNetCore.Mvc;

namespace MatricAdminPanel.Controllers.DashBoard
{
    public class ProjectController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
