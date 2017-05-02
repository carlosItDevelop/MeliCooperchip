using System;
using System.IO;
using System.Net;
using System.Text;

namespace View {
    public partial class SetPostForRecebeNotificacoesMp : System.Web.UI.Page {
        
        protected void Page_Load(object sender, EventArgs e) {
            

            if(IsPostBack) {
                if(Request.RequestContext != null) {
                    Response.Write(Response.StatusCode);
                    Response.Write("<hr />");
                    Response.Write(Request.UrlReferrer);
                }
            }
        }



        protected void btnEnviar_Click(object sender, EventArgs e) {
            WebRequestPostExample("payment", "12345678");
        }

        void WebRequestPostExample(string vTopic, string vId) {
            // Criar uma solicitação usando uma URL que pode receber um post.
            WebRequest request = WebRequest.Create("frmNotificaMP.aspx?topic="+ vTopic +"&id="+ vId);
            // Defina a propriedade Method do pedido para POST.
            request.Method = "POST";
            // Criar dados POST e convertê-lo em um array de bytes.
            string postData = ""; ;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Defina a propriedade ContentType da WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            // Obter o fluxo de solicitação.
            Stream dataStream = request.GetRequestStream();
            // Escrever os dados para o fluxo de pedido.
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            // Obter a resposta.
            WebResponse response = request.GetResponse();
            // Exibir o status.
            Response.Write(((HttpWebResponse)response).StatusDescription);
            // Obter o fluxo contendo conteúdo retornado pelo servidor.
            dataStream = response.GetResponseStream();
            // Abra o fluxo através de um leitor de fluxo para facilitar o acesso.
            StreamReader reader = new StreamReader(dataStream);
            // Ler o Conteúdo.
            string responseFromServer = reader.ReadToEnd();
            // Exibir o conteúdo.
            Response.Write(responseFromServer);
            // Limpar os fluxos.
            reader.Dispose();
            dataStream.Dispose();
            reader.Close();
            dataStream.Close();
            response.Close();
        }

    }
}