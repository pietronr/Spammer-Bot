using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.IO;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace TesteEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email Spammer");

            String filePath = "mantis_casado.jpeg";
            Attachment data = new Attachment(filePath, MediaTypeNames.Application.Octet);

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("awayshrimp2605@gmail.com", "Pietro2001");

            MailMessage mm = new MailMessage("pietro.roque@auvo.com", "spiderpig2016@gmail.com", "Fala", "naaaaaaao stoneeee");
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            mm.Attachments.Add(data);


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Mensagem enviada");
                client.Send(mm);

            }
        }
    }
}
