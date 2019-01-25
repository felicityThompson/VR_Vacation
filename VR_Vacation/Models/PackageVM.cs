using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VR_Vacation.Models
{
    public class PackageVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int DestinationId { get; set; }

        public virtual List<ExperienceVm> Experiences { get; set; }
    }
}