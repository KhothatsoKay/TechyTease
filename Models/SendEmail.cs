using MailKit.Net.Smtp;
using MimeKit;

namespace Blog.Models
{
    public class SendEmail
    {
        public void Send(string emailTo, string subject, string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("email"));
            email.To.Add(MailboxAddress.Parse(emailTo));
            email.Subject = subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

            using var smtp = new SmtpClient();

            smtp.Connect("smtp-mail.outlook.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("email", "");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
