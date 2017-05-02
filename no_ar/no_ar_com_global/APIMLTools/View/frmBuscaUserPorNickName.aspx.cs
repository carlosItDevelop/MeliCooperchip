﻿using System;
using System.Collections.Generic;
using Model;
using Model.BuscaIDPorNickName;
using Models.Perfil;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmBuscaUserPorNickName : System.Web.UI.Page {
        
        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void btnBuscar_Click(object sender, EventArgs e) {

            string linha = "";
            
            if(string.IsNullOrEmpty(txtBuscaPorApelido.Text)) {
                lblResultJSON.Text = "Campo de Busca é Obrigatório!";
                return;
            }

            // 1 - Instância da Auth
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());

            string code = Session["code"].ToString();

            var p = new RestSharp.Parameter { Name = "nickname", Value = txtBuscaPorApelido.Text };

            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);

            BuscaIDPorNickName idPorNick;
            string idNick;
            try {
                IRestResponse response = m.Get("/sites/MLB/search", ps);
                idPorNick = JsonConvert.DeserializeObject<BuscaIDPorNickName>(response.Content);
                idNick = idPorNick.seller.id.ToString();
            } catch(Exception ex) {
                lblResultJSON.Text = "USUÁRIO NÃO ENCONTRADO - Saída do compilador: [ " + ex.Message +" ]";
                return;
            }

            lblResultJSON.Text = "Código do Usuário: " + idNick;

            MostraDados(idNick, m, linha);

        }


        private void MostraDados(string vIdNick, Meli m, string linha) {

            var p = new RestSharp.Parameter();
            p.Name = "access_token";
            p.Value = m.AccessToken;

            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);

            string vUrl = "/users/" + vIdNick;

            Perfil perfil;
            try {
                IRestResponse response = m.Get(vUrl, ps);
                perfil = JsonConvert.DeserializeObject<Perfil>(response.Content);
            } catch(Exception ex) {
                lblResultJSON.Text = ex.Message;
                return;
            }



            linha += "<table id='tabletools' class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            linha += "<tbody>";
                linha += "<tr>";
                linha += "<td>Apelido</td>";
                linha += "<td>" + perfil.nickname + "</td>";
                    linha += "<td>&nbsp;</td>";
                    linha += "<td colspan='6' style='text-align: center'>TRANSAÇÕES</td>";
                linha += "</tr>";
                linha += "<tr>";
                    linha += "<td>User ID:</td>";
                    linha += "<td>" + perfil.id + "</td>";
                    linha += "<td>&nbsp;</td>";
                    linha += "<td colspan='2' style='text-align: center'>CONCRETIZADAS</td>";
                    linha += "<td colspan='2' style='text-align: center'>CANCELADAS</td>";
                    linha += "<td colspan='2' style='text-align: center'>TOTAL</td>";
                linha += "</tr>";
                linha += "<tr>";
                    linha += "<td>User Type:</td>";
                    linha += "<td>"+ perfil.user_type +"</td>";
                    linha += "<td>&nbsp;</td>";
                    linha += "<td colspan='2' style='text-align: center'>" + perfil.seller_reputation.transactions.completed + "</td>";
                    linha += "<td colspan='2' style='text-align: center'>" + perfil.seller_reputation.transactions.canceled + "</td>";
                    linha += "<td colspan='2' style='text-align: center'>" + perfil.seller_reputation.transactions.total + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                    linha += "<td>Cidade:</td>";
                    linha += "<td>" + perfil.address.city + "</td>";
                    linha += "<td>&nbsp;</td>";
                    linha += "<td colspan='6' style='text-align: center'>&nbsp;</td>";
                linha += "</tr>";
                linha += "<tr>";
                    linha += "<td>Estado:</td>";
                    linha += "<td>" + perfil.address.state + "</td>";
                    linha += "<td>&nbsp;</td>";
                    linha += "<td colspan='6'>&nbsp;</td>";
                linha += "</tr>";
                linha += "<tr>";
                    linha += "<td>Tipo de Usuário:</td>";
                    linha += "<td>" + perfil.user_type + "</td>";
                    linha += "<td>&nbsp;</td>";
                    linha += "<td colspan='6' style='text-align: center'>REPUTAÇÃO</td>";
                linha += "</tr>";
                linha += "<tr>";
                    linha += "<td></td>";
                    linha += "<td></td>";
                    linha += "<td>&nbsp;</td>";
                    linha += "<td style='text-align: center'>POSITIVAS</td>";
                    linha += "<td style='text-align: center'>NEUTRAS</td>";
                    linha += "<td style='text-align: center'>NEGATIVAS</td>";
                    linha += "<td style='text-align: center'>NÍVEL</td>";
                    linha += "<td style='text-align: center'>PERÍODO AVALIAÇÃO</td>";
                    linha += "<td style='text-align: center'>MEDALHA</td>";
                linha += "</tr>";
                linha += "<tr>";
                    linha += "<td>Pontos:</td>";
                    linha += "<td>" + perfil.points + "</td>";
                    linha += "<td>&nbsp;</td>";
                    linha += "<td style='text-align: center'>" + perfil.seller_reputation.transactions.ratings.positive.ToString("0.00") + "</td>";
                    linha += "<td style='text-align: center'>" + perfil.seller_reputation.transactions.ratings.neutral.ToString("0.00") + "</td>";
                    linha += "<td style='text-align: center'>" + perfil.seller_reputation.transactions.ratings.negative.ToString("0.00") + "</td>";
                    linha += "<td style='text-align: center'>" + perfil.seller_reputation.level_id + "</td>";
                    linha += "<td style='text-align: center'>" + perfil.seller_reputation.transactions.period + "</td>";
                    linha += "<td style='text-align: center'>" + perfil.seller_reputation.power_seller_status + "</td>";
                linha += "</tr>";
                linha += "<tr>";
                    linha += "<td>Status:</td>";
                    linha += "<td>" + perfil.status.site_status + "</td>";
                    linha += "<td>&nbsp;</td>";
                    linha += "<td colspan='6'>&nbsp;</td>";
                linha += "</tr>";
                linha += "<tr>";
                    linha += "<td>Data do Cadastro:</td>";
                    linha += "<td>" + Convert.ToDateTime(perfil.registration_date).ToShortDateString() + "</td>";
                    linha += "<td>&nbsp;</td>";
                    linha += "<td colspan='6'>Link: " + "<a href='" + perfil.permalink + "' target='_blank'>" + perfil.permalink + "</a>" + "</td>";
                linha += "</tr>";
                linha += "</tbody>";
            linha += "</table>";


            //try {
            //    linha += "Logo: " + "<img src='" + perfil.logo + "' /><br />";
            //} catch(Exception ex) {
            //} finally {
            //    linha += "Logo: " + "ERRO NA IMPRESSÃO DA LOGO." + "<br />";
            //}


            // ...  tem mais...


            linha += "<br /><hr />";

            lblResultJSON.Text += linha; 
        }

    }
}