using System.ComponentModel.DataAnnotations;

namespace AS3.Models
{
    public class SignupViewModel
    {
        [Required(ErrorMessage ="Please enter your email")]
        [EmailAddress(ErrorMessage ="Invalid Email Address!")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter your password")]
        public string Password { get; set; }
    }
}
