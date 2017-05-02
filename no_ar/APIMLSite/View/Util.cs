using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace SimpleMembershipLocalDatabase
{
    public class Util
    {
        public static void Alertar(string mensagem)
        {
            HttpContext.Current.Session["alert"] = mensagem;
        }

        public static void EnviarEmail(string assunto, string mensagem, string destinatario)
        {
            var smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            var msg = new MailMessage("contato.eshopss@gmail.com", destinatario, assunto, mensagem);
            msg.IsBodyHtml = true;
            var cred = new NetworkCredential("contato.eshopss@gmail.com", "ab04ime768403");
            smtp.Credentials = cred;
            smtp.Send(msg);
        }

        public static string GerarSenhaAleatoria(int tamanho)
        {
            string caracteresPermitidos = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-*&#+";
            char[] senhaGerada = new char[tamanho];
            Random rd = new Random();
            for (int i = 0; i < tamanho; i++)
            {
                senhaGerada[i] = caracteresPermitidos[rd.Next(0, caracteresPermitidos.Length)];
            }
            return new string(senhaGerada);
        }
    }
}