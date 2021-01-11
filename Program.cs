using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TesteEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email Spammer");

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("awayshrimp2605@gmail.com", "Pietro2001");

            MailMessage mm = new MailMessage("pietro.roque@auvo.com", "raquel.carneiro@auvo.com.br", "Parabéns pela admissão!", "Muito sucesso!");
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Mensagem enviada");
                client.Send(mm);

            }
        }
    }
}
