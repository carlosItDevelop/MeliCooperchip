using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using Models.Orders;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmOrder : System.Web.UI.Page {


        
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void btnBuscarOrder_Click(object sender, EventArgs e) {

            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"];

            var p = new RestSharp.Parameter { Name = "id", Value = int.Parse(txtId.Text) };

            var ps = new List<RestSharp.Parameter> { p };

            IRestResponse response = m.Get("/orders/" + p.Value + "?access_token=" + m.AccessToken);

            var orders = JsonConvert.DeserializeObject<Orders>(response.Content);

            string linha = orders.payments.Aggregate("", (current, pay) => current + (pay.currency_id + " - " + pay.id + "<br />"));


            lblResultado.Text = response.Content;
            lblResultadoAlinhado.Text = linha;

            lblResultadoObjeto.Text = "";
            lblResultadoObjeto.Text += (orders.id > 0 ? orders.id.ToString() : "") + "<br />";
            lblResultadoObjeto.Text += (orders.shipping.status ?? "[]") + "<br />";
            lblResultadoObjeto.Text += (orders.shipping.shipment_type ?? "[]") + "<br />";
            lblResultadoObjeto.Text += (orders.total_amount > 0 ? orders.total_amount.ToString("0.00") : "0,00") + "<br />";
            lblResultadoObjeto.Text += (orders.feedback.purchase.rating ?? "[]") + "<br />";
            lblResultadoObjeto.Text += "<hr />" + "<br />" + m.AccessToken;


        }    
    
    }
}