




namespace WebApplication13.BL.services
{
    public class sender : Mailsender
    {
        public bool sendmail(string recieveremail, string body)
        {
            try
            {
                var email = new MimeMessage()
                {
                    Sender = MailboxAddress.Parse("atiffahmykhamis@gmail.com"),
                    Subject = "message from College system"


                };
                email.To.Add(MailboxAddress.Parse(recieveremail));
                var builder = new BodyBuilder();


                builder.HtmlBody = body;
                email.Body = builder.ToMessageBody();


                email.From.Add(new MailboxAddress("College system ", "atiffahmykhamis@gmail.com"));



                using (var smtp = new SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, false);
                    smtp.Authenticate("atiffahmykhamis@gmail.com", "carncxaexqpzebqa");
                     smtp.SendAsync(email);
                    smtp.Disconnect(true);
                }
                return true;
            }catch(Exception ex)
            {
                return false;
            }

            }
    }
}
