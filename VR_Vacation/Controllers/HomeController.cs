using System.Web.Mvc;

namespace VR_Vacation.Controllers
{
    public class HomeController : Controller
    {
        //GET
        public ActionResult Index()
        {
            return View();
        }

    }
}