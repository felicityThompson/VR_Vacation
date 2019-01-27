using System;
using System.Web.Mvc;
using VR_Vacation.Services;

namespace VR_Vacation.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ICartService _cartService;
        private IUserService _iUserService;

        public ShoppingCartController(ICartService cartService, IUserService userService)
        {
            _cartService = cartService;
            _iUserService = userService;
        }

        // GET: View Shopping Cart
        public ActionResult Index()
        {
            try
            {
                var cart = _cartService.GetCart();

                return View(cart);
            }
            catch (Exception e)
            {
                //Handle Exception

                return View("Error");
            }
        }

        // POST: Remove package
        public ActionResult RemovePackage(int id)
        {
            try
            {
                _cartService.RemovePackage(id);

                return View("Index");
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        // POST: Remove experience
        public ActionResult RemoveExperience(int id)
        {
            try
            {
                _cartService.RemoveExperience(id);

                return View("Index");
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        // POST: Checkout
        public ActionResult CheckOut()
        {
            //you must be logged in to do that
            var user = _iUserService.GetUser();

            if (user != null)
            {
                try
                {
                    var orderNumber = _cartService.Checkout(user.Id);

                    return Json(new { status = 201, responseMessage = "Success!!", orderNumber = orderNumber });
                }
                catch (Exception e)
                {
                    //Log exceptions                    
                }
            }

            return Json(new { status = 500, responseMessage = "You must be logged in to do that" });
        }
    }
}