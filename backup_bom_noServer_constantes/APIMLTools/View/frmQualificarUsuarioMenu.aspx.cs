using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Models.PedidosRecentes;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmQualificarUsuarioMenu : System.Web.UI.Page {

        

        protected void Page_Load(object sender, EventArgs e) {
            

            if(!IsPostBack) {
                // PRIMEIRO PEGAMOS OS CÓDIGOS DOS PEDIDOS PARA PREENCHER A CBO;

                // 1 - Instância da Auth
                Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

                string code = Request["code"];

                var p = new RestSharp.Parameter { Name = "seller", Value = ConfigurationManager.AppSettings["SELLER"] };
                var p2 = new RestSharp.Parameter { Name = "access_token", Value = m.AccessToken };

                //var p3 = new RestSharp.Parameter();
                //p3.Name = "";
                //p3.Value = "";

                var ps = new List<RestSharp.Parameter> { p, p2 };
                //    ps.Add(p3);
                //https://api.mercadolibre.com/orders/search/recent?seller={sellerID}&access_token={...}

                PedidosRecentes pRecentes;
                try {
                    IRestResponse response = m.Get("/orders/search/recent", ps);
                    pRecentes = JsonConvert.DeserializeObject<PedidosRecentes>(response.Content);
                } catch (Exception ex){
                    lblResultJSON.Text = ex.Message;
                    return;
                }
                cboUsuariosParaQualificar.Items.Clear();

                for(int k = 0; k < pRecentes.results.Count; k++) {
                    if(pRecentes.results[k].feedback.sale != null) {
                        cboUsuariosParaQualificar.Items.Add((string) pRecentes.results[k].buyer.nickname);
                    }
                }

            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e) {
            // AQUI FAREMOS O POST DE QUALIFICAÇÃO!

        }    
    }
}