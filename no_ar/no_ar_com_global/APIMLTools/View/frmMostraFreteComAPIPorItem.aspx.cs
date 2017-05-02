using System;
using System.Collections.Generic;
using Model;
using Model.CalculadorDeFreteViaAPI;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmMostraFreteComApiPorItem : System.Web.UI.Page {



        
        protected void Page_Load(object sender, EventArgs e) {
            


            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());
            string code = Request["code"].ToString();

            /*
             * UTILIZANDO items
             */

            // https://api.mercadolibre.com/items/MLB598493587/shipping_options?zip_code=21765100 

            var p = new RestSharp.Parameter();
            p.Name = "zip_code";
            p.Value = "21765100";

            string vItem = "MLB598493587";    // Meu item pausado. Retorna datas estimadas = 01-01-1001; 
            //string vItem = "MLB645468962";  //  Anuncio do eShopSS. Retorna datas estimadas corretas;


            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);

            IRestResponse response = m.Get("/items/" + vItem + "/shipping_options", ps);
            var vCalcFrete = JsonConvert.DeserializeObject<CalculadorDeFreteViaAPI>(response.Content);



            //          lblResultJSON.Text = response.Content;

            txtCEPDestino.Text = vCalcFrete.destination.zip_code;

            txtEndereco.Text = vCalcFrete.destination.extended_attributes.address + "\nBairro: " + vCalcFrete.destination.extended_attributes.neighborhood + "\nUF/Cidade: " + vCalcFrete.destination.state.name + " / " + vCalcFrete.destination.city.name + "\nCEP: " + vCalcFrete.destination.zip_code;

            string linha = "";
            foreach(Option opt in vCalcFrete.options) {
                if(linha != "") {
                    linha += "\n-------------------------\n";
                }
                linha += "Tipo de Frete: " + opt.name;
                linha += "\nCusto: " + opt.cost;
                linha += "\nPrazo Estimado: " + Convert.ToDateTime((string) opt.estimated_delivery.date).ToShortDateString();
            }

            txtDetalhes.Text = linha;

        }
    
    
    }
}