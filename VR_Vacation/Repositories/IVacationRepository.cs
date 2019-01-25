using System;
using System.Collections.Generic;
using VR_Vacation.Models;

namespace VR_Vacation.Repositories
{
    public interface IVacationRepository
    {
        /// <summary>
        /// Gets a single destination
        /// </summary>
        /// <param name="id">Destination id</param>
        /// <returns>Destination</returns>
        DestinationVm GetDestination(int id);

        /// <summary>
        /// Gets all destinations
        /// </summary>
        /// <returns>List of Destinations</returns>
        List<DestinationVm> GetDestination();

        void PostDestination(DestinationVm destinationVm);

        /// <summary>
        /// Gets a single experience
        /// </summary>
        /// <param name="id">Experience id</param>
        /// <returns>Experience</returns>
        ExperienceVm GetExperience(int id);

        /// <summary>
        /// Gets all experiences
        /// </summary>
        /// <returns>List of Experience</returns>
        List<ExperienceVm> GetExperience();

        /// <summary>
        /// Gets all experiences by package Id
        /// </summary>
        /// <returns>List of Experience</returns>
        List<ExperienceVm> GetExperienceByPackageId(int id);

        void PostExperience(ExperienceVm experienceVm);

        /// <summary>
        /// Gets a single order
        /// </summary>
        /// <param name="id">Order id</param>
        /// <returns>Order</returns>
        OrderVm GetOrder(int id);

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <returns>List of Orders</returns>
        List<OrderVm> GetOrder();

        void PostOrder(OrderVm orderVm);

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

        void PostPackage(PackageVm packageVm);

        /// <summary>
        /// Gets a single user
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>User</returns>
        UserVm GetUser(int id);

        /// <summary>
        /// Gets all users
        /// </summary>
        /// <returns>List of Users</returns>
        List<UserVm> GetUser();

        bool PostUser(UserVm userVm);

        /// <summary>
        /// Verifies username and password
        /// </summary>
        /// <returns>User</returns>
        UserVm VerifyUser(string username, string password);
    }
}
