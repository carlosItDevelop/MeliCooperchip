using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Model.CalculadorDeFreteViaAPI;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmMostraFretePelasDimensoes : System.Web.UI.Page {

        
        protected void Page_Load(object sender, EventArgs e) {
            


            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());
            string code = Request["code"].ToString();

            /*
             * UTILIZANDO DIMENSIONS
             */

            // https://api.mercadolibre.com/sites/MLB/shipping_options?zip_code_from=21755080&zip_code_to=21765100&dimensions=11x16x24,20

            var p = new RestSharp.Parameter();
            p.Name = "zip_code_from";
            p.Value = ConfigurationManager.AppSettings["CEPORIGEM"];

            var p2 = new RestSharp.Parameter();
            p2.Name = "zip_code_to";
            p2.Value = "21765100";

            var p3 = new RestSharp.Parameter();
            p3.Name = "dimensions";
            p3.Value = "11x16x24,20";


            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);
            ps.Add(p2);
            ps.Add(p3);

            IRestResponse response = m.Get("/sites/MLB/shipping_options", ps);
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