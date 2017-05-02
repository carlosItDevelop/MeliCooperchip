using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Models.PedidosRecentes;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmPedidosRecentes : System.Web.UI.Page {
        
        protected void Page_Load(object sender, EventArgs e) {
            
        
            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"];

            // https://api.mercadolibre.com/orders/search/recent?seller=59181149&access_token={...} 

            var p = new RestSharp.Parameter();
            p.Name = "seller";
            p.Value = ConfigurationManager.AppSettings["SELLER"].ToString();

            var p2 = new RestSharp.Parameter();
            p2.Name = "access_token";
            p2.Value = m.AccessToken;

            //var p3 = new RestSharp.Parameter();
            //p3.Name = "";
            //p3.Value = "";

            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);
            ps.Add(p2);
            //    ps.Add(p3);

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


            linha += "<table align='center' class='auto-style1'>";

            linha += "<tr><td class='auto-style7'>Display: </td><td class='auto-style6'></td><td class='td_conteudo'>" + pRecentes.display + "</td></tr>";
            linha += "<tr><td class='auto-style7'>Limite: </td><td class='auto-style6'></td><td class='td_conteudo'>" + pRecentes.paging.limit + "</td></tr>";
            linha += "<tr><td class='auto-style7'>Registros: </td><td class='auto-style6'></td><td class='td_conteudo'>" + pRecentes.paging.total + "</td></tr>";
            linha += "<tr><td class='auto-style7'>Página Atual: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (pRecentes.paging.offset + 1) + "</td></tr>";
            linha += "<tr><td class='auto-style7'>Qtde Páginas: </td><td class='auto-style6'></td><td class='td_conteudo'>" + numPag.ToString() + "</td></tr>";

            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";



            foreach(Result result in pRecentes.results){
                linha += "<tr><td class='auto-style7'>ID do Pedido: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.id.ToString() + "</td></tr>";

                linha += "<tr><td class='auto-style7'>Data do pedido: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Convert.ToDateTime((string) result.date_created).ToShortDateString() + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Data da Confirmação: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Convert.ToDateTime((string) result.date_closed).ToShortDateString() + "</td></tr>";



                linha += "<tr><td class='auto-style7'>Status: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Util.GetTextoPtBR(result.status) + "</td></tr>";
                linha += "<tr><td class='auto-style7'>(Cancelado) - Código: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (result.status_detail != null ? result.status_detail.code : "[Não Consta]") + "</td></tr>";


                //    linha += "<tr><td class='auto-style7'>(Cancelado) - Detalhes: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (result.status_detail.description != null ? result.status_detail.description.ToString() : "[Não Consta]") + "</td></tr>";



                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo_td_comprador'><h3>DADOS DO COMPRADOR:</h3></td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";

                linha += "<tr><td class='auto-style7'>ID do Comprador: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.buyer.id.ToString() + "</td></tr>";


                linha += "<tr><td class='auto-style7'>Apelido do Comprador: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.buyer.nickname + "</td></tr>";
                linha += "<tr><td class='auto-style7'>e-Mail: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.buyer.email + "</td></tr>";
                if(result.buyer.phone != null) {
                    linha += "<tr><td class='auto-style7'>Telefone (DDD): </td><td class='auto-style6'></td><td class='td_conteudo'>" + "(" + result.buyer.phone.area_code + ")" + "</td></tr>";
                    linha += "<tr><td class='auto-style7'>Telefone (Número): </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.buyer.phone.number + "</td></tr>";
                }
                linha += "<tr><td class='auto-style7'>Nome Completo: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.buyer.first_name + " " + result.buyer.last_name + "</td></tr>";

                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>INFORMAÇÕES DE FATURAMENTO:</td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";

                linha += "<tr><td class='auto-style7'>Tipo Documento: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (result.buyer.billing_info != null ? result.buyer.billing_info.doc_type : "[Não Consta]") + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Número do Documento: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (result.buyer.billing_info != null ? result.buyer.billing_info.doc_number : "[Não Consta]") + "</td></tr>";


                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>DADOS DO VENDEDOR:</td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";


                linha += "<tr><td class='auto-style7'>ID do Vendedor: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.seller.id.ToString() + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Apelido do Vendedor: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.seller.nickname + "</td></tr>";
                linha += "<tr><td class='auto-style7'>e-Mail: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.seller.email + "</td></tr>";
                if(result.seller.phone != null) {
                    linha += "<tr><td class='auto-style7'>Telefone (DDD): </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.seller.phone.area_code + "</td></tr>";
                    linha += "<tr><td class='auto-style7'>Telefone (Número): </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.seller.phone.number + "</td></tr>";
                }
                linha += "<tr><td class='auto-style7'>Nome Completo: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.seller.first_name + " " + result.seller.last_name + "</td></tr>";


                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>DADOS DO PEDIDO (ORDER):</td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";

                for(int j = 0; j < result.order_items.Count; j++) {


                    linha += "<tr><td class='auto-style7'>ID do Pedido: </td><td class='auto-style6'></td><td class='td_conteudo'><a href='frmQualificarUsuarioAcao.aspx?order_id=" + result.id.ToString() + "&seller_id=" + result.seller.id.ToString() + "'>" + result.order_items[j].item.id + "</a></td></tr>";

                    linha += "<tr><td class='auto-style7'>Produto: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.order_items[j].item.title + "</td></tr>";

                }

                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>DADOS DE PAGAMENTO:</td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";



                    //for(int n = 0; n < result.payments.Count; n++) {

                    //    linha += "<tr><td class='auto-style7'>ID do Pagamento: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.payments.[n].id.ToString() + "</td></tr>";
                    //    linha += "<tr><td class='auto-style7'>Status: </td><td class='auto-style6'></td><td class='td_conteudo'>" + "" + "</td></tr>";
                    //    linha += "<tr><td class='auto-style7'>Total da Transação: </td><td class='auto-style6'></td><td class='td_conteudo'>" + pgto.transaction_amount.ToString("0.00") + "</td></tr>";
                    //    linha += "<tr><td class='auto-style7'>Data do Pagamento: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (pgto.date_created != null ? Convert.ToDateTime(pgto.date_created).ToShortDateString() : "[Não Cnsta]") + "</td></tr>";
                    //}



                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>DADOS DE QUALIFICAÇÃO DO VENDEDOR:</td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";


                linha += "<tr><td class='auto-style7'>Data da Qualificação: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (result.feedback.sale != null ? Convert.ToDateTime((string) result.feedback.sale.date_created).ToShortDateString() : "[Não Consta]") + "</td></tr>";

                if(result.feedback.sale != null) {

                    linha += "<tr><td class='auto-style7'>Qualificação: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Util.GetTextoPtBR(result.feedback.sale.rating) + "</td></tr>";
                }

                linha += "<tr><td class='auto-style7'>Concretizada? </td><td class='auto-style6'></td><td class='td_conteudo'>" + (result.feedback.sale != null ? (result.feedback.sale.fulfilled == true ? "[Sim]" : "[Não]") : "[Não Consta]") + "</td></tr>";


                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>DADOS DE QUALIFICAÇÃO DO COMPRADOR:</td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";


                linha += "<tr><td class='auto-style7'>Data da Qualificação: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (result.feedback.purchase != null ? Convert.ToDateTime((string) result.feedback.purchase.date_created).ToShortDateString() : "[Não Consta]") + "</td></tr>";

                if(result.feedback.purchase != null) {

                    linha += "<tr><td class='auto-style7'>Qualificação: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Util.GetTextoPtBR(result.feedback.purchase.rating) + "</td></tr>";
                }

                linha += "<tr><td class='auto-style7'>Concretizada? </td><td class='auto-style6'></td><td class='td_conteudo'>" + (result.feedback.purchase != null ? (result.feedback.purchase.fulfilled == true ? "[Sim]" : "[Não]"): "[Não Consta]") + "</td></tr>";



                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>INFORMAÇÕES DE ENTREGA:</td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";

                linha += "<tr><td class='auto-style7'>Status: </td><td class='auto-style6'></td><td class='td_conteudo'>" + Util.GetTextoPtBR(result.shipping.status) + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Data da Criação: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (result.shipping != null ?  Convert.ToDateTime((string) result.shipping.date_created).ToShortDateString() : "[Não Consta]") + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Custo do Frete: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (result.shipping != null ?  result.shipping.cost.ToString() : "[Não Consta]") + "</td></tr>";

                /*        
                 * receiver_address
                 * service_id
                 * date_first_printed
                 * 
                 */


                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>RESUMO:</td></tr>";
                linha += "<tr><td></td><td></td><td class='auto-style11'></td></tr>";

                linha += "<tr><td class='auto-style7'>Total do Pedido: </td><td class='auto-style6'></td><td class='td_conteudo'>" + result.total_amount.ToString("0.00") + "</td></tr>";

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



                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";


            }


            linha += "<tr><td class='auto-style7'>Resource de Estatística: </td><td class='auto-style6'></td><td class='td_conteudo'><a href='" + pRecentes.complete + "' target='_blank'>" + pRecentes.complete + "</a></td></tr>";

            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";


            linha += "</table>";

            linha += "<center><div>";
            lblResultJSON.Text = linha;
            linha += "</div></center>";

        }
    }
}