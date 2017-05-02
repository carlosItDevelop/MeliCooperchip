using System;
using System.Collections.Generic;
using Model;
using Models.Pagamentos;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmHistoricoDePgtos : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnBuscaUsuario_Click(object sender, EventArgs e) {
            string linha = "";

            if(txtUsuario.Text.Length > 0) {


                // 1 - Instância da Auth
                Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

                string code = Request["code"];


                // Parâmetros: access_token, status = aprovaded, payment_type = ticket, limit = 3, offset = 10;

                var p = new RestSharp.Parameter { Name = "access_token", Value = m.AccessToken };
                // var p2 = new RestSharp.Parameter {Name = "status", Value = "approved"};
                // var p3 = new RestSharp.Parameter {Name = "payment_type", Value = "ticket"};
                var p4 = new RestSharp.Parameter { Name = "limit", Value = 50 };
                var p5 = new RestSharp.Parameter { Name = "offset", Value = 0 };


                // Exemplo de URL - Get de um pagamento com parâmetros diversos;
                // https://api.mercadolibre.com/collections/search?access_token={...}&status=cancelled&offset=10&limit=3'

                // var ps = new List<RestSharp.Parameter> {p, p2, p3, p4, p5};
                var ps = new List<RestSharp.Parameter> { p, p4, p5 };

                Pagamentos pagamentos;
                try {
                    IRestResponse response = m.Get("/collections/search", ps);
                    pagamentos = JsonConvert.DeserializeObject<Pagamentos>(response.Content);
                } catch(Exception ex) {
                    lblResultJSON.Text = ex.Message;
                    return;
                }

                long k = 0;
                linha += "Registros por Página: " + pagamentos.paging.limit + "<br />";
                linha += "Página Inicial: " + (pagamentos.paging.offset + 1) + "<br />";
                linha += "Total de Registros: " + pagamentos.paging.total + "<hr />";

                linha += "<table border='1'><tr style='background-color: grey;'><th>Registro</th><th>Apelido</th><th>Nome</th><th>Sobrenome</th>"
                  + "<th>DDD</th><th>Telefone</th><th>Status</th><th>Tipo Pgto</th>"
                  + "<th>Última Atualização</th><th>Tp. Operação</th></tr>";

                //+ "<td>Última Atualização</td><td>Tx MP</td><td>Net Receiver</td><td>Recebido</td><td>Frete</td><td>Tp. Operação</td>";


                foreach(Result r in pagamentos.results) {
                    linha += "<tr>";
                    k++;

                    if(r.collection.payer.nickname != null) {
                        if(txtUsuario.Text.ToUpper().Equals("TODOS") || r.collection.payer.nickname.ToUpper().Equals(txtUsuario.Text.ToUpper())) {
                            linha += "<td>" + k.ToString() + "</td>";
                            linha += "<td>" + r.collection.payer.nickname + "</td>";
                            linha += "<td>" + r.collection.payer.first_name + "</td>";
                            linha += "<td>" + r.collection.payer.last_name + "</td>";
                            linha += "<td>" + r.collection.payer.phone.area_code + "</td>";
                            linha += "<td>" + r.collection.payer.phone.number + "</td>";

                            string vStatus = Util.GetTextoPtBR(r.collection.status);


                            linha += "<td>" + vStatus + "</td>";

                            linha += "<td>" + r.collection.payment_type + "</td>";
                            linha += "<td>" + Convert.ToDateTime((string) r.collection.last_modified).ToShortDateString() + "</td>";


                            linha += "<td>" + r.collection.operation_type + "</td>";
                            linha += "</tr>";

                            linha += "<tr style='background-color: grey;'>";
                            linha += "<th colspan='3'>Total da Transação</th><th>Frete</th>";
                            linha += "<th colspan='2'>Total Pago</th><th>Com Espécie</th>";
                            linha += "<th>Tx MercadoPago</th><th colspan='2'>Líquido Recebido</th>";
                            linha += "</tr>";

                            linha += "<tr>";
                            linha += "<td colspan='3'>" + r.collection.transaction_amount.ToString("0.00") + "</td>";
                            linha += "<td>" + r.collection.shipping_cost + "</td>";
                            linha += "<td colspan='2'>" + r.collection.total_paid_amount + "</td>";
                            linha += "<td>" + r.collection.account_money_amount + "</td>";
                            linha += "<td>" + r.collection.mercadopago_fee + "</td>";
                            linha += "<td colspan='2'>" + r.collection.net_received_amount + "</td>";
                            linha += "</tr>";

                            linha += "<tr>";
                            linha += "<td colspan='3'>email: " + r.collection.payer.email + "</td>";
                            linha += "<td colspan='4'>Objeto do Pgto: " + r.collection.reason + "</td>";
                            linha += "<td colspan='3'>Status do Pagamento: " + r.collection.status_detail +"</td>";
                            linha += "</tr>";
                            linha += "<td colspan='3'>Descritor: " + r.collection.statement_descriptor + "</td>";
                            linha += "<td colspan='4'>Marketplace: " + r.collection.marketplace +"</td>";
                            linha += "<td colspan='3'>Tx Marketplace: " +  r.collection.marketplace_fee + "</td>";
                            linha += "</tr>";


                        }
                    }
                    linha += "</tr>";
                }
                linha += "</table>";

            } else { linha = "CAMPO USUÁRIO É OBRIGATÓRIO OU DIGITE TODOS"; }

            //lblResultJSON.Text = pagamentos.results[0].collection.payer.nickname.ToString();
            lblResultJSON.Text = "<br />" + linha;


        }
   
    }
}