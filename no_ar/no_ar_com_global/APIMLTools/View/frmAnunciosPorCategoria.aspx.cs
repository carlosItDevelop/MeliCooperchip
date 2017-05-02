using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using Models.Anuncio;
using SDK;
using Models;


namespace View {
    public partial class FrmAnunciosPorCategoria : System.Web.UI.Page {

        
        protected void Page_Load(object sender, EventArgs e) {
                        



            if(!IsPostBack) {
                // 1 - Instância da Auth
                Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());
                IRestResponse response = m.Get("/sites/MLB/categories");
                var categoria = JsonConvert.DeserializeObject<List<Models.Categories>>(response.Content);

                string vCat = Request["cat"];

                cboListaCategoria.Items.Clear();
                int k = 0;
                foreach(Models.Categories cat in categoria) {
                    cboListaCategoria.Items.Add(cat.Name);
                    cboListaCategoria.Items[k].Value = cat.id;
                    k++;
                }
                        
                if(!string.IsNullOrEmpty(vCat)) {
                    cboListaCategoria.SelectedValue = vCat;
                }

                MostraDados();

            }

        }
        protected void btnEnviar_Click(object sender, EventArgs e) {


            //Response.Redirect("frmAnunciosPorCategoriaDetalhes.aspx?cattxt=" + cboListaCategoria.SelectedItem.Text + "&cat=" + cboListaCategoria.Text + "&code=" + Request["code"] + "&offset=" + pgAtual);

            MostraDados();

        }

        private void MostraDados() {

            string categoria;
            string catDescricao;

            //if(string.IsNullOrEmpty(Request["cat"])) {
            //    categoria = cboListaCategoria.Text;
            //} else {
            //    categoria = Request["cat"];
            //}
            categoria = cboListaCategoria.Text; 

            //if(string.IsNullOrEmpty(Request["cattxt"])){ 
            //    catDescricao = cboListaCategoria.SelectedItem.Text; 
            //} else {
            //    catDescricao = Request["cattxt"];
            //}
            catDescricao = cboListaCategoria.SelectedItem.Text; 

            // Recebe página atual;
            int vOffset;
            if (string.IsNullOrEmpty(Request["offset"])){
                vOffset = 0;
            } else {
                vOffset = int.Parse(Request["offset"]);
            }


                       

            // 1 - Instância da Auth
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());

            string code = Request["code"];


            var ps = new List<RestSharp.Parameter>();

            var p = new RestSharp.Parameter();
            var p2 = new RestSharp.Parameter();
            var p3 = new RestSharp.Parameter();

            p2.Name = "limit";
            p2.Value = 10;

            p.Name = "category";
            p.Value = categoria;

            p3.Name = "offset";
            p3.Value = vOffset;


            ps.Add(p);
            ps.Add(p2);
            ps.Add(p3);

            Anuncio anunc;
            try {
                IRestResponse response = m.Get("/sites/MLB/search", ps);
                anunc = JsonConvert.DeserializeObject<Anuncio>(response.Content);
            } catch(Exception ex) {
                lblResultJSON.Text = ex.Message;
                return;
            }

            string linha = "";

            int qtde = anunc.paging.total;
            int numRegPorPg = anunc.paging.limit;
            int numPag = 0;

            if(qtde % numRegPorPg == 0) {
                numPag = qtde / numRegPorPg;
            } else {
                numPag = (qtde / numRegPorPg) + 1;
            }



            string vPublicidd = "";


            linha += "<div class='col-lg-12'>";

            linha += "<div class='panel panel-default toggle panelMove panelClose panelRefresh'>";

            linha += "<div class='panel-heading'>";
            linha += "<h4 class='panel-title'>Anúncios:</h4>";
            linha += "</div>";
            linha += "<div class='panel-body'>";

            linha += Util.GetPaginacao(qtde, numRegPorPg, numPag, "http://"+Application["HOST"], code, vOffset, categoria, "frmAnunciosPorCategoria.aspx");


            // CABEÇALHO DA TABELA COM OS DADOS DO CROSDOCKING //


            linha += "<table class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            linha += "<tbody>";

            linha += "<thead>";
            linha += "<tr>";
            linha += "<th>Limite</th>";
            linha += "<th>Registros</th>";
            linha += "<th>Página Atual</th>";
            linha += "<th>ID Categoria</th>";
            linha += "<th>Qtde Páginas</th>";
            linha += "</tr>";
            linha += "</thead>";
            linha += "<tbody>";
            linha += "<tr>";
            linha += "<td>" + anunc.paging.limit + "</td>";
            linha += "<td>" + anunc.paging.total + "</td>";
            linha += "<td>" + (anunc.paging.offset + 1) + "</td>";
            linha += "<td><button class='btn btn-default mr5 mb10' data-toggle='modal' data-target='#modal-style6'>" + categoria.ToUpper() + "</button></td>";


