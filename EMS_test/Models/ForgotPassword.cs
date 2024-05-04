using System.ComponentModel.DataAnnotations;

namespace EMS_test.Models
{
    public class ForgotPassword
    {
        [Key]
        public int ID { get; set; }
        public string? TempOtp { get; set; }
        public string? TempMail { get; set; }
    }
}
