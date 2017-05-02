using System;
using System.IO;
using System.Net;

namespace View {
    public partial class FrmNotificaMp : System.Web.UI.Page {
        

        protected void Page_Load(object sender, EventArgs e) {

            
        }

        void Page_LoadComplete(object sender, EventArgs e) {

            

            string topic = Request["topic"];
            string id = Request["id"];

            //NotificacoesMP notify_mp = new NotificacoesMP();
            //notify_mp.topic = topic;
            //notify_mp.id = id;            

            string vCaminho = (Request.ServerVariables["HTTP_HOST"].Equals("localhost") ? @"D:\Desenv\MeLi\APIMLDesenv\tools\View\notify\callback.csv" : @"h:\root\home\cooperchip-001\www\site3\tools\notify\callbackmp.csv");



            // Grava em arquivo texto o JSON;
            StreamWriter wr = new StreamWriter(vCaminho, true);
            wr.WriteLine(topic + "-" + id);
            wr.Close();


            Response.StatusCode = (int)HttpStatusCode.OK;

        }



    }
}