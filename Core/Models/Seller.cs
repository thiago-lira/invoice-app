﻿using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Seller : ModelBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Address Address { get; set; }
    }
}
