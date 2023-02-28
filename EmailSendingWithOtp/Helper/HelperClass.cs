using System.Net.Mail;

namespace EmailSendingWithOtp.Helper
{
    public class HelperClass
    {
        public int GetOtp(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string SendMail(string email, string Otp)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("saranyasasi841@gmail.com");
                mail.To.Add(email);
                mail.Priority = MailPriority.High;
                mail.Subject = "Test Email";
                mail.Body = Otp;
                SmtpServer.Port = 587;
                Console.WriteLine($"your otp is generated check you mail");
                //Console.ReadKey();
                SmtpServer.Credentials = new System.Net.NetworkCredential("saranyasasi841@gmail.com", "hwyzliqmtdsrgcvu");
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("Email Send Succesfully");
            return "";
        }
    }
}
