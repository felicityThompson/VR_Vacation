using VR_Vacation.Models;

namespace VR_Vacation.Services
{
    public interface IUserService
    {
        /// <summary>
        /// Gets current session user
        /// </summary>
        /// <returns>User</returns>
        UserVm GetUser();

        /// <summary>
        /// Add session user
        /// </summary>
        /// <param name="user">UserVm user</param>
        /// <returns>success / fail</returns>
        bool PostUser(UserVm user);

        /// <summary>
        /// Verify users credentials
        /// </summary>
        /// <param name="user">LogInVm user</param>
        /// <returns>success / fail</returns>
        bool VerifyUser(LoginVm user);

        /// <summary>
        /// Removes current user from session
        /// </summary>
        void RemoveUser();
    }
}
