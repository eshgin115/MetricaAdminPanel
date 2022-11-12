using Microsoft.AspNetCore.Mvc;

namespace MatricAdminPanel.Controllers.DashBoard
{
    public class HospitalController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
