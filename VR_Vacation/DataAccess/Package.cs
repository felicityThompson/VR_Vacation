using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VR_Vacation.DataAccess
{
    public class Package
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public int DestinationId { get; set; }

        public virtual Destination Destination { get; set; }

        public virtual ICollection<Experience> Experiences { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}