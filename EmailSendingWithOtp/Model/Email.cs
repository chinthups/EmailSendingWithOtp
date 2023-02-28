using System.ComponentModel.DataAnnotations;

namespace EmailSendingWithOtp.Model
{
    public class Email
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Otp { get; set; }
    }
}
