using System;
using System.Collections.Generic;
using Model;
using Models.QualificacaoFeitaERecebida;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmQualificacaoFeitaERecebida : System.Web.UI.Page {


        
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e) {
            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"];

            var p = new RestSharp.Parameter { Name = "access_token", Value = m.AccessToken };
            var ps = new List<RestSharp.Parameter> { p };

            // https://api.mercadolibre.com/orders/{order_id}/feedback?access_token={...} 

            QualificacaoFeitaERecebida feedback;
            try {
                IRestResponse response = m.Get("/orders/" + txtQualifyForOrder.Text.Trim()+ "/feedback", ps);
                feedback = JsonConvert.DeserializeObject<QualificacaoFeitaERecebida>(response.Content);
            } catch(Exception ex) {
                lblResultJSON.Text = ex.Message;
                return;
            }

            string linha = "";

            linha += "<table>";

            linha += "<tr><td>Pedido ID: </td><td></td><td>" + txtQualifyForOrder.Text.ToUpper() + "</td></tr>";

            if(feedback != null) {

                linha += "<tr><td></td><td></td><td></td></tr>";
                linha += "<tr><td></td><td></td><td></td></tr>";
                linha += "<tr><td></td><td></td><td></td></tr>";

                linha += "<tr><td></td><td></td><td>NOSSA QUALICAÇÃO:</td></tr>";
                linha += "<tr><td></td><td></td><td></td></tr>";



                linha += "<tr><td>Pedido ID: </td><td></td><td>" + feedback.sale.item_id + "</td></tr>";

                if(feedback.sale.fulfilled) {
                    linha += "<tr><td>Você Qualificou Como: </td><td></td><td>" + feedback.sale.rating + "</td></ tr>";
                } else {
                    linha += "<tr><td></td><td></td><td>[NÃO QUALIFICADO POR VOCÊ]</td></tr>";
                }

                linha += "<tr><td>Justificativa: </td><td></td><td>" + (feedback.sale.reason != null ? feedback.sale.reason.ToString() : "[]") + "</td></tr>";
                linha += "<tr><td>Mensagem: </td><td></td><td>" + (!string.IsNullOrEmpty(feedback.sale.message) ? feedback.sale.message : "[]") + "</td></tr>";
                linha += "<tr><td>Réplica: </td><td></td><td>" + (feedback.sale.reply != null ? feedback.sale.reply.ToString() : "[]") + "</td></tr>";
                linha += "<tr><td>Data: </td><td></td><td>" + Convert.ToDateTime((string) feedback.sale.date_created).ToShortDateString() + "</td></ tr>";


                linha += "<tr><td></td><td></td><td></td></tr>";
                linha += "<tr><td></td><td></td><td>QUALIFICAÇÃO DO CLIENTE:</td></tr>";
                linha += "<tr><td></td><td></td><td></td></tr>";

                linha += "<tr><td>Pedido ID: </td><td></td><td>" + feedback.purchase.item_id + "</td></tr>";

                if(feedback.purchase.fulfilled) {
                    linha += "<tr><td>Você Qualificou Como: </td><td></td><td>" + feedback.purchase.rating + "</td></ tr>";
                } else {
                    linha += "<tr><td></td><td></td><td>[NÃO QUALIFICADO POR VOCÊ]</td></tr>";
                }

                linha += "<tr><td>Justificativa: </td><td></td><td>" + (feedback.purchase.reason != null ? feedback.purchase.reason.ToString() : "[]") + "</td></tr>";
                linha += "<tr><td>Mensagem: </td><td></td><td>" + (!string.IsNullOrEmpty(feedback.purchase.message) ? feedback.purchase.message : "[]") + "</td></tr>";
                linha += "<tr><td>Réplica: </td><td></td><td>" + (feedback.purchase.reply != null ? feedback.purchase.reply.ToString() : "[]") + "</td></tr>";
                linha += "<tr><td>Data: </td><td></td><td>" + Convert.ToDateTime((string) feedback.purchase.date_created).ToShortDateString() + "</td></ tr>";

                linha += "<tr><td></td><td></td><td></td></tr>";
                linha += "<tr><td></td><td></td><td></td></tr>";
                linha += "<tr><td></td><td></td><td></td></tr>";

            } else {
                linha += "<tr><td></td><td></td><td></td></tr>";
                linha += "<tr><td></td><td></td><td></td></tr>";
                linha += "<tr><td colspan='3' align'center'>VOCÊ AINDA NÃO QUALIFICOU ESTE PEDIDO!</td></tr>";
            }



            linha += "</table>";

            linha += "<center><div>";
            lblResultJSON.Text = linha;
            linha += "</div></center>";
        }
    
    
    }
}