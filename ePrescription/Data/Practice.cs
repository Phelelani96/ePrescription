﻿using ePrescription.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace ePrescription.Data
{
    public class Practice
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Contact Number")]
        [Phone]
        [StringLength(10, ErrorMessage = "Contact length can't be more than 10.")]
        public string ContactNo { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Practice Number")]
        [StringLength(9, ErrorMessage = "Name length can't be more than 9.")]
        public string PracticeNo { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; } = string.Empty;

        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }

        [Required]
        [Range(1, 100000000, ErrorMessage = "Please select Suburb")]
        public int SuburbID { get; set; }

        public Suburb? Suburb { get; set; }
        public ICollection<User>? Doctor { get; set; }
    }
}
