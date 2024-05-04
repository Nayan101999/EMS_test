using System.ComponentModel.DataAnnotations;

namespace EMS_test.Models
{
    public class ForgotPasswordVM
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
