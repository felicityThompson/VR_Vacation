using System;
using System.Web.Mvc;
using VR_Vacation.Models;
using VR_Vacation.Repositories;

namespace VR_Vacation.Controllers
{
    public class UserController : Controller
    {
        private IVacationRepository _vacationRepository;

        public UserController(IVacationRepository vacationRepository)
        {
            _vacationRepository = vacationRepository;
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
                if (_vacationRepository.PostUser(user))
                {
                    if (user != null)
                    {
                        Session["user"] = user;

                        return Redirect("/Home/Index");
                    }
                }
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
                var user = _vacationRepository.VerifyUser(login.Username, login.Password);

                if (user != null)
                {
                    Session["user"] = user;

                    return Redirect("/Home/Index");                    
                }
                TempData["Error"] = "Username or password is incorrect";
            }

            return View("LogIn");
        }

        public ActionResult Logout()
        {
            Session["user"] = null;

            return Redirect("/Home/Index");
        }
    }
}