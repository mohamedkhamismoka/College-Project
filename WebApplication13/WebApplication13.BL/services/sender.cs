using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WebApplication13;


namespace WebApplication13.BL.services
{
    public class sender : Mailsender
    { 
        public void sendmail(string mailfrom,string mailto,string pass, string title, string body)
        {
            var email = new MimeMessage
            {
                Sender = MailboxAddress.Parse(mailfrom),
                Subject = title

            };
            email.To.Add(MailboxAddress.Parse(mailto));
            var builder = new BodyBuilder();
            builder.HtmlBody = body;
            email.Body = builder.ToMessageBody();
            email.From.Add(new MailboxAddress("Pioneers School",mailfrom));
            var smtp = new SmtpClient();
            smtp.Host= "smtp-mail.outlook.com";
            smtp.Port=587;
            smtp.EnableSsl = true;
            smtp.Credentials=new NetworkCredential(mailfrom,pass);
            smtp.Send(mailfrom, mailto,title,body) ;
            smtp.Dispose();

        }
    }
}
