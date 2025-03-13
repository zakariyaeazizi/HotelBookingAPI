﻿using System.ComponentModel.DataAnnotations;

namespace HotelBookingAPI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
    }
}
