using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using MailKit.Net.Smtp;

using System.Text;
using System.Threading.Tasks;
using WebApplication13;




namespace WebApplication13.BL.services
{
    public class sender : Mailsender
    {
        public async Task sendmail(string mailfrom, string body)
        {
            var email = new MimeMessage()
            {
                Sender = MailboxAddress.Parse("atiffahmykhamis@gmail.com"),
                Subject = "message from College system from "+ mailfrom


            };
            email.To.Add(MailboxAddress.Parse("mostafaatif824@gmail.com"));
            var builder = new BodyBuilder();


            builder.HtmlBody = body;
            email.Body = builder.ToMessageBody();
           

            email.From.Add(new MailboxAddress("College system ", "atiffahmykhamis@gmail.com"));


            
                using (var smtp = new SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, false);
                    smtp.Authenticate("atiffahmykhamis@gmail.com", "carncxaexqpzebqa");
                   await smtp.SendAsync(email);
                smtp.Disconnect(true);
                }
            

            }
    }
}
