using System.Collections.Generic;
using VR_Vacation.Models;

namespace VR_Vacation.Services
{
    public interface IVacationService
    {
        DestinationVm GetDestination(int id);

        List<DestinationVm> GetDestination();

        void PostDestination(DestinationVm destination);

        ExperienceVm GetExperience(int id);

        List<ExperienceVm> GetExperience();

        List<ExperienceVm> GetExperienceByPackageId(int id);

        void PostExperience(ExperienceVm experience);

        OrderVm GetOrder(int id);

        List<OrderVm> GetOrder();

        void PostOrder(OrderVm order);

        PackageVm GetPackage(int id);

        List<PackageVm> GetPackage();

        List<PackageVm> GetPackagesByDestinationId(int id);

        void PostPackage(PackageVm package);

        UserVm GetUser(int id);

        List<UserVm> GetUser();

        void PostUser(UserVm user);
    }
}
