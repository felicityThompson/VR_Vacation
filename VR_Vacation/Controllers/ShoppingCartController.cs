using System.Web.Mvc;
using VR_Vacation.Repositories;
using VR_Vacation.Services;

namespace VR_Vacation.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IVacationRepository _vacationRepository;
        private ICartService _cartService;

        public ShoppingCartController(IVacationRepository vacationRepository, ICartService cartService)
        {
            _vacationRepository = vacationRepository;
            _cartService = cartService;
        }

        // GET: ShoppingCart
        public ActionResult Index()
        {
            var cart = _cartService.GetCart();

            return View(cart);
        }

        // add items

        //remove items

        //check out
    }
}