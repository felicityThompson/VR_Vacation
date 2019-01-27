using System.Collections.Generic;

namespace VR_Vacation.Models
{
    public class OrderVm
    {
        public double Total { get; set; }

        public int UserId { get; set; }

        public virtual List<PackageVm> Packages { get; set; }

        public virtual List<ExperienceVm> Experiences { get; set; }
    }
}