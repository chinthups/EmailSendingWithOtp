using System.ComponentModel.DataAnnotations;

namespace EmailSendingWithOtp.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string Password { get; set; }
        public string? Otp { get; set; }
        public string Email { get; set; }

    }
}
