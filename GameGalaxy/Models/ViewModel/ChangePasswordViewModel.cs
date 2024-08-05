﻿using System.ComponentModel.DataAnnotations;

namespace GameGalaxy.Models
{
    public class ChangePasswordViewModel
    {
        public string Email{ get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your password.")]
        public string OldPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your new password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string NewPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your new password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
