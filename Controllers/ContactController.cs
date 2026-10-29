using Jogisafetech.Models;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Formatting;
using System.Net.Mail;

namespace Jogisafetech.Controllers
{
    public class ContactController : Controller
    {
        public void AddContact(string name)
        {
            string body = "hello";

            SendHtmlFormattedEmail("mail@mitsolutions.in", "Your question sent", body);

        }

        private void SendHtmlFormattedEmail(string recepientEmail, string subject, string body)
        {
            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress("mail@mitsolutions.in");
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;
                    mailMessage.IsBodyHtml = true;
                    mailMessage.To.Add(new MailAddress(recepientEmail));

                    System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                    NetworkCred.UserName = "mail@mitsolutions.in";
                    NetworkCred.Password = "mAiL#M@20!?";

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "webmail.mitsolutions.in";
                    smtp.EnableSsl = Convert.ToBoolean(false);
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = NetworkCred;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Port = 587;

                    smtp.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
