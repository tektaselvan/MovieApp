using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services
{
    public class EmailService
    {

        private readonly string _host;
        private readonly int _port;
        private readonly string _user;
        private readonly string _pass;
        private readonly string _from;

        public EmailService(string host, int port, string user, string pass)
        {
            _host = host;
            _port = port;
            _user = user;
            _pass = pass;
            _from = user;
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            using (var client = new SmtpClient(_host, _port))
            {
                client.EnableSsl = true; // STARTTLS
                client.Credentials = new NetworkCredential(_user, _pass);

                var mail = new MailMessage(_from, to, subject, body);
                mail.IsBodyHtml = true;

                await client.SendMailAsync(mail);
            }
        }
    }

}

