using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Toplearn.Core.Senders
{
   public  class SendEmail
    {
        public static void Send(string to, string subject, string body)
        {
            using (MailMessage mail = new MailMessage())
            {
                using (SmtpClient smtpServer = new SmtpClient("smtp.gmail.com"))
                {
                    // Sender information
                    mail.From = new MailAddress("prozheali@gmail.com", "تاپ لرن");
                    mail.To.Add(to);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    // SMTP server settings
                    smtpServer.Port = 587;
                    smtpServer.UseDefaultCredentials = false;  // Set this before assigning Credentials
                    smtpServer.Credentials = new System.Net.NetworkCredential("prozheali@gmail.com", "wafsqqihjfyyulge");
                    smtpServer.EnableSsl = true;

                    // Send the email
                    smtpServer.Send(mail);
                }
            }
        }

    }
}
