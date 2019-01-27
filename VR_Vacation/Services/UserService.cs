using System.Web;
using VR_Vacation.Models;
using VR_Vacation.Repositories;

namespace VR_Vacation.Services
{
    public class UserService : IUserService
    {
        private IVacationRepository _vacationRepository;

        public UserService(IVacationRepository vacationRepository)
        {
            _vacationRepository = vacationRepository;
        }

        public UserVm GetUser()
        {
            return HttpContext.Current.Session["User"] as UserVm;
        }

        public bool PostUser(UserVm user)
        {
            var userId = _vacationRepository.PostUser(user);
            if (userId > 0)
            {
                if (user != null)
                {
                    user.Id = userId;
                    SetUser(user);
                }

                return true;
            }

            return false;
        }

        public bool VerifyUser(LoginVm login)
        {
            var user = _vacationRepository.VerifyUser(login.Username, login.Password);

            if (user != null)
            {
                SetUser(user);
                return true;
            }

            return false;
        }

        private void SetUser(UserVm user)
        {
            HttpContext.Current.Session["User"] = user;
        }

        public void RemoveUser()
        {
            HttpContext.Current.Session["User"] = null;
        }
    }
}