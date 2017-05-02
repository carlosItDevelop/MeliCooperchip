using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace View {
    public partial class SetPostForRecebeNotificacoes : System.Web.UI.Page {
        
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
            // Executa um ou o outro!

//            HttpPost(vServer+"/frmNotificacoes.aspx", new[] {"resource","user_id","topic", "application_id", "attempts", "sent", "received"}, new []{"//orders//785057528","59181149","orders", "7588853413686044", "9", "2013-08-25", "2013-08-25"});

            WebRequestPostExample();


        }



        void WebRequestPostExample() {
            // Criar uma solicitação usando uma URL que pode receber um post.
            WebRequest request = WebRequest.Create("frmNotificacoes.aspx");
            // Defina a propriedade Method do pedido para POST.
            request.Method = "POST";
            // Criar dados POST e convertê-lo em um array de bytes.
            string postData = "{'resource':'/orders/785057528','user_id':'59181149','topic':'orders', 'application_id':7588853413686044, 'attempts':2, 'sent':'2013-08-25', 'received':'2013-08-25'}";
      //      string postData = "Este é um teste que esta seqüência de mensagens levará para um servidor web.  -  ORIGEM: " + Request.UrlReferrer;
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
            response.Close();
        }

        static string HttpPost(string url,
            string[] paramName, string[] paramVal) {
            HttpWebRequest req = WebRequest.Create(new Uri(url))
                                 as HttpWebRequest;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            // Construir uma string com todos os parâmetros, devidamente codificados.
            // Certifique-se que os Arrays paramName e paramVal são
            // Tem o mesmo comprimento:
            StringBuilder paramz = new StringBuilder();
            for(int i = 0; i < paramName.Length; i++) {
                paramz.Append(paramName[i]);
                paramz.Append("=");
                paramz.Append(HttpUtility.UrlEncode(paramVal[i]));
                paramz.Append("&");
            }

            // Encode the parameters as form data:
            byte[] formData =
            UTF8Encoding.UTF8.GetBytes(paramz.ToString());
            req.ContentLength = formData.Length;

            // Send the request:
            using(Stream post = req.GetRequestStream()) {
                post.Write(formData, 0, formData.Length);
            }

            // Pick up the response:
            string result = null;
            using(HttpWebResponse resp = req.GetResponse()
                                          as HttpWebResponse) {
                StreamReader reader =
                new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }

            return result;
        }
    }
}