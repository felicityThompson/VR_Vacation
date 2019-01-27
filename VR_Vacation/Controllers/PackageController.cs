using System;
using System.Linq;
using System.Web.Mvc;
using VR_Vacation.Repositories;
using VR_Vacation.Services;

namespace VR_Vacation.Controllers
{
    public class PackageController : Controller
    {
        private IVacationRepository _vacationRepository;
        private ICartService _cartService;

        public PackageController(IVacationRepository vacationRepository, ICartService cartService)
        {
            _vacationRepository = vacationRepository;
            _cartService = cartService;
        }

        // GET: All Packages
        public ActionResult Index()
        {
            try
            {
                var packages = _vacationRepository.GetPackage();

                return View(packages.ToList());
            }
            catch (Exception e)
            {
                //Log Exception

                return View("Error");
            }
        }

        // GET: Selected Package
        public ActionResult GetPackage(int id)
        {
            try
            {
                var package = _vacationRepository.GetPackage(id);

                return View("Package", package);
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        // GET: Packages by Destination id
        public ActionResult GetPackageByDestinationId(int id)
        {
            try
            {
                var package = _vacationRepository.GetPackagesByDestinationId(id);

                return View("Index", package.ToList());
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        // Post: Add Package to Cart
        [HttpPost]
        public ActionResult AddPackageToCart(int id)
        {
            try
            {
                _cartService.AddPackage(id);

                return Json(new { status = 201, responseMessage = "Added to cart" });
            }
            catch (Exception e)
            {
                return Json(new { status = 500, responseMessage = "An error occured" });
            }
        }

        // Post: Remove Package from Cart
        [HttpPost]
        public ActionResult RemovePackageFromCart(int id)
        {
            try
            {
                _cartService.RemovePackage(id);

                return Json(new { status = 201, responseMessage = "Removed from cart" });
            }
            catch (Exception e)
            {
                return Json(new { status = 500, responseMessage = "An error occured" });
            }
        }
    }
}