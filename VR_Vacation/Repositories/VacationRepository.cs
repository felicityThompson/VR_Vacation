using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using VR_Vacation.DataAccess;
using VR_Vacation.Models;

namespace VR_Vacation.Repositories
{
    public class VacationRepository : IVacationRepository
    {
        private IMapper _mapper;

        public VacationRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public DestinationVm GetDestination(int id)
        {
            using (var context = new VacationContext())
            {
                var destination = context.Destinations.Find(id);
                var destinationVm = _mapper.Map<DestinationVm>(destination);

                return destinationVm;
            }
        }

        public List<DestinationVm> GetDestination()
        {
            using (var context = new VacationContext())
            {
                var destination = context.Destinations.ToList();
                var destinationVm = _mapper.Map<List<DestinationVm>>(destination);

                return destinationVm;
            }
        }

        public void PostDestination(DestinationVm destinationVm)
        {
            using (var context = new VacationContext())
            {
                var destinationDao = _mapper.Map<Destination>(destinationVm);

                context.Destinations.Add(destinationDao);
                context.SaveChanges();
            }
        }

        public ExperienceVm GetExperience(int id)
        {
            using (var context = new VacationContext())
            {
                var experience = context.Experiences.Find(id);
                var experienceVm = _mapper.Map<ExperienceVm>(experience);

                return experienceVm;
            }
        }

        public List<ExperienceVm> GetExperience()
        {
            using (var context = new VacationContext())
            {
                var experience = context.Experiences.ToList();
                var experienceVm = _mapper.Map<List<ExperienceVm>>(experience);
                return experienceVm;
            }
        }

        public List<ExperienceVm> GetExperienceByPackageId(int id)
        {
            using (var context = new VacationContext())
            {
                var experience = context.Experiences.ToList()
                    .FindAll(x => x.PackageId == id);
                var experienceVm = _mapper.Map<List<ExperienceVm>>(experience);

                return experienceVm;
            }
        }

        public void PostExperience(ExperienceVm experienceVm)
        {
            using (var context = new VacationContext())
            {
                var experienceDao = _mapper.Map<Experience>(experienceVm);

                context.Experiences.Add(experienceDao);
                context.SaveChanges();
            }
        }

        public OrderVm GetOrder(int id)
        {
            using (var context = new VacationContext())
            {
                var order = context.Orders.Find(id);
                var orderVm = _mapper.Map<OrderVm>(order);

                return orderVm;
            }
        }

        public List<OrderVm> GetOrder()
        {
            using (var context = new VacationContext())
            {
                var orders = context.Orders.ToList();
                var ordersVm = _mapper.Map<List<OrderVm>>(orders);

                return ordersVm;
            }
        }

        public void PostOrder(OrderVm orderVm)
        {
            using (var context = new VacationContext())
            {
                var orderDao = _mapper.Map<Order>(orderVm);

                context.Orders.Add(orderDao);
                context.SaveChanges();
            }
        }

        public PackageVm GetPackage(int id)
        {
            using (var context = new VacationContext())
            {
                var package = context.Packages.Find(id);
                var packageVm = _mapper.Map<PackageVm>(package);

                return packageVm;
            }
        }

        public List<PackageVm> GetPackage()
        {
            using (var context = new VacationContext())
            {
                var packages = context.Packages.ToList();
                var packagesVm = _mapper.Map<List<PackageVm>>(packages);

                return packagesVm;
            }
        }

        public List<PackageVm> GetPackagesByDestinationId(int id)
        {
            using (var context = new VacationContext())
            {
                var packages = context.Packages.ToList()
                    .FindAll(x => x.DestinationId == id);
                var packagesVm = _mapper.Map<List<PackageVm>>(packages);

                return packagesVm;
            }
        }

        public void PostPackage(PackageVm packageVm)
        {
            using (var context = new VacationContext())
            {
                var packageDao = _mapper.Map<Package>(packageVm);
                context.Packages.Add(packageDao);
                context.SaveChanges();
            }
        }

        public UserVm GetUser(int id)
        {
            using (var context = new VacationContext())
            {
                var user = context.Users.Find(id);
                var userVm = _mapper.Map<UserVm>(user);

                return userVm;
            }
        }

        public List<UserVm> GetUser()
        {
            using (var context = new VacationContext())
            {
                var users = context.Users.ToList();
                var usersVm = _mapper.Map<List<UserVm>>(users);

                return usersVm;
            }
        }

        public bool PostUser(UserVm userVm)
        {
            using (var context = new VacationContext())
            {
                //check for username
                if (context.Users.Any(u => u.Username == userVm.Username)) return false;

                var userDao = _mapper.Map<User>(userVm);
                context.Users.Add(userDao);
                context.SaveChanges();
                return true;
            }
        }

        public UserVm VerifyUser(string username, string password)
        {
            //verify username and password
            using (var context = new VacationContext())
            {
                var user = context.Users.FirstOrDefault(x => x.Username == username);
                if (user == null || !user.Password.Equals(password)) return null;
                var userVm = _mapper.Map<UserVm>(user);
                return userVm;
            }
        }
    }
}