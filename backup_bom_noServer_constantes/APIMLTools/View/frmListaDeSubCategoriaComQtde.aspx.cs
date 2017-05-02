using System;
using System.Collections.Generic;
using Model;
using Models.ListaDeSubCategoriaComQtde;
using Newtonsoft.Json;
using RestSharp;
using SDK;
using Categories = Models.Categories;

namespace View {
    public partial class FrmListaDeSubCategoriaComQtde : System.Web.UI.Page {
        
        protected void Page_Load(object sender, EventArgs e) {
            

            if(!IsPostBack) {
                // 1 - Instância da Auth
                Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());
                IRestResponse response = m.Get("/sites/MLB/categories");
                var categoria = JsonConvert.DeserializeObject<List<Categories>>(response.Content);

                cboCategoriasComQtde.Items.Clear();
                int k = 0;
                foreach(Categories cat in categoria) {
                    cboCategoriasComQtde.Items.Add(cat.Name);
                    cboCategoriasComQtde.Items[k].Value = cat.id;
                    k++;
                }
            }
        }
        protected void btnEnviar_Click(object sender, EventArgs e) {

            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"];


            string vUrl = "/categories/" + cboCategoriasComQtde.Text.Trim();
            IRestResponse response = m.Get(vUrl);

            var listadecategoria = JsonConvert.DeserializeObject<ListaDeSubCategoriaComQtde>(response.Content);

            string linha = "";


            linha += "<div><table>";

            linha += "<tr><td>Categoria ID </td><td></td><td>" + cboCategoriasComQtde.Text.ToUpper() + "</td></tr>";
            linha += "<tr><td>Categoria Nome: </td><td class='auto-style6'></td><td class='td_conteudo'>" + listadecategoria.name + "</td></tr>";
            linha += "<tr><td>Link da Categoria: </td><td></td><td><a href='" + listadecategoria.permalink + "' target='_blank'>" + listadecategoria.permalink + "</a></td></tr>";
            linha += "<tr><td>Total da Categoria: </td><td></td><td>" + listadecategoria.total_items_in_this_category + "</td></tr>";


            linha += "</table></div>";

            linha += "<hr />";

            linha += "<table id='tabletools' class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            linha += "<tbody>";

            linha += "<tr><th>SubCategoria ID</th><th>Nome da Categoria</th><th>Quantidade</th></tr>";

            foreach(ChildrenCategory cat in listadecategoria.children_categories) {
                linha += "<tr><td >"+cat.id+"</td><td>"+cat.name+"</td><td>"+cat.total_items_in_this_category+"</td></tr>";
            }

            linha += "</tbody>";
            linha += "</table>";

            lblResultJSON.Text = linha;





            //linha += "<table id='tabletools' class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            //linha += "<tbody>";



            //foreach(Result r in consult.results) {

            //    linha += "<tr>";
            //    linha += "<td colspan='9'><b>" + r.title + "</b></td>";
            //    linha += "<td colspan='3'><a href='" + vServer +"/frmAnuncioPorID.aspx?items=" + r.id + "&code=" + code + "'>" + r.id + "</a></td>";
            //    linha += "</tr>";
            //    linha += "<tr>";
            //    linha += "<td rowspan='4'><img src='" + r.thumbnail + " border='0' width='150' height='150' /></td>";
            //    linha += "<td>" + Util.GetNick(r.seller.id, m) + " - <a href='" + vServer +"/frmGetPerfilSellers.aspx?seller_id=" + r.seller.id + "&code=" + code + "'>" + r.seller.id + "</a></td>";
            //    linha += "<td>" + (r.buying_mode.Equals("buy_it_now") ? "[ Compre Já ]" : "[ Leilão ]") + "</td>";
            //    linha += "<td colspan='3'>Finaliza em: " + (Convert.ToDateTime(r.stop_time)).ToShortDateString() + "</td>";

            //    if(r.listing_type_id.ToUpper().Equals("GOLD_PREMIUM")) {
            //        vPublicidd = "[ DIAMANTE ]";
            //    } else if(r.listing_type_id.ToUpper().Equals("GOLD")) {
            //        vPublicidd = "[ OURO ]";
            //    } else if(r.listing_type_id.ToUpper().Equals("SILVER")) {
            //        vPublicidd = "[ PRATA ]";
            //    } else if(r.listing_type_id.ToUpper().Equals("BRONZE")) {
            //        vPublicidd = "[ BRONZE ]";
            //    } else if(r.listing_type_id.ToUpper().Equals("FREE")) {
            //        vPublicidd = "[ GRÁTIS ]";
            //    } else if(string.IsNullOrEmpty(r.listing_type_id)) {
            //        vPublicidd = "SEM PUBLICIDADE";
            //    } else {
            //        vPublicidd = "OUTRA PUBLICIDADE";
            //    }

            //    //   r.installments.

            //    linha += "<td colspan='7'>" +  vPublicidd + "</td>";

            //    linha += "</tr>";
            //    linha += "<tr>";
            //    linha += "<td>Preço: R$  " + r.price.ToString("0.00") + "</td>";
            //    linha += "<td>" + (r.installments == null ? "[]" : "Até " + r.installments.quantity + " vezes de: " + r.installments.amount.ToString("0.00")) + "</td>";
            //    linha += "<td colspan='3'>" + (r.accepts_mercadopago ? "ACEITA MERCADO PAGO" : "NÃO ACEITA MERCADO PAGO") + "</td>";

            //    linha += "<td colspan='5'>" + (r.condition.Equals("new") ? "PRDUTO NOVO" : "PRODUTO USADO") + "</td>";
            //    linha += "<td>" + (r.shipping.free_shipping ? "FRETE GRÁTIS" : "FRETE PAGO") + "</td>";
            //    linha += "</tr>";
            //    linha += "<tr>";
            //    linha += "<td>Vend / Disp:  [ " + r.sold_quantity + " / " + r.available_quantity + " ]</td>";
            //    linha += "<td>" + r.seller_address.state.name +" / " + r.seller_address.city.name + "</td>";
            //    linha += "<td colspan='3'>Modo Frete:  [ " + r.shipping.mode.ToUpper() + " ]</td>";
            //    linha += "<td colspan='6'>Medalha:  [ " + ((r.seller.power_seller_status != null) ? r.seller.power_seller_status.ToUpper() : "NULLO") + " ]</td>";
            //    linha += "</tr>";
            //    linha += "<tr>";
            //    linha += "<td colspan='11'><a href='" + r.permalink + "' target='_blank'>" + r.permalink + "</a></td>";
            //    linha += "</tr>";
            //    linha += "<tr>";
            //    linha += "<td colspan='12' style='background-color: #e1e1e1;'></td>";
            //    linha += "</tr>";

            //}

            //linha += "</tbody>";
            //linha += "</table>";


        }
    }
}