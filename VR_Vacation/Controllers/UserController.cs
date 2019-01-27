using System.Web.Mvc;
using VR_Vacation.Models;
using VR_Vacation.Services;

namespace VR_Vacation.Controllers
{
    public class UserController : Controller
    {
        private IUserService _iUserService;

        public UserController(IUserService iUserService)
        {
            _iUserService = iUserService;
        }

        //Sign Up
        public ActionResult SignUp()
        {
            return View();
        }

        //POST : User
        [HttpPost]
        public ActionResult PostUser(UserVm user)
        {
            if (ModelState.IsValid)
            {
                if (_iUserService.PostUser(user)) return Redirect("/Home/Index");

                TempData["Error"] = "Username already in use";

            }
            return View("SignUp");
        }

        //Log In
        public ActionResult LogIn()
        {
            return View("LogIn");
        }

        //POST: Verify User log in details
        [HttpPost]
        public ActionResult VerifyUser(LoginVm login)
        {
            if (ModelState.IsValid)
            {
                if(_iUserService.VerifyUser(login)) return Redirect("/Home/Index");

                TempData["Error"] = "Username or password is incorrect";
            }

            return View("LogIn");
        }

        public ActionResult Logout()
        {
            _iUserService.RemoveUser();

            return Redirect("/Home/Index");
        }
    }
}