using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Models.PedFech21OrNotQualify;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmListaResumidaPedFech21OrNotQualify : System.Web.UI.Page {
        

        protected void Page_Load(object sender, EventArgs e) {
            


            // 1 - Instância da Auth
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());

            #region : Inicializando as variáveis de instancia

            string code = Request["code"].ToString();
            string linha = "";

            int qtde = 0;
            int numRegPorPg = 0;
            int numPag = 0;

            string vOffset = "";
            if(string.IsNullOrEmpty(Request["offset"])) {
                vOffset = "0";
            } else {
                vOffset = Request["offset"].ToString();
            }

            #endregion

            #region : Parameters

            // Resource:  https://api.mercadolibre.com/orders/search?seller=seller_id&access_token={...} 

            var p = new RestSharp.Parameter();
            p.Name = "seller";
            p.Value = ConfigurationManager.AppSettings["SELLER"].ToString();

            var p2 = new RestSharp.Parameter();
            p2.Name = "access_token";
            p2.Value = m.AccessToken;

            var p3 = new RestSharp.Parameter();
            p3.Name = "offset";
            p3.Value = vOffset;

            // pulei o p4;

            var p5 = new RestSharp.Parameter();
            p5.Name = "display";
            p5.Value = "complete";


            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);
            ps.Add(p2);
            ps.Add(p3);
            ps.Add(p5);


            #endregion

            #region : Try do Resource

            PedFech21OrNotQualify pdCompletados;

            try {

                IRestResponse response = m.Get("/orders/search", ps);
                pdCompletados = JsonConvert.DeserializeObject<PedFech21OrNotQualify>(response.Content);

                qtde = pdCompletados.paging.total;
                numRegPorPg = pdCompletados.paging.limit;
                numPag = 0;

                if(qtde % numRegPorPg == 0) {
                    numPag = qtde / numRegPorPg;
                } else {
                    numPag = (qtde / numRegPorPg) + 1;
                }
            } catch(Exception ex) {
                linha += "<center><table align='center' class='auto-style1'>";
                linha += "<div>";
                lblResultJSON.Text = ex.Message;
                linha += "</div>";
                linha += "</table></center>";
                return;

            } // |Fim do Try

            #endregion


            #region : <div class='panel-body table'>

            linha += "<div class='panel-body table'>";

            linha += "<h4 class='panel-title'>Pedidos Fechados em 21 dias ou NÃO Qualificados por Ambos:</h4>";

            linha += "<table class='table table-bordered'>";
            linha += "<thead>";
            linha += "<tr>";
            linha += "<th>Registros por Página</th>";
            linha += "<th>Total de Registros</th>";
            linha += "<th>Página Atual</th>";
            linha += "<th>Qtde Páginas</th>";
            linha += "<th>Display</th>";
            linha += "</tr>";
            linha += "</thead>";
            linha += "<tbody>";
            linha += "<tr>";
            linha += "<td>" + numRegPorPg.ToString() + "</td>";
            linha += "<td>" + qtde.ToString() + "</td>";
            linha += "<td>" + (pdCompletados.paging.offset + 1).ToString() + "</td>";
            linha += "<td>" + numPag.ToString() + "</td>";
            linha += "<td>" + pdCompletados.display + "</td>";
            linha += "</tr>";
            linha += "</tbody>";
            linha += "</table>";

            linha += "</div>";

            #endregion


            // INDA FALTAM DADOS PARA RECUPERAR E MOSTRAR.
            // TIRAR DÚVIDAS SOBRE ATTRIBUTES NESTE RESOURCE;

            linha += "<div class='row'><!--  321-row  /-->";

            linha += "<div class='col-lg-12 col-md-12 col-sm-12'><!-- Dados dos Pedidos /-->";

            linha += "<div class='panel panel-default plain toggle panelClose panelRefresh'>";

            linha += "<div class='panel-heading white-bg'>";
            linha += "<h4 class='panel-title'>Dados dos Pedidos</h4>";
            linha += "</div>";
            linha += "<div class='panel-body'>";
            linha += "<table class='table table-stripe'>";

            linha += "<tr><th>Order ID</th><th>Item ID</th><th>Título</th><th>Status</th><th>Detalhes</th></tr>";


            foreach(Result r in pdCompletados.results) {


                #region : table da esquerda;

                linha += "<tr>";
                linha += "<td>" + r.id.ToString() + "</td>";

                for(int k = 0; k < r.order_items.Count; k++) {

                    linha += "<td><a href='frmAnuncioPorID.aspx?items=" + r.order_items[k].item.id + "&code=" +code+ "'>" + r.order_items[k].item.id + "</a></td>";
                    linha += "<td>" + r.order_items[k].item.title + "</td>";

                }


                linha += "<td>" + Util.GetTextoPtBR(r.status) + "</td>";
                linha += "<td><a href='frmOrderDetail.aspx?orderid=" + r.id + "&code=" + code + "' target='_self'><button class='btn btn-primary'>Detalhes</button></a></td>";
                linha += "</tr>";



                #endregion

            }

            linha += "</table>";
            linha += "</div>";

            linha += "</div>";

            linha += "</div><!-- FIM do Dados dos Pedidos /-->";

            linha += "</div><!-- FIM row /-->";

            lblResultJSON.Text = linha;
        }

    }
}