using Jogisafetech.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Formatting;
using System.Net.Mail;

namespace Jogisafetech.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult contactus()
        {
            return View();
        }

        public IActionResult aboutus()
        {
            return View();
        }

        public IActionResult patrons()
        {
            return View();
        }
        public IActionResult certification()
        {
            return View();
        }

        public IActionResult hazopservice()
        {
            return View();
        }
        public IActionResult hazid()
        {
            return View();
        }
        public IActionResult whatifanalysis()
        {
            return View();
        }

        public IActionResult hac()
        {
            return View();
        }
        public IActionResult industrialhygienesurvey()
        {
            return View();
        }
        public IActionResult chemicalexposure()
        {
            return View();
        }
        public IActionResult noisemonitering()
        {
            return View();
        }
        public IActionResult illumination()
        {
            return View();
        }
        public IActionResult ventilation()
        {
            return View();
        }
        public IActionResult ergonomics()
        {
            return View();
        }

        public IActionResult psmgapanalysis()
        {
            return View();
        }

        public IActionResult psmtraining()
        {
            return View();
        }

        public IActionResult psmimplementation()
        {
            return View();
        }
        public IActionResult eotoperator()
        {
            return View();
        }
        public IActionResult hydraoperator()
        {
            return View();
        }
        public IActionResult forkliftoperation()
        {
            return View();
        }
        public IActionResult riggingoperation()
        {
            return View();
        }

        public IActionResult hira()
        {
            return View();
        }
        public IActionResult qra()
        {
            return View();
        }
        public IActionResult jsa()
        {
            return View();
        }
        public IActionResult firaadeqacysurvey()
        {
            return View();
        }

        public IActionResult firasafetyaudit()
        {
            return View();
        }
        public IActionResult firaloadcalculation()
        {
            return View();
        }
        public IActionResult designofnetwork()
        {
            return View();
        }
        public IActionResult thirdpartysafetyaudit()
        {
            return View();
        }
        public IActionResult processsafetyaudit()
        {
            return View();
        }
        public IActionResult electricalsafetyaudit()
        {
            return View();
        }
        public IActionResult firesafetyaudit()
        {
            return View();
        }

        public IActionResult firesafetyauditfire()
        {
            return View();
        }
        public IActionResult lightningarrestersyvey()
        {
            return View();
        }
        public IActionResult lightningarresterinstallation()
        {
            return View();
        }
        public IActionResult arcflashstudy()
        {
            return View();
        }
        public IActionResult oep()
        {
            return View();
        }
        public IActionResult safetyreport()
        {
            return View();
        }
        public IActionResult erdmp()
        {
            return View();
        }
        public IActionResult testimonials()
        {
            return View();
        }

        public IActionResult customerref()
        {
            return View();
        }
        public IActionResult pha()
        {
            return View();
        }

        public IActionResult psm()
        {
            return View();
        }

        public IActionResult riskassesment()
        {
            return View();
        }

        public IActionResult firesafety()
        {
            return View();
        }
        public IActionResult safetyaudit()
        {
            return View();
        }
        public IActionResult electricalsafety()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void AddContact(FormDataCollection form)
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
