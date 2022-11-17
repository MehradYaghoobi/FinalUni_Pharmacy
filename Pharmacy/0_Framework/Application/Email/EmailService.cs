using MimeKit;
using MailKit.Net.Smtp;


namespace _0_Framework.Application.Email
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string title, string messageBody, string destination)
        {
            var message = new MimeMessage();

            var from = new MailboxAddress("PharmacyShop", "EmailSite");
            message.From.Add(from);

            var to = new MailboxAddress("User", destination);
            message.To.Add(to);

            message.Subject = title;
            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = $"<h1>{messageBody}</h1>",
            };

            message.Body = bodyBuilder.ToMessageBody();

            var client = new SmtpClient();

            client.Connect("ip.site",  /* port */25, false);
            client.Authenticate("username email", "password email");
            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
        }
    }
}