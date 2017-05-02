using System;
using System.IO;
using System.Net;
using System.Text;


namespace Models
{
    class SendPost
    {
        public SendPost(string vServer, string vPage)
        {
            try
            {                
                ASCIIEncoding asciiencoding = new ASCIIEncoding();
                string postData = "";
                Byte[] data = asciiencoding.GetBytes(postData);

                WebRequest request = WebRequest.Create(vPage);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                //WebResponse response = request.GetResponse();
                //stream = response.GetResponseStream();

                //StreamReader sr = new StreamReader(stream);
                //Response.Write(sr.ReadToEnd());

                //sr.Close();
             

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
