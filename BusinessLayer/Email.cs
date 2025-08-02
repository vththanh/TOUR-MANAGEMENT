using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class Email
    {
        public static void SendVerificationCode(string toEmail, string code)
        {
            var fromEmail = "tourmanagement448@gmail.com";
            var password = "llxq odvj nvxu pzcc";

            var smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, password),
                EnableSsl=true
            };
            var message = new MailMessage(fromEmail, toEmail, "Mã xác thực", $"Mã xác thực của bạn là: {code}");
            smtp.Send(message);
        }
    }
}
