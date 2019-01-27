using System;
using System.Linq;
using System.Web.Mvc;
using VR_Vacation.Repositories;
using VR_Vacation.Services;

namespace VR_Vacation.Controllers
{
    public class ExperiencesController : Controller
    {
        private IVacationRepository _vacationRepository;
        private ICartService _cartService;

        public ExperiencesController(IVacationRepository vacationRepository, ICartService cartService)
        {
            _vacationRepository = vacationRepository;
            _cartService = cartService;
        }

        // GET: Experiences by package Id
        public ActionResult Index(int id)
        {
            try
            {
                var experiences = _vacationRepository.GetExperienceByPackageId(id);

                return PartialView(experiences.ToList());
            }
            catch (Exception e)
            {
                //Log Exception
                return View("Error");
            }
        }

        // POST: Add Experience to cart
        [HttpPost]
        public ActionResult AddExperienceToCart(int id)
        {
            try
            {
                _cartService.AddExperience(id);

                return Json(new { status = 201, responseMessage = "Added to cart" });
            }
            catch (Exception e)
            {
                return Json(new { status = 500, responseMessage = "An error occured" });
            }
        }

        // POST: Remove Experience from cart
        [HttpPost]
        public ActionResult RemoveExperienceFromCart(int id)
        {
            try
            {
                _cartService.RemoveExperience(id);

                return Json(new { status = 201, responseMessage = "removed from cart" });
            }
            catch (Exception e)
            {
                return Json(new { status = 500, responseMessage = "An error occured" });
            }
        }
    }
}