using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Toplearn.Core.Senders
{
    public class SendMail
    {
        public static void SendAsync(string to, string subject, string body)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("prozheali@gmail.com", "تاپ لرن");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                using (SmtpClient smtpServer = new SmtpClient("smtp.gmail.com"))
                {
                    smtpServer.UseDefaultCredentials = false;
                    smtpServer.Port = 587;
                    smtpServer.Credentials = new NetworkCredential("prozheali@gmail.com", "ayszpqnyevqvbujn");
                    smtpServer.EnableSsl = true;
                    try
                    {
                        smtpServer.SendMailAsync(mail);
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
    }
}
