using System.Collections.Generic;
using VR_Vacation.Models;

namespace VR_Vacation.Repositories
{
    public interface IVacationRepository
    {
        /// <summary>
        /// Gets all destinations
        /// </summary>
        /// <returns>List of Destinations</returns>
        List<DestinationVm> GetDestination();

        /// <summary>
        /// Gets a single experience
        /// </summary>
        /// <param name="id">Experience id</param>
        /// <returns>Experience</returns>
        ExperienceVm GetExperience(int id);

        /// <summary>
        /// Gets all experiences by package Id
        /// </summary>
        /// <returns>List of Experience</returns>
        List<ExperienceVm> GetExperienceByPackageId(int id);

        int PostOrder(OrderVm orderVm);

        /// <summary>
        /// Gets a single package
        /// </summary>
        /// <param name="id">Package id</param>
        /// <returns>Package</returns>
        PackageVm GetPackage(int id);

        /// <summary>
        /// Gets all packages
        /// </summary>
        /// <returns>List of Packages</returns>
        List<PackageVm> GetPackage();

        /// <summary>
        /// Gets all packages by destination id
        /// </summary>
        /// <returns>List of Packages</returns>
        List<PackageVm> GetPackagesByDestinationId(int id);

        int PostUser(UserVm userVm);

        /// <summary>
        /// Verifies username and password
        /// </summary>
        /// <returns>User</returns>
        UserVm VerifyUser(string username, string password);
    }
}
