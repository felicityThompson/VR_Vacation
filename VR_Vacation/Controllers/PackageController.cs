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
            var packages = _vacationRepository.GetPackage();

            return View(packages.ToList());
        }

        // GET: Selected Package
        public ActionResult GetPackage(int id)
        {
            var package = _vacationRepository.GetPackage(id);

            return View("Package", package);
        }

        // GET: Packages by Destination id
        public ActionResult GetPackageByDestinationId(int id)
        {
            var package = _vacationRepository.GetPackagesByDestinationId(id);

            return View("Index", package.ToList());
        }

        // Post: Add Package to Cart
        [HttpPost]
        public ActionResult AddPackageToCart(int id)
        {
            _cartService.AddPackage(id);

            return Json(new { status = 201, responseMessage = "Added to cart" });
        }

        // Post: Remove Package from Cart
        [HttpPost]
        public ActionResult RemovePackageFromCart(int id)
        {
            _cartService.RemovePackage(id);

            return Json(new { status = 201, responseMessage = "Removed from cart" });
        }
    }
}