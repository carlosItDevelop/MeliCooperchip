using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Models.Resumo;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmResumo : System.Web.UI.Page {

        
        protected void Page_Load(object sender, EventArgs e) {
            
            if(!IsPostBack) {
                // 1 - Instância da Auth
                Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

                string code = Request["code"];

                // https://api.mercadolibre.com/orders/search/recent/facets?seller=59181149&access_token={...}   

                var p = new RestSharp.Parameter { Name = "seller", Value = ConfigurationManager.AppSettings["SELLER"].ToString() };
                var p2 = new RestSharp.Parameter { Name = "access_token", Value = m.AccessToken };
                var ps = new List<RestSharp.Parameter> { p, p2 };

                IRestResponse response = m.Get("/orders/search/recent/facets", ps);
                var pResumo = JsonConvert.DeserializeObject<Resumo>(response.Content);

                string linha = "";

                int qtde = pResumo.paging.total;

                linha += "<table align='center' class='auto-style1'>";

                linha += "<tr><td class='auto-style7'>Total: </td><td class='auto-style6'></td><td class='td_conteudo'>" + qtde+ "</td><td></td></tr>";

                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";

                string vHeader = "";
                string vBody = "";


                foreach(AvailableFilter af in pResumo.available_filters) {

                    switch(af.id) {
                        case "order.status":
                            vHeader = "STATUS";
                            break;
                        case "feedback.sale.rating":
                            vHeader = "QUALIFIÇÃO DE VENDEDORES";
                            break;
                        case "feedback.purchase.rating":
                            vHeader = "QUALIFICAÇÕES DE COMPRADORES";
                            break;
                        case "shipping.status":
                            vHeader = "STATUS DE ENVIO";
                            break;
                        case "shipping.service_id":
                            vHeader = "SERVIÇO DE TRANSPORTE";
                            break;
                        case "feedback.status":
                            vHeader = "STATUS DAS QUALIFICAÇÕES";
                            break;
                        case "tags":
                            vHeader = "TAGS";
                            break;
                        default:
                            vHeader = "[]";
                            break;

                    }
                    linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
                    linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>"+ vHeader +"</td><td></td></tr>";
                    linha += "<tr><td></td><td></td><td class='auto-style11'></td><td></td></tr>";

                    for(int k=0; k< af.values.Count; k++) {

                        switch(af.values[k].id.ToString()) {
                            case "confirmed":
                                vBody = "Confirmado:";
                                break;
                            case "payment_required":
                                vBody = "Pagamento Necessário:";
                                break;
                            case "payment_in_process":
                                vBody = "Processando:";
                                break;
                            case "paid":
                                vBody = "PAGO (A ser Creditado):";
                                break;
                            case "cancelled":
                                vBody = "Cancelado:";
                                break;
                            case "negative":
                                vBody = "Negativo:";
                                break;
                            case "neutral":
                                vBody = "Neutro:";
                                break;
                            case "positive":
                                vBody = "Positivo:";
                                break;
                            case "to_be_agreed":
                                vBody = "A Ser Aprovado:";
                                break;


                            case "63":
                                vBody = "Standart:";
                                break;
                            case "64":
                                vBody = "Prioritário:";
                                break;
                            case "62":
                                vBody = "Prioritário:";
                                break;
                            case "81":
                                vBody = "MotoBoy:";
                                break;
                            case "61":
                                vBody = "Standart:";
                                break;
                            case "52":
                                vBody = "Prioritário:";
                                break;

                            case "73":
                                vBody = "Retirada:";
                                break;
                            case "1":
                                vBody = "PAC:";
                                break;
                            case "2":
                                vBody = "Sedex:";
                                break;
                            case "51":
                                vBody = "Standart:";
                                break;




                            case "pending":

                                if(af.id[k].ToString() == "feedback.status") {
                                    vBody = "À Espera de Seu Retorno:";
                                } else { vBody = "Pendente"; }
                                break;
                            case "waiting_buyer":
                                vBody = "Esperando Retorno do Comprador:";
                                break;
                            case "waiting_seller":
                                vBody = vBody = "Esperando Feedback do Vendedor:";
                                break;

                            case "shipped":
                                vBody = "Enviado:";
                                break;
                            case "delivered":
                                vBody = "Entregue:";
                                break;
                            case "ready_to_ship":
                                vBody = "Pronto para Enviar:";
                                break;
                            case "not_delivered":
                                vBody = "Não Entregue:";
                                break;
                            case "handling":
                                vBody = "Sendo Expedido:";
                                break;
                            case "not_verified":
                                vBody = "Não Verificado:";
                                break;

                            case "not_paid":
                                vBody = "Não Pago:";
                                break;
                            case "claim_closed":
                                vBody = "Reclamações Encerradas:";
                                break;
                            case "claim_opened":
                                vBody = "Reclamações Abertas:";
                                break;
                            case "not_processed":
                                vBody = "Não Processadas:";
                                break;
                            case "processed":
                                vBody = "Pedidos Processados:";
                                break;
                            default:
                                vBody = "[]";
                                break;


                        }



                        //if ((af.id[k].ToString() == "feedback.status") && af.values[k].id.ToString() == "waiting_buyer") { vBody = "À Espera de Retorno do Comprador"; }
                        //if ((af.id[k].ToString() == "feedback.status") && af.values[k].id.ToString() == "waiting_seller") { vBody = "Esperando Feedback do Vendedor"; }

                        linha += "<tr><td class='auto-style7'>" + vBody + ": " + "</td><td class='auto-style6'></td><td class='td_conteudo'>" + af.values[k].results.ToString() + "</td><td></td></tr>";
                    }

                }

                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td><td></td></tr>";


                linha += "</table>";

                linha += "<center><div>";
                lblResultJSON.Text = linha;
                linha += "</div></center>";


            }
        }

    
    }
}