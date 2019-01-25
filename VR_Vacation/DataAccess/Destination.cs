﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VR_Vacation.DataAccess
{
    public class Destination
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImagePath { get; set; }

        public virtual ICollection<Package> Packages { get; set; }
    }
}