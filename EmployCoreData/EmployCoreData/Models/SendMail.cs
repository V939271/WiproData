using System.Net;
using System.Net.Mail;

namespace EmployCoreData.Models
{
    public class SendMail
    {
        public static string MailInfo(string toEmail, string subject, string body)
        {
            try
            {
                using (MailMessage message = new MailMessage())
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    string fromAddress = "prasanna.vsp80@gmail.com"; // must match credentials
                    string appPassword = "soqdhechjkcchkgl"; // your Gmail App Password

                    message.From = new MailAddress(fromAddress);
                    message.To.Add(new MailAddress(toEmail));
                    message.Subject = subject;
                    message.IsBodyHtml = true;
                    message.Body = body;

                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(fromAddress, appPassword);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    smtp.Send(message);
                }
                return "success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
