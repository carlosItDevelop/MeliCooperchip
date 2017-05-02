using System;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using Model;
using Models;

namespace View {
    public partial class FrmNotificacoes : System.Web.UI.Page {
        
        

        protected void Page_Load(object sender, EventArgs e) {

            
        }

        void Page_LoadComplete(object sender, EventArgs e) {

            

            var reader = new StreamReader(Request.InputStream);
            string inputString = reader.ReadToEnd();

            ReadJson(inputString);

            string vCaminho = (Request.ServerVariables["HTTP_HOST"].Equals("localhost") ? @"D:\Desenv\MeLi\APIMLDesenv\tools\View\notify\callback.csv" : @"h:\root\home\cooperchip-001\www\site3\tools\notify\callback.csv");

            // Grava em arquivo texto o JSON;
            StreamWriter wr = new StreamWriter(vCaminho, true);
            wr.WriteLine(inputString);
            wr.Close();


            Response.StatusCode = (int)HttpStatusCode.OK;

        }



        /// <summary>
        /// Lê o JSON e popula o Objeto Notificacao
        /// Com as seguintes propriedades:
        /// user_id, resource, topic, received, sent, application_id, attempts
        /// </summary>
        /// <param name="jsonInput">Objeto JSON como String</param>
        public void ReadJson(string jsonInput) {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            Notificacao notify = jsonSerializer.Deserialize<Notificacao>(jsonInput);
        }

    }
}