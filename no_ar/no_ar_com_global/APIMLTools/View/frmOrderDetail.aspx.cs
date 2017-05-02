using System;
using System.Collections.Generic;
using Model;
using Model.OrderDetail;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmOrderDetail : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {


            // 1 - Instância da Auth
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());

            #region : Inicializando as variáveis de instancia

            string code = Request["code"].ToString();
            string linha = "";


            string vid = Request["orderid"].ToString();

            string vOffset = "";
            if(string.IsNullOrEmpty(Request["offset"])) {
                vOffset = "0";
            } else {
                vOffset = Request["offset"].ToString();
            }

            #endregion

            #region : Parameters

            // Resource:  https://api.mercadolibre.com/orders/{order_id}?access_token={...}

            var p = new RestSharp.Parameter();
            p.Name = "access_token";
            p.Value = m.AccessToken;


            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);



            #endregion

            #region : Try do Resource

            OrderDetail vOrderDetail;

            try {

                IRestResponse response = m.Get("/orders/"+vid, ps);
                vOrderDetail = JsonConvert.DeserializeObject<OrderDetail>(response.Content);

            } catch(Exception ex) {
                linha += "<center><table align='center'>";
                linha += "<div>";
                lblResultJSON.Text = ex.Message;
                linha += "</div>";
                linha += "</table></center>";
                return;

            } // |Fim do Try

            #endregion


            int j=0;
            string aToken = "";
            string vHref = "";

            OrderDetail r = vOrderDetail;


            // AINDA FALTAM DADOS PARA RECUPERAR E MOSTRAR.
            // TIRAR DÚVIDAS SOBRE ATTRIBUTES NESTE RESOURCE;
            linha += "<div class='col-lg-12 col-md-12 col-sm-12'>";
            linha += "<div class='heading'>";
                 linha += "<h4>Detalhes do Pedido</h4>";
            linha += "</div>";

                #region : table da esquerda;

                linha += "<div class='row'><!--  321-row  /-->";

                linha += "<div class='col-lg-6 col-md-6'><!-- Dados dos Pedidos /-->";

                linha += "<div class='panel panel-default plain toggle panelClose panelRefresh'>";

                linha += "<div class='panel-heading white-bg'>";
                linha += "<h4 class='panel-title'>Dados dos Pedidos</h4>";
                linha += "</div>";
                linha += "<div class='panel-body'>";
                linha += "<table class='table table-stripe'>";
                linha += "<tr>";
                linha += "<th>Order ID</th>";
                linha += "<td>" + r.id.ToString() + "</td>";
                linha += "</tr>";


                linha += "<tr>";
                linha += "<th>Status</th>";
                linha += "<td>" + Util.GetTextoPtBR(r.status) + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>Data Pedido</th>";
                linha += "<td>" + Convert.ToDateTime(r.date_created).ToShortDateString() + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>Data Fechamento</th>";
                linha += "<td>" + Convert.ToDateTime(r.date_closed).ToShortDateString() + "</td>";
                linha += "</tr>";
                linha += "<tr>";

                foreach(OrderItem oItem in vOrderDetail.order_items) {
                    linha += "<th>Items ID</th>";

                    linha += "<td><a href='frmAnuncioPorID.aspx?items=" + oItem.item.id + "&code=" +code+ "'>" + oItem.item.id + "</a></td>";

                    //linha += "<td>" + oItem.item.id + "</td>";
                    linha += "</tr>";
                    linha += "<tr>";
                    linha += "<th>Título</th>";
                    linha += "<td>" + oItem.item.title + "</td>";
                    linha += "</tr>";


                    linha += "<tr>";
                    linha += "<th>Nº de Visitas</th>";
                    linha += "<td>" + Util.getVisitas(oItem.item.id, m) + "</td>";
                    linha += "</tr>";
                    
                    
                    linha += "<tr>";
                    linha += "<th>Qtde Vendidas</th>";
                    linha += "<td>" + oItem.quantity.ToString() + "</td>";
                    linha += "</tr>";
                    linha += "<tr>";
                    linha += "<th>Preço Unitário</th>";
                    linha += "<td>" + oItem.unit_price.ToString() + "</td>";
                    linha += "</tr>";


                    linha += "<tr>";
                    linha += "<th>Total no Pedido</th>";
                    linha += "<td>" + r.total_amount.ToString() + "</td>";
                    linha += "</tr>";

                
                }

                for(int l=0; l<r.payments.Count; l++) {

                    linha += "<tr>";
                    linha += "<th>Total para Vendedor</th>";
                    linha += "<td>" + r.payments[l].transaction_amount.ToString() + "</td>";
                    linha += "</tr>";

                    linha += "<tr>";
                    linha += "<th>Total da Transação</th>";
                    linha += "<td>" + r.payments[l].total_paid_amount.ToString() + "</td>";
                    linha += "</tr>";
                
                }

                

                linha += "</table>";
                linha += "</div>";

                linha += "</div>";

                linha += "</div><!-- FIM do Dados dos Pedidos /-->";

                #endregion

                j++;

                #region : Accordions da direita

                linha += "<div class='col-lg-6 col-md-6'><!-- Mais Detalhes /-->";

                linha += "<div class='panel plain toggle panelClose panelRefresh'>";

                linha += "<div class='panel-heading white-bg'>";
                linha += "<h4 class='panel-title'>Mais Detalhes</h4>";
                linha += "</div>";

                linha += "<div class='panel-body'>";


                linha += "<div class='panel-group accordion' id='accordion" + j.ToString() + "'>";

                /* ---- painel 01
                 * -------------------------------------------*/

                linha += "<div class='panel panel-primary'>";
                linha += "<div class='panel-heading'>";
                linha += "<h5 class='panel-title'>";
                linha += "<a class='accordion-toggle' data-toggle='collapse' data-parent='#accordion" + j.ToString() + "' href='#collapseOne" + j.ToString() + "'>DADOS DO COMPRADOR</a>";
                linha += "</h5>";
                linha += "</div>";
                linha += "<div id='collapseOne" + j.ToString() + "' class='panel-collapse collapse in'>";
                linha += "<div class='panel-body'>";

                linha += "<table class='table table-stripe'>";
                linha += "<tr>";
                linha += "<th>Id</th>";
                linha += "<td>" + r.buyer.id.ToString() + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>Apelido</th>";
                linha += "<td>" + r.buyer.nickname + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>Nome Completo</th>";
                linha += "<td>" + r.buyer.first_name + " " + r.buyer.last_name + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>E-Mail</th>";
                linha += "<td>" + r.buyer.email + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>Telefone</th>";
                linha += "<td>" + "(" + r.buyer.phone.area_code + ") " + r.buyer.phone.number + "</td>";
                linha += "</tr>";
                linha += "</table>";

                linha += "</div>";
                linha += "</div>";
                linha += "</div>";

                /* ---- painel 02
                 * -------------------------------------------*/

                linha += "<div class='panel panel-primary'>";
                linha += "<div class='panel-heading'>";
                linha += "<h5 class='panel-title'>";
                linha += "<a class='accordion-toggle' data-toggle='collapse' data-parent='#accordion" + j.ToString() + "' href='#collapseTwo" + j.ToString() + "'>DADOS DO PAGAMENTO</a>";
                linha += "</h5>";
                linha += "</div>";
                linha += "<div id='collapseTwo" + j.ToString() + "' class='panel-collapse collapse'>";
                linha += "<div class='panel-body'>";

             
                linha += "<table class='table table-stripe'>";

                string vPayments = "";
                foreach(Payment pmt in r.payments) {

                    string quinze = Util.GetTextoPtBR(pmt.operation_type);
                    string dezessete = pmt.overpaid_amount.ToString();
                    string dezenove = Util.GetTextoPtBR(pmt.payment_method_id).ToUpper();
                    string vinte = Util.GetTextoPtBR(pmt.payment_type);                    

                    vPayments += quinze;
                    vPayments += " - " + dezessete;
                    vPayments += " - " + vinte +" - " + dezenove;

                }


                for(int k = 0; k < r.payments.Count; k++) {

                    linha += "<tr>";
                    linha += "<th>Payment Id</th>";
                    linha += "<td>" + r.payments[k].id.ToString() + "</td>";
                    linha += "</tr>";
                    linha += "<tr>";
                    linha += "<th>Status</th>";
                    linha += "<td>" + Util.GetTextoPtBR(r.payments[k].status) + "</td>";
                    linha += "</tr>";


             //       string vinteseis = Util.GetTextoPtBR(pmt.status_detail);

                    linha += "<tr>";
                    linha += "<th>Total para Vendedor</th>";
                    linha += "<td>" + r.payments[k].transaction_amount.ToString() + "</td>";
                    linha += "</tr>";


                    linha += "<tr>";
                    linha += "<th>Total da Transação</th>";
                    linha += "<td>" + r.payments[k].total_paid_amount.ToString() + "</td>";
                    linha += "</tr>";


                    linha += "<tr>";
                    linha += "<th>Data do Pagto</th>";
                    linha += "<td>" + Convert.ToDateTime((string) r.payments[k].date_created).ToShortDateString() + "</td>";
                    linha += "</tr>";
                    linha += "<tr>";
                    linha += "<th>Última Atualização</th>";
                    linha += "<td>" + (r.payments[k].date_last_modified != null ? Convert.ToDateTime((string) r.payments[k].date_last_modified).ToShortDateString() : "[Não Consta]") + "</td>";

                    linha += "<tr>";
                    linha += "<th>Parcelas</th>";
                    linha += "<td>" + r.payments[k].installments.ToString() + "</td>";
                    linha += "</tr>";

                    /* ---------------------------------------------------------------------- */
                    linha += "<tr>";
                    linha += "<th>URL (Boleto)</th>";
                    linha += "<td>" + ((r.payments[k].activation_uri != null) ? "<a href='" + r.payments[k].activation_uri.ToString() + "' target='_blank'><img src='images/print_boleto.png' width='91' height='21' border='0' /></a>" : "") + "</td>";
                    linha += "</tr>";
                    /* ---------------------------------------------------------------------- */

                    linha += "<tr>";
                    linha += "<th>Banco (Boleto)</th>";
                    linha += "<td>" + ((r.payments[k].atm_transfer_reference.company_id != null) ? r.payments[k].atm_transfer_reference.company_id.ToString() : "") + "</td>";
                    linha += "</tr>";

                    //linha += "<tr>";
                    //linha += "<th>Ref.Trans. (Se boleto)</th>";
                    //linha += "<td>" + ((r.payments[k].atm_transfer_reference.transaction_id != null) ? r.payments[k].atm_transfer_reference.transaction_id.ToString() : "") + "</td>";
                    //linha += "</tr>";


                    linha += "<tr>";
                    linha += "<th>Outros...</th>";
                    linha += "<td>" + vPayments + "</td>";
                    linha += "</tr>";

                }
                linha += "</table>";


                linha += "</div>";
                linha += "</div>";
                linha += "</div>";

                /* ---- painel 03
                 * -------------------------------------------*/

                linha += "<div class='panel panel-primary'>";
                linha += "<div class='panel-heading'>";
                linha += "<h5 class='panel-title'>";
                linha += "<a class='accordion-toggle' data-toggle='collapse' data-parent='#accordion" + j.ToString() + "' href='#collapseThree" + j.ToString() + "'>QUALIFICAÇÕES</a>";
                linha += "</h5>";
                linha += "</div>";
                linha += "<div id='collapseThree" + j.ToString() + "' class='panel-collapse collapse'>";
                linha += "<div class='panel-body'>";

                // Inicio das qualificações de vendedor
                linha += "<table class='table table-stripe'>";
                if(r.feedback.sale != null && r.feedback.sale.status == "active") {

                    linha += "<tr>";
                    linha += "<th>(Pelo Vendedor)</th>";
                    linha += "<td>" + ((r.feedback.sale != null) ? Convert.ToDateTime((string) r.feedback.sale.date_created).ToShortDateString() : "[NULL]") + "</td>";
                    linha += "</tr>";
                    linha += "<tr>";
                    linha += "<th>Qualificada?</th>";
                    linha += "<td>" + ((r.feedback.sale.fulfilled != null) ? "[Sim]" : "[Não]") + "</td>";
                    linha += "</tr>";
                    linha += "<tr>";
                    linha += "<th>Qualificação</th>";
                    linha += "<td>" + ((!string.IsNullOrEmpty(r.feedback.sale.rating)) ? Util.GetTextoPtBR(r.feedback.sale.rating) : "[NULL]") + "</td>";
                    linha += "</tr>";

                } else {

                    linha += "<tr>";
                    linha += "<th>(Pelo Vendedor)</th>";
                    linha += "<td>Sem qualificação ou Anulada</td>";
                    linha += "</tr>";
                }
                linha += "</table>";
                // Fim das qualificações de vendedor

                linha += "<hr />";

                // Inicio das qualificações de comprador
                linha += "<table class='table table-stripe'>";
                if(r.feedback.purchase != null && r.feedback.purchase.status == "active") {

                    linha += "<tr>";
                    linha += "<th>(Pelo Comprador)</th>";
                    linha += "<td>" + (r.feedback.purchase != null ? Convert.ToDateTime((object) r.feedback.purchase.date_created).ToShortDateString() : "[NULL]") + "</td>";
                    linha += "</tr>";
                    linha += "<tr>";
                    linha += "<th>Qualificada?</th>";
                    linha += "<td>" + ((r.feedback.purchase.fulfilled != null) ? "[Sim]" : "[Não]") + "</td>";
                    linha += "</tr>";
                    linha += "<tr>";
                    linha += "<th>Qualificação</th>";
                    linha += "<td>" + ((!string.IsNullOrEmpty(r.feedback.purchase.rating)) ? Util.GetTextoPtBR(r.feedback.purchase.rating) : "[NULL]") + "</td>";
                    linha += "</tr>";

                } else {

                    linha += "<tr>";
                    linha += "<th>(Pelo Comprador)</th>";
                    linha += "<td>Sem qualificação ou Anulada</td>";
                    linha += "</tr>";
                }
                linha += "</table>";
                // Fim das qualificações de comprador                                                       


                linha += "</div>";
                linha += "</div>";
                linha += "</div>";


                /* ---- painel 04
                 * -------------------------------------------*/

                //linha += "<div class='panel panel-primary'>";
                //linha += "<div class='panel-heading'>";
                //linha += "<h5 class='panel-title'>";
                //linha += "<a class='accordion-toggle' data-toggle='collapse' data-parent='#accordion" + j.ToString() + "' href='#collapseFour" + j.ToString() + "'>SCOUT DE VISITAS</a>";
                //linha += "</h5>";
                //linha += "</div>";
                //linha += "<div id='collapseFour" + j.ToString() + "' class='panel-collapse collapse'>";
                //linha += "<div class='panel-body'>";


                //linha += "<table class='table table-stripe'>";
                //for(int k = 0; k < r.order_items.Count; k++) {

                //    linha += "<tr>";
                //    linha += "<th>Visitas</th>";
                //    linha += "<td>" + getVisitas(r.order_items[k].item.id, m).ToString() + "</td>";
                //    linha += "</tr>";

                //}
                //linha += "</table>";

                //linha += "</div>";
                //linha += "</div>";
                //linha += "</div>";


                /* ---- painel 05
                 * -------------------------------------------*/

                linha += "<div class='panel panel-primary'>";
                linha += "<div class='panel-heading'>";
                linha += "<h5 class='panel-title'>";
                linha += "<a class='accordion-toggle' data-toggle='collapse' data-parent='#accordion" + j.ToString() + "' href='#collapseFive" + j.ToString() + "'>DADOS DE FRETE</a>";
                linha += "</h5>";
                linha += "</div>";
                linha += "<div id='collapseFive" + j.ToString() + "' class='panel-collapse collapse'>";
                linha += "<div class='panel-body'>";

                linha += "<table class='table table-stripe'>";
                linha += "<tr>";
                linha += "<th>Id</th>";
                linha += "<td>" + r.shipping.id + "</td>";
                linha += "</tr>";

                if(r.shipping.status.Equals("ready_to_ship") || r.shipping.status.Equals("delivered")) {
                    linha += "<tr>";
                    linha += "<th>Status</th>";
                    linha += "<td>" + Util.GetTextoPtBR(r.shipping.status) + "</td>";
                    linha += "</tr>";
                    linha += "<tr>";
                    linha += "<th>Etiqueta</th>";

                    /*-----------------------------------------------------------------------------*/
                    aToken = Session["aToken"].ToString();
                    vHref = "https://api.mercadolibre.com/shipment_labels?shipment_ids=";

                    if(r.shipping.id != null) {
                        linha += "<td><a href='" + vHref +  r.shipping.id + "&savePdf=Y&access_token=" + aToken + "' target='_blank'><img src='Images/print_label.png'></a></td>";
                    } else {
                        linha += "<td>[Sem Etiqueta]</td>";
                    }
                    /*-----------------------------------------------------------------------------*/

                    linha += "</tr>";
                }

                linha += "<tr>";
                linha += "<th>Custo</th>";
                linha += "<td>" + r.shipping.cost.ToString() + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>Endereço / Entrega</th>";
                linha += "<td>" + ((r.shipping.receiver_address != null) ? (r.shipping.receiver_address.address_line + " - " +   r.shipping.receiver_address.street_number + " " + r.shipping.receiver_address.comment) : "") + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>Cidade</th>";
                linha += "<td>" + (r.shipping.receiver_address != null ? r.shipping.receiver_address.city.name : "[NULL]") + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>Estado</th>";
                linha += "<td>" + (r.shipping.receiver_address != null ? r.shipping.receiver_address.state.name : "[NULL]") + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>CEP</th>";
                linha += "<td>" + (r.shipping.receiver_address != null ? r.shipping.receiver_address.zip_code : "[NULL]") + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>Referência</th>";
                linha += "<td>" + (r.shipping.receiver_address != null ? r.shipping.receiver_address.comment : "[NULL]") +"</td>";
                linha += "</tr>";
                linha += "<tr>";
                linha += "<th>Tipo de Frete</th>";
                linha += "<td>" + ((r.shipping.shipment_type != null) ? Util.GetTextoPtBR(r.shipping.shipment_type) : "") +"</td>";
                linha += "</tr>";


                linha += "</table>";

                linha += "</div>";
                linha += "</div>";
                linha += "</div>";

                /* ---- painel 06
                 * -------------------------------------------*/

                linha += "<div class='panel panel-primary'>";
                linha += "<div class='panel-heading'>";
                linha += "<h5 class='panel-title'>";
                linha += "<a class='accordion-toggle' data-toggle='collapse' data-parent='#accordion" + j.ToString() + "' href='#collapseSix" + j.ToString() + "'>TAGs</a>";
                linha += "</h5>";
                linha += "</div>";
                linha += "<div id='collapseSix" + j.ToString() + "' class='panel-collapse collapse'>";
                linha += "<div class='panel-body'>";

                linha += "<table class='table table-stripe'>";
                for(int n = 0; n < r.tags.Count; n++) {

                    linha += "<tr>";
                    linha += "<th>Tags [" + (n+1) + "]</th>";
                    linha += "<td>" + (r.tags != null ? Util.GetTextoPtBR(r.tags[n].ToString()) : "[NULL]") + "</td>";
                    linha += "</tr>";
                }
                linha += "</table>";


                linha += "</div>";
                linha += "</div>";
                linha += "</div>";

                /* ---- final dos paineis accordions por item
                 * -------------------------------------------*/


                linha += "</div>";

                linha += "</div>";

                linha += "</div>";
                linha += "</div><!-- fim Mais Detalhes /-->";

                linha += "</div><!--  FIM de 321-row  /-->";

                #endregion

            lblResultJSON.Text = linha;

            lblResultJSON.Text += "</div><!-- Fim da DIV col-lg-12 /-->";

        }

    }
}