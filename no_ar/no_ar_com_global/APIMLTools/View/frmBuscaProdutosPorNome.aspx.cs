using System;
using System.Collections.Generic;
using Model;
using Models.Consulta;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmBuscaProdutosPorNome : System.Web.UI.Page {

        
        protected void Page_Load(object sender, EventArgs e) {
            

                if(!string.IsNullOrEmpty(Request["offset"]) && (!string.IsNullOrEmpty(Request["keyword"]))) {
                    txtBuscaProduto.Text = Request["keyword"];
                    MostraDados(txtBuscaProduto.Text);
                }  

        }

        protected void btnBuscar_Click(object sender, EventArgs e) {

            if(string.IsNullOrEmpty(txtBuscaProduto.Text)) {
                string vHtml = "";
                vHtml += "<table align='center'><tr><td>TEXTO PARA BUSCA É OBRIGATÓRIO!";
                vHtml += "</td></tr></table>";
                lblResultJSON.Text = vHtml;
                return;
            }

            MostraDados(txtBuscaProduto.Text);
        }


        private void MostraDados(string keyword) {
 
            //string categoria;
            //string catDescricao;

            ////if(string.IsNullOrEmpty(Request["cat"])) {
            ////    categoria = cboListaCategoria.Text;
            ////} else {
            ////    categoria = Request["cat"];
            ////}
            //categoria = cboListaCategoria.Text;

            ////if(string.IsNullOrEmpty(Request["cattxt"])){ 
            ////    catDescricao = cboListaCategoria.SelectedItem.Text; 
            ////} else {
            ////    catDescricao = Request["cattxt"];
            ////}
            //catDescricao = cboListaCategoria.SelectedItem.Text;

            // Recebe página atual;
            int vOffset;
            if(string.IsNullOrEmpty(Request["offset"])) {
                vOffset = 0;
            } else {
                vOffset = int.Parse(Request["offset"]);
            }




            if(string.IsNullOrEmpty(txtBuscaProduto.Text)) {
                string vHtml = "";
                vHtml += "<table align='center'><tr><td>TEXTO PARA BUSCA É OBRIGATÓRIO!";
                vHtml += "</td></tr></table>";
                lblResultJSON.Text = vHtml;
                return;
            }
            string code;
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());

            try {
                code = Request["code"];

            } catch(Exception ex) {
                string vHtml = "";
                vHtml += "<table align='center'><tr><td>" + ex.Message;
                vHtml += "</td></tr></table>";
                lblResultJSON.Text = vHtml;
                return;
            }

            var p = new RestSharp.Parameter();
            p.Name = "q";
            p.Value = keyword;

            var p2 = new RestSharp.Parameter();
            p2.Name = "limit";
            p2.Value = 10;

            var p3 = new RestSharp.Parameter();
            p3.Name = "offset";
            p3.Value = vOffset;

            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);
            ps.Add(p2);
            ps.Add(p3);

            Consulta consult;
            try {
                IRestResponse response = m.Get("/sites/MLB/search", ps);
                consult = JsonConvert.DeserializeObject<Consulta>(response.Content);
            } catch(Exception ex) {
                string vHtml = "";
                vHtml += "<table align='center'><tr><td>" + ex.Message;
                vHtml += "</td></tr></table>";
                lblResultJSON.Text = vHtml;
                return;
            }


            int qtde = consult.paging.total;
            int numRegPorPg = consult.paging.limit;
            int numPag = 0;

            if(qtde % numRegPorPg == 0) {
                numPag = qtde / numRegPorPg;
            } else {
                numPag = (qtde / numRegPorPg) + 1;
            }

            string linha = "";


            string vPublicidd = "";


            linha += "<div class='col-lg-12'>";

            linha += "<div class='panel panel-default toggle panelMove panelClose panelRefresh'>";

            linha += "<div class='panel-heading'>";
            linha += "<h4 class='panel-title'>Anúncios:</h4>";
            linha += "</div>";
            linha += "<div class='panel-body'>";

            linha += Util.GetPaginacao(keyword, qtde, numRegPorPg, numPag, "http://"+Application["HOST"], code, vOffset, "frmBuscaProdutosPorNome.aspx");

            
            /* --------------------------------------------------- */
            // CABEÇALHO DA TABELA COM OS DADOS DO CROSDOCKING //

            linha += "<table class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            linha += "<tbody>";
            /* --------------------------------------------------- */
            linha += "<thead>";
            linha += "<tr>";
            linha += "<th>Limite</th>";
            linha += "<th>Registros</th>";
            linha += "<th>Página Atual</th>";
            linha += "<th>KeyWord da Busca</th>";
            linha += "<th>Qtde Páginas</th>";
            linha += "<th>Site ID</th>";
            linha += "</tr>";
            linha += "</thead>";
            /* --------------------------------------------------- */
            linha += "<tbody>";
            linha += "<tr>";
            linha += "<td>" + consult.paging.limit + "</td>";
            linha += "<td>" + consult.paging.total + "</td>";
            linha += "<td>" + (consult.paging.offset + 1) + "</td>";
            linha += "<td>" + consult.query + "</td>";
            linha += "<td>" + numRegPorPg + "</td>";
            linha += "<td>" + consult.site_id + "</td>";
            linha += "</tr>";
            /* --------------------------------------------------- */
            linha += "</tbody>";
            linha += "</table>";

            // CABEÇALHO DA TABELA COM OS DADOS DO CROSDOCKING //
            /* --------------------------------------------------- */



            linha += "<table id='tabletools' class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            linha += "<tbody>";



            foreach(Result r in consult.results) {

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

            linha += Util.GetPaginacao(keyword, qtde, numRegPorPg, numPag, "http://"+Application["HOST"], code, vOffset, "frmBuscaProdutosPorNome.aspx");

            linha += "</div>";
            linha += "</div>";

            linha += "</div>";


            linha += "<br /><hr /><br />";


            linha += "<center><div>";
            lblResultJSON.Text = linha;
            lblResultJSON.Text += "</div></center>";




            //    linha += "<tr><td class='auto-style7'>Produto: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.title + "</td></tr>";

            //    linha += "<tr><td class='auto-style7'>Quantidade Disponível: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.available_quantity.ToString() + "</td></tr>";


            //    linha += "<tr><td class='auto-style7'>Medalha: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.seller.power_seller_status + "</td></tr>";
            //    linha += "<tr><td class='auto-style7'>Frete Grátis? </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.shipping.free_shipping == true ? "[Sim]" : "[Não]") + "</td></tr>";


            //    linha += "<tr><td class='auto-style7'>ID Estado: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.address != null ? r.address.state_id : "[Não Consta]") + "</td></tr>";
            //    linha += "<tr><td class='auto-style7'>Nome do Estado: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.address != null ? r.address.state_name : "[Não Consta]") + "</td></tr>";





            m = null;


        }

    }
}