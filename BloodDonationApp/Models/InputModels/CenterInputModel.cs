﻿namespace BloodDonationApp.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;

    public class CenterInputModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Town { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^([0-9]{10})|(\+359[0-9]{9})$")]
        [StringLength(10, ErrorMessage = "Phone Number length must be exact 10 symbols!", MinimumLength = 10)]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}