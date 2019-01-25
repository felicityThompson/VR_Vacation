using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VR_Vacation.DataAccess
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}