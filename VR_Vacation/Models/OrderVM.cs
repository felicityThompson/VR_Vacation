using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VR_Vacation.Models
{
    public class OrderVm
    {
        public double Total { get; set; }

        public bool IsPaid { get; set; }

        public int UserId { get; set; }

        public virtual List<PackageVm> Packages { get; set; }

        public virtual List<ExperienceVm> Experiences { get; set; }
    }
}