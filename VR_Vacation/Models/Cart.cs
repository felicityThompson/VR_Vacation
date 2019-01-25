using System.Collections.Generic;

namespace VR_Vacation.Models
{
    public class Cart
    {
        public Cart()
        {
            Packages = new List<PackageVm>();

            Experiences = new List<ExperienceVm>();
        }

        public ICollection<PackageVm> Packages { get; set; }

        public ICollection<ExperienceVm> Experiences { get; set; }

        public double TotalAmount { get; set; }
    }
}