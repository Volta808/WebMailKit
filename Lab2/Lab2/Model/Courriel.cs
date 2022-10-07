using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using System.ComponentModel.DataAnnotations;
using MailKit.Net.Smtp;

namespace Lab2.Model.Courriel
{
    public class Courriel
    {
        public static string fromMail { get; set; }
        public static string password { get; set; }

        public static string toMail { get; set; }
        public static string subject { get; set; }

        public static string message { get; set; }

        public static void envoyer() {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(fromMail));
            email.To.Add(MailboxAddress.Parse(toMail));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Plain){ Text = message };

            using var smtp = new SmtpClient();
            smtp.CheckCertificateRevocation = false;
            smtp.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(fromMail, password);
            smtp.Send(email);
            smtp.Disconnect(true);
            

        }

    }
}
