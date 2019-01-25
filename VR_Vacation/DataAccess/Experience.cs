using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VR_Vacation.DataAccess
{
    public class Experience
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
        public int PackageId { get; set; }

        public virtual Package Package { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}