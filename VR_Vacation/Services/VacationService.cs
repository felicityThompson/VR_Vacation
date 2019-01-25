using System.Collections.Generic;
using VR_Vacation.Models;
using VR_Vacation.Repositories;

namespace VR_Vacation.Services
{
    public class VacationService : IVacationService
    {
        private IVacationRepository _repository;

        public VacationService(IVacationRepository repository)
        {
            _repository = repository;
        }

        public DestinationVm GetDestination(int id)
        {
            var destination = _repository.GetDestination(id);

            return destination;
        }

        public List<DestinationVm> GetDestination()
        {
            var destinations = _repository.GetDestination();

            return destinations;
        }

        public void PostDestination(DestinationVm destination)
        {

            _repository.PostDestination(destination);
        }

        public ExperienceVm GetExperience(int id)
        {
            var experience = _repository.GetExperience(id);

            return experience;
        }

        public List<ExperienceVm> GetExperience()
        {
            var experiences = _repository.GetExperience();

            return experiences;
        }

        public List<ExperienceVm> GetExperienceByPackageId(int id)
        {
            var experiences = _repository.GetExperienceByPackageId(id);

            return experiences;
        }

        public void PostExperience(ExperienceVm experience)
        { 

            _repository.PostExperience(experience);
        }

        public OrderVm GetOrder(int id)
        {
            var order = _repository.GetOrder(id);

            return order;
        }

        public List<OrderVm> GetOrder()
        {
            var orders = _repository.GetOrder();

            return orders;
        }

        public void PostOrder(OrderVm order)
        {
            _repository.PostOrder(order);
        }

        public PackageVm GetPackage(int id)
        {
            var package = _repository.GetPackage(id);

            return package;
        }

        public List<PackageVm> GetPackage()
        {
            var packages = _repository.GetPackage();

            return packages;
        }

        public List<PackageVm> GetPackagesByDestinationId(int id)
        {
            var packages = _repository.GetPackagesByDestinationId(id);

            return packages;
        }

        public void PostPackage(PackageVm package)
        {
            _repository.PostPackage(package);
        }

        public UserVm GetUser(int id)
        {
            var user = _repository.GetUser(id);

            return user;
        }

        public List<UserVm> GetUser()
        {
            var user = _repository.GetUser();


            return user;
        }

        public void PostUser(UserVm user)
        {
            _repository.PostUser(user);
        }
    }
}