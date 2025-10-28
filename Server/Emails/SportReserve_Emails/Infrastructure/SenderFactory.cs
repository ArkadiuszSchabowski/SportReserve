using FluentEmail.Core;
using FluentEmail.Smtp;
using SportReserve_Emails.Interfaces;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace SportReserve_Emails.Infrastructure
{
    public class SenderFactory : ISenderFactory
    {
        private readonly IEmailAuthentication _emailAuthentication;

        public SenderFactory(IEmailAuthentication emailAuthentication)
        {
            _emailAuthentication = emailAuthentication;
        }
        public void CreateSender()
        {
            ServicePointManager.ServerCertificateValidationCallback =
    delegate (object s, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors)
    {
        return true;
    };

            var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587,
                Credentials = new NetworkCredential(_emailAuthentication.Email, _emailAuthentication.AppPassword)
            });

            Email.DefaultSender = sender;
        }
    }
}
