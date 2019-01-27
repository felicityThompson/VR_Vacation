using System.Collections.Generic;
using System.Linq;
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

        public List<DestinationVm> GetDestination()
        {
            using (var context = new VacationContext())
            {
                var destination = context.Destinations.ToList();
                var destinationVm = _mapper.Map<List<DestinationVm>>(destination);

                return destinationVm;
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

        public List<ExperienceVm> GetExperienceByPackageId(int id)
        {
            using (var context = new VacationContext())
            {
                var experience = context.Experiences.Where(x => x.Package.Id == id).ToList();

                var experienceVm = _mapper.Map<List<ExperienceVm>>(experience);

                return experienceVm;
            }
        }

        public int PostOrder(OrderVm orderVm)
        {
            using (var context = new VacationContext())
            {
                var orderDao = new Order
                {
                    Total = orderVm.Total,
                    UserId = orderVm.UserId
                };

                //fetch all experiences from order ids
                var temp = orderVm.Experiences.Select(x => int.Parse(x.Id));
                var experiences = context.Experiences.Where(x => temp.Contains(x.Id)).ToList();

                //fetch all packages from order ids
                temp = orderVm.Packages.Select(c => c.Id);
                var packages = context.Packages.Where(x => temp.Contains(x.Id)).ToList();

                //bind them to order
                orderDao.Experiences = experiences;
                orderDao.Packages = packages;

                context.Orders.Add(orderDao);
                context.SaveChanges();

                return orderDao.Id;
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
                var packages = context.Packages.Where(x => x.Destination.Id == id).ToList();
                var packagesVm = _mapper.Map<List<PackageVm>>(packages);

                return packagesVm;
            }
        }

        public int PostUser(UserVm userVm)
        {
            using (var context = new VacationContext())
            {
                //check for username
                if (context.Users.Any(u => u.Username == userVm.Username)) return 0;

                var userDao = _mapper.Map<User>(userVm);
                context.Users.Add(userDao);
                context.SaveChanges();
                return userDao.Id;
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