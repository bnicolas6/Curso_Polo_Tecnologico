using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using Curso.Common;


namespace Curso.Business
{
    public static class EmailSending{

        public static bool send(string email, string password) {

            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            MailMessage mmsg = new MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(email);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Asunto del correo";
            mmsg.SubjectEncoding = Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            // mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = "Su contraseña actual es: " + password;
            mmsg.BodyEncoding = Encoding.UTF8;
            mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new MailAddress("curso.passrecovery@gmail.com");


            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            SmtpClient client = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            client.Credentials = new NetworkCredential("curso.passrecovery@gmail.com", "email#179@correo");

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail

            client.Port = 587;
            client.EnableSsl = true;


            //cliente.Host = "mail.servidordominio.com"; //Para Gmail "smtp.gmail.com";
            client.Host = "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try{
                //Enviamos el mensaje      
                client.Send(mmsg);
                return true;
            }
            catch (SmtpException ex){
                
                //Console.WriteLine("Error: " + ex);
                //Aquí gestionamos los errores al intentar enviar el correo
                return false;
            }
            
        }
    }
}
