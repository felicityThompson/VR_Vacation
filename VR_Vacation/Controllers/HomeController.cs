using System.Web.Mvc;
using VR_Vacation.Repositories;

namespace VR_Vacation.Controllers
{
    public class HomeController : Controller
    {
        private IVacationRepository _vacationRepository;

        public HomeController(IVacationRepository vacationService)
        {
            _vacationRepository = vacationService;
        }

        //GET
        public ActionResult Index()
        {
            return View();
        }

    }
}