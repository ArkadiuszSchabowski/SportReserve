using SportReserve_Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace SportReserve_Shared.Models.User
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(5, ErrorMessage = "Password must be between 5 and 25 characters.")]
        [MaxLength(25, ErrorMessage = "Password must be between 5 and 25 characters.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Repeat password is required.")]
        [MinLength(5, ErrorMessage = "Repeat password must be between 5 and 25 characters.")]
        [MaxLength(25, ErrorMessage = "Repeat password must be between 5 and 25 characters.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string RepeatPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "User name is required.")]
        [MinLength(3, ErrorMessage = "User name must be between 3 and 25 characters.")]
        [MaxLength(25, ErrorMessage = "User name must be between 3 and 25 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "User surname is required.")]
        [MinLength(3, ErrorMessage = "User surname must be between 3 and 25 characters.")]
        [MaxLength(25, ErrorMessage = "User surname must be between 3 and 25 characters.")]
        public string Surname { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must choose a gender.")]
        public Gender? Gender { get; set; }
        [Required(ErrorMessage = "Date of birth is required.")]
        public DateOnly DateOfBirth { get; set; }
    }
}
