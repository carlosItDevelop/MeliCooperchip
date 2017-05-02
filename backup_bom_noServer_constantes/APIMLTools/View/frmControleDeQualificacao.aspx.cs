using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Models.PedidosRecentes;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmControleDeQualificacao : System.Web.UI.Page {
        
        protected void Page_Load(object sender, EventArgs e) {
            
        }
        protected void btnEnviar_Click(object sender, EventArgs e) {

            // NÃO É ESTE RESOURCE //////////////////////////////////////////////////////////////////////////////////////////////////////


            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());
            string code = Request["code"].ToString();

            // https://api.mercadolibre.com/orders/search/recent?seller=59181149&access_token={...} 


            var p = new RestSharp.Parameter();
            p.Name = "seller";
            p.Value = ConfigurationManager.AppSettings["SELLER"].ToString();

            var p2 = new RestSharp.Parameter();
            p2.Name = "access_token";
            p2.Value = m.AccessToken;

            var p3 = new RestSharp.Parameter();
            if(cboStatus.Text.Equals("aguardandoqualificacao")) {
                // Filtro: Qualificados e Sem Qualificação do comprador!
                p3.Name = "feedback.status";
                p3.Value = "waiting_buyer";

            } else if(cboStatus.Text.Equals("aqualificar")) {
                // Filtro: Aguardo nosso feedback
                p3.Name = "feedback.status";
                p3.Value = "pending";
            }


            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);
            ps.Add(p2);
            // Se Não tiver sido selecionada todas adiciona o parametro 3;
            if(!cboStatus.Text.ToUpper().Equals("TODAS")) {
       //         ps.Add(p3);
            }

            IRestResponse response = m.Get("/orders/search/recent", ps);
            var pRecentes = JsonConvert.DeserializeObject<PedidosRecentes>(response.Content);

            string linha = "";


            int qtde = pRecentes.paging.total;
            int numRegPorPg = pRecentes.paging.limit;
            int numPag = 0;

            if(qtde % numRegPorPg == 0) {
                numPag = qtde / numRegPorPg;
            } else {
                numPag = (qtde / numRegPorPg) + 1;
            }


            linha += "<table align='center' >";

            linha += "<tr><td >Display: </td><td ></td><td >" + pRecentes.display + "</td></tr>";
            linha += "<tr><td >Limite: </td><td ></td><td >" + pRecentes.paging.limit + "</td></tr>";
            linha += "<tr><td >Registros: </td><td ></td><td >" + pRecentes.paging.total + "</td></tr>";
            linha += "<tr><td >Página Atual: </td><td ></td><td >" + (pRecentes.paging.offset + 1) + "</td></tr>";
            linha += "<tr><td >Qtde Páginas: </td><td ></td><td >" + numPag.ToString() + "</td></tr>";

            linha += "<tr><td ></td><td ></td><td ></td></tr>";
            linha += "<tr><td ></td><td ></td><td ></td></tr>";
            linha += "<tr><td ></td><td ></td><td ></td></tr>";

            string vStatus = "";
            string strQualify = "";


            for(int k = 0; k < pRecentes.results.Count; k++) {


                linha += "<tr><td >ID do Pedido: </td><td ></td><td >" + pRecentes.results[k].id.ToString() + "</td></tr>";

                linha += "<tr><td >Data do pedido: </td><td ></td><td >" + Convert.ToDateTime((string) pRecentes.results[k].date_created).ToShortDateString() + "</td></tr>";
                linha += "<tr><td >Data da Confirmação: </td><td ></td><td >" + Convert.ToDateTime((string) pRecentes.results[k].date_closed).ToShortDateString() + "</td></tr>";

                switch(pRecentes.results[k].status) {
                    case "confirmed":
                        vStatus = "Confirmado";
                        break;
                    case "payment_required":
                        vStatus = "Pagamento Necessário";
                        break;
                    case "payment_in_process":
                        vStatus = "Processando";
                        break;
                    case "paid":
                        vStatus = "Pago (A ser Creditado)";
                        break;
                    case "cancelled":
                        vStatus = "Cancelado";
                        break;
                    default:
                        vStatus = "[Não Consta]";
                        break;
                }


                linha += "<tr><td >Status: </td><td ></td><td >" + vStatus + "</td></tr>";
                linha += "<tr><td >(Cancelado) - Código: </td><td ></td><td >" + (pRecentes.results[k].status_detail != null ? pRecentes.results[k].status_detail.code : "[Não Consta]") + "</td></tr>";


                //    linha += "<tr><td >(Cancelado) - Detalhes: </td><td ></td><td >" + (pRecentes.results[k].status_detail.description != null ? pRecentes.results[k].status_detail.description.ToString() : "[Não Consta]") + "</td></tr>";



                linha += "<tr><td></td><td></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td class='td_conteudo_td_comprador'><h3>DADOS DO COMPRADOR:</h3></td></tr>";
                linha += "<tr><td></td><td></td><td ></td></tr>";

                linha += "<tr><td >ID do Comprador: </td><td ></td><td >" + pRecentes.results[k].buyer.id.ToString() + "</td></tr>";


                linha += "<tr><td >Apelido do Comprador: </td><td ></td><td >" + pRecentes.results[k].buyer.nickname + "</td></tr>";
                linha += "<tr><td >e-Mail: </td><td ></td><td >" + pRecentes.results[k].buyer.email + "</td></tr>";
                if(pRecentes.results[k].buyer.phone != null) {
                    linha += "<tr><td >Telefone (DDD): </td><td ></td><td >" + "(" + pRecentes.results[k].buyer.phone.area_code + ")" + "</td></tr>";
                    linha += "<tr><td >Telefone (Número): </td><td ></td><td >" + pRecentes.results[k].buyer.phone.number + "</td></tr>";
                }
                linha += "<tr><td >Nome Completo: </td><td ></td><td >" + pRecentes.results[k].buyer.first_name + " " + pRecentes.results[k].buyer.last_name + "</td></tr>";

                linha += "<tr><td></td><td></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td >INFORMAÇÕES DE FATURAMENTO:</td></tr>";
                linha += "<tr><td></td><td></td><td ></td></tr>";

                linha += "<tr><td >Tipo Documento: </td><td ></td><td >" + (pRecentes.results[k].buyer.billing_info != null ? pRecentes.results[k].buyer.billing_info.doc_type : "[Não Consta]") + "</td></tr>";
                linha += "<tr><td >Número do Documento: </td><td ></td><td >" + (pRecentes.results[k].buyer.billing_info != null ? pRecentes.results[k].buyer.billing_info.doc_number : "[Não Consta]") + "</td></tr>";


                linha += "<tr><td></td><td></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td >DADOS DO VENDEDOR:</td></tr>";
                linha += "<tr><td></td><td></td><td ></td></tr>";


                linha += "<tr><td >ID do Vendedor: </td><td ></td><td >" + pRecentes.results[k].seller.id.ToString() + "</td></tr>";
                linha += "<tr><td >Apelido do Vendedor: </td><td ></td><td >" + pRecentes.results[k].seller.nickname + "</td></tr>";
                linha += "<tr><td >e-Mail: </td><td ></td><td >" + pRecentes.results[k].seller.email + "</td></tr>";
                if(pRecentes.results[k].seller.phone != null) {
                    linha += "<tr><td >Telefone (DDD): </td><td ></td><td >" + pRecentes.results[k].seller.phone.area_code + "</td></tr>";
                    linha += "<tr><td >Telefone (Número): </td><td ></td><td >" + pRecentes.results[k].seller.phone.number + "</td></tr>";
                }
                linha += "<tr><td >Nome Completo: </td><td ></td><td >" + pRecentes.results[k].seller.first_name + " " + pRecentes.results[k].seller.last_name + "</td></tr>";


                linha += "<tr><td></td><td></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td >DADOS DO PEDIDO (ORDER):</td></tr>";
                linha += "<tr><td></td><td></td><td ></td></tr>";

                for(int j = 0; j < pRecentes.results[k].order_items.Count; j++) {


                    linha += "<tr><td >ID do Pedido: </td><td ></td><td ><a href='frmQualificarUsuarioAcao.aspx?order_id=" + pRecentes.results[k].id.ToString() + "&seller_id=" + pRecentes.results[k].seller.id.ToString() + "'>" + pRecentes.results[k].order_items[j].item.id + "</a></td></tr>";

                    linha += "<tr><td >Produto: </td><td ></td><td >" + pRecentes.results[k].order_items[j].item.title + "</td></tr>";

                }

                linha += "<tr><td></td><td></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td >DADOS DE PAGAMENTO:</td></tr>";
                linha += "<tr><td></td><td></td><td ></td></tr>";

                if(pRecentes.results[k].payments.Count > 0) {
                    for(int n = 0; n < pRecentes.results[k].payments.Count; n++) {


                        //     linha += "<tr><td >ID do Pagamento: </td><td ></td><td >" + pRecentes.results[k].payments[n].id.ToString() + "</td></tr>";
                        //   linha += "<tr><td >Status: </td><td ></td><td >" + "" + "</td></tr>";
                        //  linha += "<tr><td >Total da Transação: </td><td ></td><td >" + pgto.transaction_amount.ToString("0.00") + "</td></tr>";
                        //     linha += "<tr><td >Data do Pagamento: </td><td ></td><td >" + (pgto.date_created != null ? Convert.ToDateTime(pgto.date_created).ToShortDateString() : "[Não Cnsta]") + "</td></tr>";
                    }
                }



                linha += "<tr><td></td><td></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td >DADOS DE QUALIFICAÇÃO DO VENDEDOR:</td></tr>";
                linha += "<tr><td></td><td></td><td ></td></tr>";


                linha += "<tr><td >Data da Qualificação: </td><td ></td><td >" + (pRecentes.results[k].feedback.sale != null ? Convert.ToDateTime((string) pRecentes.results[k].feedback.sale.date_created).ToShortDateString() : "[Não Consta]") + "</td></tr>";

                strQualify = "";
                if(pRecentes.results[k].feedback.sale != null) {
                    switch(pRecentes.results[k].feedback.sale.rating) {
                        case "positive":
                            strQualify = "Positiva";
                            break;
                        case "neutral":
                            strQualify = "Neutra";
                            break;
                        case "negative":
                            strQualify = "Negativa";
                            break;
                        default:
                            strQualify = "Não Consta";
                            break;
                    }

                    linha += "<tr><td >Qualificação: </td><td ></td><td >" + strQualify + "</td></tr>";
                }

                linha += "<tr><td >Concretizada? </td><td ></td><td >" + (pRecentes.results[k].feedback.sale != null ? (pRecentes.results[k].feedback.sale.fulfilled == true ? "[Sim]" : "[Não]") : "[Não Consta]") + "</td></tr>";


                linha += "<tr><td></td><td></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td >DADOS DE QUALIFICAÇÃO DO COMPRADOR:</td></tr>";
                linha += "<tr><td></td><td></td><td ></td></tr>";


                linha += "<tr><td >Data da Qualificação: </td><td ></td><td >" + (pRecentes.results[k].feedback.purchase != null ? Convert.ToDateTime((string) pRecentes.results[k].feedback.purchase.date_created).ToShortDateString() : "[Não Consta]") + "</td></tr>";

                strQualify = "";
                if(pRecentes.results[k].feedback.purchase != null) {
                    switch(pRecentes.results[k].feedback.purchase.rating) {
                        case "positive":
                            strQualify = "Positiva";
                            break;
                        case "neutral":
                            strQualify = "Neutra";
                            break;
                        case "negative":
                            strQualify = "Negativa";
                            break;
                        default:
                            strQualify = "Não Consta";
                            break;
                    }

                    linha += "<tr><td >Qualificação: </td><td ></td><td >" + strQualify + "</td></tr>";
                }

                linha += "<tr><td >Concretizada? </td><td ></td><td >" + (pRecentes.results[k].feedback.purchase != null ? (pRecentes.results[k].feedback.purchase.fulfilled == true ? "[Sim]" : "[Não]") : "[Não Consta]") + "</td></tr>";



                linha += "<tr><td></td><td></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td >INFORMAÇÕES DE ENTREGA:</td></tr>";
                linha += "<tr><td></td><td></td><td ></td></tr>";

                vStatus = Util.GetTextoPtBR(pRecentes.results[k].shipping.status);

                linha += "<tr><td >Status: </td><td ></td><td >" + vStatus + "</td></tr>";
                linha += "<tr><td >Data da Criação: </td><td ></td><td >" + (pRecentes.results[k].shipping != null ? Convert.ToDateTime((string) pRecentes.results[k].shipping.date_created).ToShortDateString() : "[Não Consta]") + "</td></tr>";
                linha += "<tr><td >Custo do Frete: </td><td ></td><td >" + (pRecentes.results[k].shipping != null ? pRecentes.results[k].shipping.cost.ToString() : "[Não Consta]") + "</td></tr>";

                /*        
                 * receiver_address
                 * service_id
                 * date_first_printed
                 * 
                 */


                linha += "<tr><td></td><td></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td >RESUMO:</td></tr>";
                linha += "<tr><td></td><td></td><td ></td></tr>";

                linha += "<tr><td >Total do Pedido: </td><td ></td><td >" + pRecentes.results[k].total_amount.ToString("0.00") + "</td></tr>";

                ////--------------------------------------------------------------------------------------------------------------------------------------



                //if (r.listing_type_id.ToUpper().Equals("GOLD_PREMIUM"))
                //{
                //    vPublicidd = "[DIAMANTE]";
                //}
                //if (r.listing_type_id.ToUpper().Equals("GOLD"))
                //{
                //    vPublicidd = "[OURO]";
                //} if (r.listing_type_id.ToUpper().Equals("SILVER"))
                //{
                //    vPublicidd = "[PRATA]";
                //} if (r.listing_type_id.ToUpper().Equals("BRONZE"))
                //{
                //    vPublicidd = "[BRONZE]";
                //} if (r.listing_type_id.ToUpper().Equals("FREE"))
                //{
                //    vPublicidd = "[GRÁTIS]";
                //}



                linha += "<tr><td ></td><td ></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td ></td></tr>";
                linha += "<tr><td ></td><td ></td><td ></td></tr>";


            }


            linha += "<tr><td >Resource de Estatística: </td><td ></td><td ><a href='" + pRecentes.complete + "' target='_blank'>" + pRecentes.complete + "</a></td></tr>";

            linha += "<tr><td ></td><td ></td><td ></td></tr>";
            linha += "<tr><td ></td><td ></td><td ></td></tr>";
            linha += "<tr><td ></td><td ></td><td ></td></tr>";


            linha += "</table>";

            linha += "<center><div>";
            lblResultJSON.Text = linha;
            linha += "</div></center>";
        }
    }
}