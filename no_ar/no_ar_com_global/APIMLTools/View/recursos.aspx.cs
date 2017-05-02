using System;
using SDK;

namespace View {
    public partial class Recursos : System.Web.UI.Page {
        
        
        
        protected void Page_Load(object sender, EventArgs e) {
            


            // --------------------------------------------------------- //
            // PRODUÇÃO em SmarterAsp.net - http://tools.apimltools.com.br/
            // --------------------------------------------------------- //

            if(!IsPostBack) {

                Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString());
                if(string.IsNullOrEmpty(Request["code"])) {

                    // Pega a url de autorização - Deve-se passar a url registrada em sua aplicação.
                    var vUrl = m.GetAuthUrl("http://"+Application["HOST"] + "/recursos.aspx");

                    Response.Redirect(vUrl);
                }

                string code = Request["code"];

                m.Authorize(code, "http://"+Application["HOST"] + "/recursos.aspx");


                Session["aToken"] = m.AccessToken;
                Session["rToken"] = m.RefreshToken;
                Session["code"] = code;

            }

        }



        protected void btnChamaGetApi_Click(object sender, EventArgs e) {
            GetApi("btn1");
        }

        protected void btnChamaGetApi2_Click(object sender, EventArgs e) {
            GetApi("btn2");
        }

        protected void btnChamaGetApi3_Click(object sender, EventArgs e) {
            GetApi("btn3");
        }

        protected void btnChamaGetApi4_Click(object sender, EventArgs e) {
            GetApi("btn4");
        }

        protected void btnSimulaNotify_Click(object sender, EventArgs e) {
            Response.Redirect("http://"+Application["HOST"] + "/" + DDLSimulaNotificacoes.Text + ".aspx?code=" + Session["code"]);
        }

        private void GetApi(string btnN) {
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString());
            if(string.IsNullOrEmpty(Request["code"])) {

                // Pega a url de autorização - Deve-se passar a url registrada em sua aplicação.
                var vUrl = m.GetAuthUrl("http://"+Application["HOST"] + "/recursos.aspx");


                Response.Redirect(vUrl);
            } else {
                //------------------------------//
                //string code = WebRequestPostAuth(vUrl);
                //------------------------------//

                string code = Request["code"];
                m.Authorize(code, "http://"+Application["HOST"] + "/recursos.aspx");
                Session["aToken"] = m.AccessToken;
                Session["rToken"] = m.RefreshToken;
                Session["code"] = code;


                if(btnN.Equals("btn1")) { Response.Redirect("http://"+Application["HOST"] + "/" + cboDestino.Text + ".aspx?code=" + Session["code"]); }
                if(btnN.Equals("btn2")) { Response.Redirect("http://"+Application["HOST"] + "/" + cboDestino2.Text + ".aspx?code=" + Session["code"]); }
                if(btnN.Equals("btn3")) { Response.Redirect("http://"+Application["HOST"] + "/" + cboDestino3.Text + ".aspx?code=" + Session["code"]); }
                if(btnN.Equals("btn4")) { Response.Redirect("http://"+Application["HOST"] + "/" + cboDestino4.Text + ".aspx?code=" + Session["code"]); }
                
            }
        }



        protected void btnChamaPostApi_Click(object sender, EventArgs e) {
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString());

            if(string.IsNullOrEmpty(Request["code"])) {

                var vUrl = m.GetAuthUrl("http://"+Application["HOST"] + "/recursos.aspx");

                Response.Redirect(vUrl);
            } else {

                string code = Request["code"];

                m.Authorize(code, "http://"+Application["HOST"] + "/recursos.aspx");

                Session["aToken"] = m.AccessToken;
                Session["rToken"] = m.RefreshToken;
                Session["code"] = code;

                Response.Redirect("http://"+Application["HOST"] + "/" + cboPosts.Text + ".aspx?code=" + Session["code"]);
            }
        }


        protected void btnEstatistica_Click(object sender, EventArgs e) {
            Response.Redirect("http://"+Application["HOST"] + "/" + cboDbRelats.Text + ".aspx?code=" + Session["code"]);
        }

    }
}