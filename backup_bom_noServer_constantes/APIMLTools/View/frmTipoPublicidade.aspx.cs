using System;
using System.Collections.Generic;
using Model;
using Models;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmTipoPublicidade : System.Web.UI.Page {


        

        protected void Page_Load(object sender, EventArgs e) {
            

            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"];


            IRestResponse response = m.Get("/sites/MLB/listing_types");
            var publicidade = JsonConvert.DeserializeObject<List<TipoPublicidade>>(response.Content);

            string linha = "";

            linha += "<table align='center' class='auto-style1'>";

            linha += "<tr><td class='auto-style7'>Lista: </td><td class='auto-style6'></td><td class='td_conteudo'>Tipo de Publicidade</td></tr>";

            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";


            for(int k = 0; k < publicidade.Count; k++) {

                // Desnecessário:  linha += "<tr><td class='auto-style7'>Site ID: </td><td class='auto-style6'></td><td class='td_conteudo'>" + publicidade[k].site_id + "</td></tr>";
                linha += "<tr><td class='auto-style7'>ID: </td><td class='auto-style6'></td><td class='td_conteudo'>" + publicidade[k].id + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Nome: </td><td class='auto-style6'></td><td class='td_conteudo'>" + publicidade[k].name + "</td></tr>";


                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";

            }

            linha += "</table>";

            linha += "<center><div>";
            lblResultJSON.Text = linha;
            linha += "</div></center>";
        }    
    
    }
}