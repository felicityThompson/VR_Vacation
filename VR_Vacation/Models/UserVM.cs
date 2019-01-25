using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VR_Vacation.Models
{
    public class UserVm
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name="First name")]
        [StringLength(50, ErrorMessage = "You can only enter 50 characters")]
        public string Firstname { get; set; }
        [Required]
        [Display(Name="Last name")]
        public string Lastname { get; set; }
        [Required]
        [Display(Name= "Email address")]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }

        public virtual List<OrderVm> Orders { get; set; }
    }
}