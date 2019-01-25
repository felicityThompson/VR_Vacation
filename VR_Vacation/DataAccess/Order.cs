using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VR_Vacation.DataAccess
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public bool IsPaid { get; set; }
        [Required]
        public int UserId { get; set; }

        public virtual ICollection<Package> Packages { get; set; }

        public virtual ICollection<Experience> Experiences { get; set; }

        public virtual User User { get; set; }
    }
}