using System;
using System.Collections.Generic;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmCriarTestUser : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnEnviar_Click(object sender, EventArgs e) {
            // 1 - Instância da Auth
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());

            var p = new RestSharp.Parameter { Name = "access_token", Value = m.AccessToken };
            var ps = new List<RestSharp.Parameter> { p };

            try {
                IRestResponse uTest = m.Post("/users/test_user", ps, new { site_id = "MLB" });
                lblResultJSON.Text = (uTest.Content);
            } catch(Exception ex) {

                lblResultJSON.Text = ex.Message;
            }
        }// fechamento do btnEnviar_Click;    
    }//  Fechamento da Classe;
}// Fechamento do Namespace;