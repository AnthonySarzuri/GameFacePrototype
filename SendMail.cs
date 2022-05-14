using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFacePrototype
{
    class SendMail
    {
        public int Send(string recieve, string emisor, string pass)
        {
            Random r = new Random();
            int code = r.Next(1000, 10000);
            MailMessage msg = new MailMessage();
            msg.To.Add(recieve);
            msg.Subject = "Correo de verificación";
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = "Su codigo de verificacion es: " + code + " gracias por usar GameFace ;)";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress(emisor);
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential(emisor, pass);
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            try
            {
                client.Send(msg);
            }
            catch
            {
                MessageBox.Show("No se pudo enviar el correo");
                code = 0;
            }


            return code;
        }
    }
}
