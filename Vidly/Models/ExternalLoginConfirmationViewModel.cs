﻿using System.ComponentModel.DataAnnotations;

namespace Vidly.Models {
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        public string Phone { get; set; }
    }
}