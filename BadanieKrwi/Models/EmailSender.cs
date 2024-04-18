using System.Net;
using System.Net.Mail;

namespace BadanieKrwi.Models
{
    public class EmailSender
    {
        private string _smtpServer;
        private int _smtpPort;
        private string _senderEmail;
        private string _senderPassword;

        public EmailSender(string smtpServer, int smtpPort, string senderEmail, string senderPassword)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _senderEmail = senderEmail;
            _senderPassword = senderPassword;
        }

        public void SendEmail(string recipientEmail, string subject, string body)
        {
            using (SmtpClient client = new SmtpClient(_smtpServer, _smtpPort))
            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(_senderEmail, _senderPassword);
                client.EnableSsl = true;

                MailMessage msg = new MailMessage(_senderEmail, recipientEmail, subject, body);
                msg.IsBodyHtml = true;
                client.Send(msg);
            }
        }
    }
}