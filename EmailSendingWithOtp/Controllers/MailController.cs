using EmailSendingWithOtp.Data;
using EmailSendingWithOtp.Helper;
using EmailSendingWithOtp.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmailSendingWithOtp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        [HttpPost("Register")]
        public string Register(User newUser)
        {
            DemoDbContext demoDbContext = new DemoDbContext();
            HelperClass hp=new HelperClass();
            string otp=hp.GetOtp(1000,9000).ToString();
            newUser.Otp = otp;
            demoDbContext.Users.Add(newUser);
            demoDbContext.SaveChanges();
            hp.SendMail(newUser.Email, otp);
            return "please check email for otp";
           
         }
        [HttpPost("Login")]
        public string Login( string email,string password,string otp)
        {
            DemoDbContext demoDbContext=new DemoDbContext();
            User? user = demoDbContext.Users.Where(x => x.Email == email&&x.Otp==otp&&x.Password==password).FirstOrDefault();
            if (user is null)
            {
                return "invalid";
            }
            return "success";

        }
    }
}
