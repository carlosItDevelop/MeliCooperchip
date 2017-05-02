using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Models.PedidosArquivados;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmPedidosArquivados : System.Web.UI.Page {
        
        

        protected void Page_Load(object sender, EventArgs e) {
            


            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"].ToString();

            Session["AccessToken"] = m.AccessToken;
            Session["RefreshToken"] = m.RefreshToken;

            var p = new RestSharp.Parameter();
            p.Name = "seller";
            p.Value = ConfigurationManager.AppSettings["SELLER"].ToString();

            var p2 = new RestSharp.Parameter();
            p2.Name = "access_token";
            p2.Value = m.AccessToken;

            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);
            ps.Add(p2);


            // Resource:  https://api.mercadolibre.com/orders/search/archived?seller=59181149&access_token={...}            

            IRestResponse response = m.Get("/orders/search/archived", ps);
            var pdArquivados = JsonConvert.DeserializeObject<PedidosArquivados>(response.Content);


            string linha = "";


            int qtde = pdArquivados.paging.total;
            int numRegPorPg = pdArquivados.paging.limit;
            int numPag = 0;

            if(qtde % numRegPorPg == 0) {
                numPag = qtde / numRegPorPg;
            } else {
                numPag = (qtde / numRegPorPg) + 1;
            }


            linha += "<table align='center' class='auto-style1'>";

            linha += "<tr><td class='auto-style7'>Limite: </td><td class='auto-style6'></td><td class='td_conteudo'>" + pdArquivados.paging.limit + "</td><td></td></tr>";
            linha += "<tr><td class='auto-style7'>Registros: </td><td class='auto-style6'></td><td class='td_conteudo'>" + pdArquivados.paging.total + "</td><td></td></tr>";
            linha += "<tr><td class='auto-style7'>Página Atual: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (pdArquivados.paging.offset + 1) + "</td><td></td></tr>";
            linha += "<tr><td class='auto-style7'>Qtde Páginas: </td><td class='auto-style6'></td><td class='td_conteudo'>" + numPag.ToString() + "</td><td></td></tr>";
            linha += "<tr><td class='auto-style7'>Display: </td><td class='auto-style6'></td><td class='td_conteudo'>" + pdArquivados.display + "</td><td></td></tr>";

            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";


            foreach(Result r in pdArquivados.results) {
                //         linha += "<tr><td class='auto-style7'><img src='" + r.thumbnail + " border='0' /></td><td class='auto-style6'></td><td class='td_conteudo'></td><td></td></tr>";

                linha += "<tr><td class='auto-style7'>Order ID: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.id + "</td><td></td></tr>";

                linha += "<tr><td class='auto-style7'>Status: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Util.GetTextoPtBR(r.status) + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Data Pedido: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Convert.ToDateTime((string) r.date_created).ToShortDateString() + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Data Fechamento: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Convert.ToDateTime((string) r.date_closed).ToShortDateString() + "</td><td></td></tr>";

                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>ÍTENS DO PEDIDO:</td><td></td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";


                for(int k = 0; k < r.order_items.Count; k++) {
                    linha += "<tr><td class='auto-style7'>ID do Produto: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.order_items[k].item.id + "</td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'>Título: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.order_items[k].item.title + "</td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'>Quantidade: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.order_items[k].quantity.ToString() + "</td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'>Preço Untário: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.order_items[k].unit_price.ToString("0.00") + "</td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'>ID da Moeda: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.order_items[k].currency_id + "</td><td></td></tr>";
                }
                linha += "<tr><td class='auto-style7'>Total: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.total_amount.ToString("0.00") + "</td><td></td></tr>";

                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo_td_comprador'><h3>DADOS DO COMPRADOR:</h3></td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";


                linha += "<tr><td class='auto-style7'>ID: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.buyer.id + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Apelido: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.buyer.nickname + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Nome: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.buyer.first_name + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Sobrenome: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.buyer.last_name + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>e-Mail: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.buyer.email + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Telefone: </td><td class='auto-style6'></td><td class='td_conteudo'>" + "(" + r.buyer.phone.area_code + ") " + r.buyer.phone.number + "</td><td></td></tr>";

                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>DADOS DO VENDEDOR:</td><td></td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";

                linha += "<tr><td class='auto-style7'>ID: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.seller.id + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Apelido: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.seller.nickname + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Nome: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.seller.first_name + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Sobrenome: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.seller.last_name + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>e-Mail: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.seller.email + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Telefone: </td><td class='auto-style6'></td><td class='td_conteudo'>" + "(" + r.seller.phone.area_code + ") " + r.seller.phone.number + "</td><td></td></tr>";

                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>DADOS DO PAGAMENTO:</td><td></td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";

                for(int k = 0; k < r.payments.Count; k++) {
                    linha += "<tr><td class='auto-style7'>ID Pagamento: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.payments[k].id + "</td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'>Status do Pagamento: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.payments[k].status + "</td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'>Total: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.payments[k].transaction_amount.ToString("0.00") + "</td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'>Início: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Convert.ToDateTime((string) r.payments[k].date_created).ToShortDateString() + "</td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'>Última Atualização: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.payments[k].date_last_modified != null ? Convert.ToDateTime((string) r.payments[k].date_last_modified).ToShortDateString() : "[Não Consta]") + "</td><td></td></tr>";
                }

                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>QUALIFICAÇÕES:</td><td></td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";

                linha += "<tr><td class='auto-style7'>Data (Pelo Vendedor): </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.feedback.sale != null ? Convert.ToDateTime((string) r.feedback.sale.date_created).ToShortDateString() : "[]") + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Qualificada? </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.feedback.sale != null ? (r.feedback.sale.fulfilled ? "Sim" : "Não") : "[]") + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Qualificação: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.feedback.sale != null ? r.feedback.sale.rating : "[]") + "</td><td></td></tr>";

                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";

                if(r.feedback.purchase != null && r.feedback.purchase.status == "active") {

                    linha += "<tr><td class='auto-style7'>Data (Pelo Comprador): </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.feedback.purchase != null ? Convert.ToDateTime((string) r.feedback.purchase.date_created).ToShortDateString() : "[]") + "</td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'>Qualificada? </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.feedback.purchase != null ? (r.feedback.purchase.fulfilled.HasValue ? "Sim" : "Não") : "[]") + "</td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'>Qualificação: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.feedback.purchase != null ? r.feedback.purchase.rating : "[]") + "</td><td></td></tr>";
                } else {
                    linha += "<tr><td class='auto-style7'>Data (Pelo Comprador): </td><td class='auto-style6'></td><td class='td_conteudo'>" + "Sem qualificação ou Anulada" + "</td><td></td></tr>";
                }



                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo_td_comprador'><h3>SCOUT DE VISITAS:</h3></td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";


                for(int k = 0; k < r.order_items.Count; k++) {
                    linha += "<tr><td class='auto-style7'>Visitas: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Util.getVisitas(r.order_items[k].item.id, m).ToString() + "</td><td></td></tr>";
                }



                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo_td_comprador'><h3>FRETE:</h3></td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";

                linha += "<tr><td class='auto-style7'>Frete ID: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.shipping.id != null ? r.shipping.id.ToString() : "[]") + "</td><td></td></tr>";


                if(r.shipping.status.Equals("ready_to_ship") || r.shipping.status.Equals("delivered")) {

                    linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.shipping.id != null ? "<a href='https://api.mercadolibre.com/shipment_labels?shipment_ids=" + r.shipping.id.ToString() + "&savePdf=Y&access_token=" + Session["aToken"].ToString() + "' target='_blank'><img src='Images/print_label.png'></a>" : "[]") + "</td><td></td></tr>";
                }


                linha += "<tr><td class='auto-style7'>Status do Frete: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.shipping.status != null ? r.shipping.status : "[]") + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Custo: </td><td class='auto-style6'></td><td class='td_conteudo'>" + r.shipping.cost.ToString() + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Endereço de Entrega: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.shipping.receiver_address != null ? r.shipping.receiver_address.address_line : "[]") + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Cidade: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.shipping.receiver_address != null ? r.shipping.receiver_address.city.name : "[]") + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Estado: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.shipping.receiver_address != null ? r.shipping.receiver_address.state.name : "[]") + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>CEP: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.shipping.receiver_address != null ? r.shipping.receiver_address.zip_code : "[]") + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Referência: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.shipping.receiver_address != null ? r.shipping.receiver_address.comment : "[]") + "</td><td></td></tr>";
                linha += "<tr><td class='auto-style7'>Tipo de Frete: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.shipping.shipment_type != null ? r.shipping.shipment_type : "[]") + "</td><td></td></tr>";

                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>TAGS:</td><td></td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";

                for(int k = 0; k < r.tags.Count; k++) {

                    linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>" + (r.tags != null ? r.tags[k].ToString() : "[]") + "</td><td></td></tr>";
                }

                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";


            }

            linha += "</table>";

            linha += "<center><div>";
            lblResultJSON.Text = linha;
            linha += "</div></center>";

        }

    }
}