            linha += "<td>" + numPag + "</td>";
            linha += "</tr>";

            linha += "</tbody>";
            linha += "</table>";



            // CABEÇALHO DA TABELA COM OS DADOS DO CROSDOCKING //


            linha += "<table id='tabletools' class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            linha += "<tbody>";



            foreach(Models.Anuncio.Result r in anunc.results) {

                linha += "<tr>";
                linha += "<td colspan='9'><b>" + r.title + "</b></td>";
                linha += "<td colspan='3'><a href='frmAnuncioPorID.aspx?items=" + r.id + "&code=" + code + "'>" + r.id + "</a></td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<td rowspan='4'><img src='" + r.thumbnail + " border='0' width='150' height='150' /></td>";
                linha += "<td>" + Util.GetNick(r.seller.id, m) + " - <a href='frmGetPerfilSellers.aspx?seller_id=" + r.seller.id + "&code=" + code + "'>" + r.seller.id + "</a></td>";
                linha += "<td>" + (r.buying_mode.Equals("buy_it_now") ? "[ Compre Já ]" : "[ Leilão ]") + "</td>";
                linha += "<td colspan='3'>Finaliza em: " + (Convert.ToDateTime((string) r.stop_time)).ToShortDateString() + "</td>";

                if(r.listing_type_id.ToUpper().Equals("GOLD_PREMIUM")) {
                    vPublicidd = "[ DIAMANTE ]";
                } else if(r.listing_type_id.ToUpper().Equals("GOLD")) {
                    vPublicidd = "[ OURO ]";
                } else if(r.listing_type_id.ToUpper().Equals("SILVER")) {
                    vPublicidd = "[ PRATA ]";
                } else if(r.listing_type_id.ToUpper().Equals("BRONZE")) {
                    vPublicidd = "[ BRONZE ]";
                } else if(r.listing_type_id.ToUpper().Equals("FREE")) {
                    vPublicidd = "[ GRÁTIS ]";
                } else if(string.IsNullOrEmpty(r.listing_type_id)) {
                    vPublicidd = "SEM PUBLICIDADE";
                } else {
                    vPublicidd = "OUTRA PUBLICIDADE";
                }

                //   r.installments.

                linha += "<td colspan='7'>" +  vPublicidd + "</td>";

                linha += "</tr>";
                linha += "<tr>";
                linha += "<td>Preço: R$  " + r.price.ToString("0.00") + "</td>";
                linha += "<td>" + (r.installments == null ? "[]" : "Até " + r.installments.quantity + " vezes de: " + r.installments.amount.ToString("0.00")) + "</td>";
                linha += "<td colspan='3'>" + (r.accepts_mercadopago ? "ACEITA MERCADO PAGO" : "NÃO ACEITA MERCADO PAGO") + "</td>";

                linha += "<td colspan='5'>" + (r.condition.Equals("new") ? "PRDUTO NOVO" : "PRODUTO USADO") + "</td>";
                linha += "<td>" + (r.shipping.free_shipping ? "FRETE GRÁTIS" : "FRETE PAGO") + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<td>Vend / Disp:  [ " + r.sold_quantity + " / " + r.available_quantity + " ]</td>";
                linha += "<td>" + r.seller_address.state.name +" / " + r.seller_address.city.name + "</td>";
                linha += "<td colspan='3'>Modo Frete:  [ " + r.shipping.mode.ToUpper() + " ]</td>";
                linha += "<td colspan='6'>Medalha:  [ " + ((r.seller.power_seller_status != null) ? r.seller.power_seller_status.ToUpper() : "NULLO") + " ]</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<td colspan='11'><a href='" + r.permalink + "' target='_blank'>" + r.permalink + "</a></td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<td colspan='12' style='background-color: #e1e1e1;'></td>";
                linha += "</tr>";

            }

            linha += "</tbody>";
            linha += "</table>";

            linha += Util.GetPaginacao(qtde, numRegPorPg, numPag, "http://"+Application["HOST"], code, vOffset, categoria, "frmAnunciosPorCategoria.aspx");

            linha += "</div>";
            linha += "</div>";

            linha += "</div>";


            linha += "<br /><hr /><br />";


            linha += "<center><div>";
            lblResultJSON.Text = linha;
            lblResultJSON.Text += "</div></center>";
        }

    }
}