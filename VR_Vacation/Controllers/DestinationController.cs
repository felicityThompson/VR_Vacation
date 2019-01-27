using System;
using System.Linq;
using System.Web.Mvc;
using VR_Vacation.Repositories;

namespace VR_Vacation.Controllers
{
    public class DestinationController : Controller
    {
        private IVacationRepository _vacationRepository;

        public DestinationController(IVacationRepository vacationRepository)
        {
            _vacationRepository = vacationRepository;
        }
        // GET: Destination
        public ActionResult Index()
        {
            try
            {
                var destinations = _vacationRepository.GetDestination();

                return View(destinations.ToList());
            }
            catch (Exception e)
            {
                //Log exception

                return View("Error");
            }
        }
    }
}