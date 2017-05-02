using System;
using System.IO;
using System.Net;
using System.Text;

namespace View {
    public partial class FrmPostParaAldo : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(!IsPostBack) {
                lblStatus.Text = "Status da requisição: aguardando...";
            }
        }



        private void PostParaAldo(string vUrl) {

            try {

                // Create a request using a URL that can receive a post. 
                WebRequest request = WebRequest.Create(vUrl);
                // Set the Method property of the request to POST.
                request.Method = "POST";
                // Create POST data and convert it to a byte array.
                string postData = "";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                // Set the ContentType property of the WebRequest.
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;
                // Get the request stream.
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();


                //// Obtem a resposta da requisição.            
                WebResponse response = request.GetResponse();

                lblStatus.Text = "Status da requisição: " + ((HttpWebResponse)response).StatusDescription;
                //   Response.Write(((HttpWebResponse)response).StatusDescription);

                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();


                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.


                txtXML.Text = responseFromServer;
                //Response.Write(responseFromServer);



                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();

            } catch(Exception ex) {
                txtXML.Text = ex.Message;
            }
        }

        protected void btnProcessar_Click(object sender, EventArgs e) {
            lblWait.Text = "Processando...";
            PostParaAldo("http://www.aldo.com.br/asp.net/ferramentas/integracao.ashx?u=127264&p=j0s3c4");
            lblWait.Text = "Requisição Completa!";
        }

    }
}