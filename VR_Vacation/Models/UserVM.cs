using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VR_Vacation.Models
{
    public class UserVm
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "You can only enter 20 characters")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "You can only enter 50 characters")]
        public string Password { get; set; }
        [Required]
        [Display(Name="First name")]
        [StringLength(50, ErrorMessage = "You can only enter 50 characters")]
        public string Firstname { get; set; }
        [Required]
        [Display(Name="Last name")]
        [StringLength(50, ErrorMessage = "You can only enter 50 characters")]
        public string Lastname { get; set; }
        [Required]
        [Display(Name= "Email address")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        [Phone(ErrorMessage = "Enter a valid phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "You can only enter 50 characters")]
        public string Address { get; set; }

        public virtual List<OrderVm> Orders { get; set; }
    }
}