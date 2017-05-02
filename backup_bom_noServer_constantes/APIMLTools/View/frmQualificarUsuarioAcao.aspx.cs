using System;
using System.Collections.Generic;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmQualificarUsuarioAcao : System.Web.UI.Page {

        string _strRating = "";
        string _strFulfilled = "";
        string _strMessage = "";
        string _strOrderId = "";
        string _strSellerId = "";

        

        protected void Page_Load(object sender, EventArgs e) {
            
            _strOrderId = Request["order_id"];
            _strSellerId = Request["seller_id"];
        }


        protected void btnEnviar_Click(object sender, EventArgs e) {

            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            var p = new RestSharp.Parameter { Name = "access_token", Value = m.AccessToken };
            var ps = new List<RestSharp.Parameter> { p };

            _strMessage = txtComentQualify.Text;
            _strRating = (optQualificacao.SelectedItem.Text == "Positivo" ? "positive" : (optQualificacao.SelectedItem.Text == "Neutro" ? "neutral" : "negative"));
            _strFulfilled = (optConcretizada.SelectedItem.Text == "Sim" ? "true" : "false");

            if(string.IsNullOrEmpty(_strFulfilled) || string.IsNullOrEmpty(_strRating) || string.IsNullOrEmpty(_strMessage)) {
                lblResultJSON.Text = "Todos os campos devem ser preenchidos!";
                return;
            }

            try {
                IRestResponse rFeedback = m.Post("/orders/"+ _strOrderId +"/feedback", ps, new { rating = _strRating, fulfilled = _strFulfilled, message = _strMessage });
            } catch(Exception ex) { lblResultJSON.Text = "Qualificação NÃO efetuada!\n...\nErro: " + ex.Message; }


        }
    
    }
}