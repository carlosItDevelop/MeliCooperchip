using System;
using System.EnterpriseServices;
using SDK;
using View.resources;

namespace View {
    public partial class Recursos : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e) {
            


            // --------------------------------------------------------- //
            // PRODUÇÃO em SmarterAsp.net - http://tools.apimltools.com.br/
            // --------------------------------------------------------- //

            if(!IsPostBack) {

                Meli m = new Meli(Constants.AppId, Constants.SecretKey);
                if(string.IsNullOrEmpty(Request["code"])) {

                    // Pega a url de autorização - Deve-se passar a url registrada em sua aplicação.
                    var vUrl = m.GetAuthUrl("http://"+ Constants.Host + "/recursos.aspx");

                    Response.Redirect(vUrl);
                }

                string code = Request["code"];
                // Com o code de autorização chamar o método Autorize com o code e a url da sua aplicação;
                m.Authorize(code, "http://"+ Constants.Host + "/recursos.aspx");
                //m.Authorize(code, "http://"+ Constants.Host + "/frmAnunciosPorCategoria.aspx");

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
            Response.Redirect("http://"+ Constants.Host + "/" + DDLSimulaNotificacoes.Text + ".aspx?code=" + Session["code"]);
        }

        private void GetApi(string btnN) {
            Meli m = new Meli(Constants.AppId, Constants.SecretKey);
            if(string.IsNullOrEmpty(Request["code"])) {

                // Pega a url de autorização - Deve-se passar a url registrada em sua aplicação.
                var vUrl = m.GetAuthUrl("http://"+ Constants.Host + "/recursos.aspx");


                Response.Redirect(vUrl);
            } else {
                //------------------------------//
                //string code = WebRequestPostAuth(vUrl);
                //------------------------------//

                string code = Request["code"];
                // Com o code de autorização chamar o método Autorize com o code e a url da sua aplicação;
                m.Authorize(code, "http://"+ Constants.Host + "/recursos.aspx");
                //m.Authorize(code, "http://"+ Constants.Host + "/frmAnunciosPorCategoria.aspx");

                Session["aToken"] = m.AccessToken;
                Session["rToken"] = m.RefreshToken;
                Session["code"] = code;

                // lblAccessToken.Text = Session["aToken"].ToString();

                if(btnN.Equals("btn1")) { Response.Redirect("http://"+ Constants.Host + "/" + cboDestino.Text + ".aspx?code=" + Session["code"]); }
                if(btnN.Equals("btn2")) { Response.Redirect("http://"+ Constants.Host + "/" + cboDestino2.Text + ".aspx?code=" + Session["code"]); }
                if(btnN.Equals("btn3")) { Response.Redirect("http://"+ Constants.Host + "/" + cboDestino3.Text + ".aspx?code=" + Session["code"]); }
                if(btnN.Equals("btn4")) { Response.Redirect("http://"+ Constants.Host + "/" + cboDestino4.Text + ".aspx?code=" + Session["code"]); }
                
            }
        }



        protected void btnChamaPostApi_Click(object sender, EventArgs e) {
            Meli m = new Meli(Constants.AppId, Constants.SecretKey);

            if(string.IsNullOrEmpty(Request["code"])) {

                // Pega a url de autorização - Deve-se passar a url registrada em sua aplicação.
                var vUrl = m.GetAuthUrl("http://"+ Constants.Host + "/recursos.aspx");

                Response.Redirect(vUrl);
            } else {

                string code = Request["code"];
                // Com o code de autorização chamar o método Autorize com o code e a url da sua aplicação;
                m.Authorize(code, "http://"+ Constants.Host + "/recursos.aspx");

                Session["aToken"] = m.AccessToken;
                Session["rToken"] = m.RefreshToken;
                Session["code"] = code;

                Response.Redirect("http://"+ Constants.Host + "/" + cboPosts.Text + ".aspx?code=" + Session["code"]);
            }
        }


        protected void btnEstatistica_Click(object sender, EventArgs e) {
            Response.Redirect("http://"+ Constants.Host + "/" + cboDbRelats.Text + ".aspx?code=" + Session["code"]);
        }

    }
}