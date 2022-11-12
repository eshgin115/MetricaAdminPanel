using Microsoft.AspNetCore.Mvc;

namespace MatricAdminPanel.DashBoard.Controllers
{
    public class DashBoardController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
    }
}
