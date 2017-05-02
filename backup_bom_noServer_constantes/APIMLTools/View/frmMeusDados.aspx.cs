using System;
using System.Collections.Generic;
using Model;
using Models.Usuario;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmMeusDados : System.Web.UI.Page {
        
        
        
        protected void Page_Load(object sender, EventArgs e) {
            

            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"];



            var p = new RestSharp.Parameter { Name = "access_token", Value = m.AccessToken };

            var ps = new List<RestSharp.Parameter> { p };

            IRestResponse response = m.Get("/users/me", ps);

            //  O ERRO ESTÁ AQUI, EM ALGUM LUGAR!!!
            //        var usuarios = JsonConvert.DeserializeObject<Usuario>(response.Content);
            Usuario r = JsonConvert.DeserializeObject<Usuario>(response.Content);

            string linha = "";

            linha += "<br /><hr />";

            linha += "<div style='padding=20px;margin=15px;border-type=solid;'><br />";
            linha += "ID Vendedor: " + r.id + "<br />";
            linha += "Apelido: " + r.nickname + "<br />";
            linha += "Data do Registro: " + r.registration_date + "<br />";
            linha += "Nome: " + r.first_name + "<br />";
            linha += "Sobrenome: " + r.last_name + "<br />";

            linha += "e-Mail " + r.email + "<br />";
            linha += "Endereço: " + r.address.address + "<br />";
            linha += "Cidade: " + r.address.city + "<br />";
            linha += "Estado: " + r.address.state + "<br />";
            linha += "DDD: " + r.phone.area_code + "<br />";
            linha += "Telefone: " + r.phone.number + "<br />";
            linha += "Tel. Verificado: " + (r.phone.verified ? "[Sim]" : "[Não]") + "<br />";
            linha += "Tel. Alternativo: " + "(" + r.alternative_phone.area_code + ") " + r.alternative_phone.number + "<br />";
            linha += "Tipo de Usuário: " + r.user_type + "<br />";
            linha += "Pontos: " + r.points + "<br />";
            linha += "Site ID: " + r.site_id + "<br />";
            linha += "Perfil: " + "<a href='" + r.permalink + "'>" + r.permalink + "</a><br />";
            linha += "Reputação: " + r.seller_reputation.level_id + "<br />";
            linha += "Transações Concretizadas: " + r.seller_reputation.transactions.completed + "<br />";
            linha += "Transações Canceladas: " + r.seller_reputation.transactions.canceled + "<br />";
            linha += "Total de Transações: " + r.seller_reputation.transactions.total + "<br />";
            linha += "Transações Período: " + r.seller_reputation.transactions.period + "<br />";
            linha += "Companhia: " + (r.company != null ? r.company.identification : "[]") + "<br />";
            linha += "Nível Crédito: " + r.credit.credit_level_id + "<br />";
            linha += "Crédito Consumido: " + r.credit.consumed.ToString("0.00") + "<br />";




            //public string country_id { get; set; }
            //public Identification identification { get; set; }
            //public Phone phone { get; set; }
            //public AlternativePhone alternative_phone { get; set; }
            //public List<string> tags { get; set; }
            //public object logo { get; set; }
            //public List<string> shipping_modes { get; set; }
            //public string seller_experience { get; set; }
            //public BuyerReputation buyer_reputation { get; set; }
            //public Status status { get; set; }
            //linha += "Endereço: " + r.address.zip_code + "<br />";


            linha += "</div><br />";

            linha += "<hr />";

            lblResultJSON.Text = linha;

        }
    }
}