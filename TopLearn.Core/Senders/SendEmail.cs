using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Toplearn.Core.Senders
{
   public  class SendEmail
    {
        public static void Send(string to, string subject,string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("prozheali@gmail.com", "تاپ لرن");
            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            smtpServer.UseDefaultCredentials = true;
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("prozheali@gmail.com", "wafsqqihjfyyulge");
            smtpServer.EnableSsl = true;
            smtpServer.Send(mail);

        }
    }
}
