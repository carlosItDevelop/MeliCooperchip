using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Models.PedidosPendentes;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmPedidosPendentes : System.Web.UI.Page {

        
        protected void Page_Load(object sender, EventArgs e) {

            

            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"].ToString();

            var p = new RestSharp.Parameter();
            p.Name = "seller";
            p.Value = ConfigurationManager.AppSettings["SELLER"].ToString();

            var p2 = new RestSharp.Parameter();
            p2.Name = "access_token";
            p2.Value = m.AccessToken;

            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);
            ps.Add(p2);

            string linha = "";
            //int qtde = 0;
            //int numRegPorPg = 0;
            //int numPag = 0;

            // https://api.mercadolibre.com/orders/search/pending?seller=59181149&access_token={..}



            IRestResponse response = m.Get("/orders/search/pending", ps);
            var pdPendentes = JsonConvert.DeserializeObject<PedidosPendentes>(response.Content);

            //lblResult.Text = response.Content;


            linha += "<table>";
            foreach(Result pd in pdPendentes.results) {
                linha += "<tr><td>Id do Pedido: </td><td>" + pd.id + "</td></tr>";

                foreach(OrderItem it in pd.order_items) {
                    linha += "<tr><td>código do Produto: </td><td>" + it.item.id + "</td></tr>";
                    linha += "<tr><td>Título do Produto: </td><td>" + it.item.title + "</td></tr>";
                    linha += "<tr><td>Categoria do Produto: </td><td>" + it.item.category_id + "</td></tr>";
                    linha += "<tr><td>Quantidade: </td><td>" + it.quantity + "</td></tr>";
                    linha += "<tr><td>Preço Unitário: </td><td>" + it.unit_price + "</td></tr>";
                }

                foreach(Payment pgto in pd.payments) {
                    linha += "<tr><td>ID do Pagamento: </td><td>" + pgto.id + "</td></tr>";
                    linha += "<tr><td>Tipo de Pagamento: </td><td>" + pgto.payment_method_id + "</td></tr>";
                    linha += "<tr><td>Forma de Pagamento: </td><td>" + pgto.payment_method_id + "</td></tr>";
                    linha += "<tr><td>Tipo de Operação: </td><td>" + pgto.operation_type + "</td></tr>";
                    linha += "<tr><td>URL do Pagamento: </td><td>" + pgto.activation_uri + "</td></tr>";
                    linha += "<tr><td>Status do Pagamento: </td><td>" + pgto.status + "</td></tr>";
                    linha += "<tr><td>Código da Transação: </td><td>" + pgto.status_code + "</td></tr>";
                    linha += "<tr><td>Detalhes do Pagamento: </td><td>" + pgto.status_detail + "</td></tr>";
                }


                linha += "<tr><td>Total do Pedido: </td><td>" + pd.total_amount + "</td></tr>";

                // Variação
                // Mediação


                linha += "<tr><td>Comentário do Pedido: </td><td>" + pd.comments + "</td></tr>";

                linha += "<tr><td>Hidden for Seller: </td><td>" + pd.hidden_for_seller + "</td></tr>";

                linha += "<tr><td>Data do Pedido: </td><td>" + pd.date_created + "</td></tr>";
                linha += "<tr><td>Data do fechamento: </td><td>" + pd.date_closed + "</td></tr>";
                linha += "<tr><td>Última Atualização: </td><td>" + pd.date_last_updated + "</td></tr>";

                linha += "<tr><td>Statud do Pedido: </td><td>" + pd.status +"</td></tr>";

                linha += "<tr><td colspan='2' style='background-color: grey;'></td></tr>";

                linha += "<tr><td>Id do Comprador: </td><td>" + pd.buyer.id +"</td></tr>";
                linha += "<tr><td>Nome do Comprador: </td><td>" + pd.buyer.first_name + " " + pd.buyer.last_name + "</td></tr>";
                linha += "<tr><td>Apelido do Comprador: </td><td>" + pd.buyer.nickname +"</td></tr>";
                linha += "<tr><td>e-Mail do Comprador: </td><td>" + pd.buyer.email +"</td></tr>";


                linha += "<tr><td>Código da Pendência: </td><td>" + pd.status_detail.code + "</td></tr>";
                linha += "<tr><td>Descriçãp da Pendência: </td><td>" + pd.status_detail.description + "</td></tr>";

                for(int k = 0; k < pd.tags.Count; k++) {
                    linha += "<tr><td>Tags ["+ (k+1) +"] : </td><td>" + pd.tags[k].ToString() + "</td></tr>";
                }

                linha += "<tr><td colspan='2' style='background-color: grey;'></td></tr>";
                linha += "<tr><td colspan='2' style='background-color: grey;'></td></tr>";
                linha += "<tr><td colspan='2' style='background-color: grey;'></td></tr>";
                linha += "<tr><td colspan='2' style='background-color: grey;'></td></tr>";
            }
            linha += "</table>";

            lblResultJSON.Text = linha;

            /*

          "payments": [
            {

              "currency_id": "BRL",

              "transaction_amount": 4555.45,
              "shipping_cost": 0,
              "overpaid_amount": 0,
              "total_paid_amount": 4555.45,
              "marketplace_fee": null,
              "coupon_amount": 0,
              "date_created": "2015-01-08T21:01:40.000-04:00",
              "date_last_modified": "2015-02-08T21:01:40.000-04:00",
              "card_id": null,
              "reason": "Notebook Intel Hp Computador J2m43la#ac4 14-v066br Core I7-",

              "issuer_id": null,
              "atm_transfer_reference": {
                "company_id": null,
                "transaction_id": null
              },
              "coupon_id": null,


              "available_actions": [
              ]
            }
          ],
          "shipping": {
            "substatus": null,
            "status": "to_be_agreed",
            "id": null,
            "service_id": null,
            "currency_id": null,
            "shipping_mode": null,
            "shipment_type": null,
            "sender_id": null,
            "picking_type": null,
            "date_created": null,
            "cost": null,
            "date_first_printed": null
          },

            },
            "alternative_phone": {
              "area_code": "21",
              "number": "3283-0009",
              "extension": null

          },
          "feedback": {
            "sale": null,
            "purchase": null
          },


            */


        }
    
    }
}