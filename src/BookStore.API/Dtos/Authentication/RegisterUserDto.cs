﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Dtos.Authentication
{
    public class RegisterUserDto
    {
        [Required(ErrorMessage = "The field {0} is required")]
        [EmailAddress(ErrorMessage = "The field {0} is invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100, ErrorMessage = "The field{0} must have between {2} and {1} characters", MinimumLength = 6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not matches")]
        public string ConfirmPassword { get; set; }
    }
}