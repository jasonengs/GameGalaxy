using System.ComponentModel.DataAnnotations;

namespace GameGalaxy.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a email.")]
        [StringLength(255)]
        public string Email{ get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(255)]
        public string Password { get; set; } = string.Empty;

        public string ReturnUrl { get; set; } = string.Empty;

        public bool RememberMe { get; set; }

    }
}
