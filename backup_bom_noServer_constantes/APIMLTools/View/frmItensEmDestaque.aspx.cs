using System;
using System.Collections.Generic;
using Model;
using Models.ProdutosDestaque1Pagina;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmItensEmDestaque : System.Web.UI.Page {

        

        protected void Page_Load(object sender, EventArgs e) {
            
        }
        protected void btnEnviar_Click(object sender, EventArgs e) {
            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"].ToString();

            string strResource = "";

            if(!cboCategoriasComQtde.Text.Equals("todas")) {
                strResource = "/sites/MLB/featured_items/HP-" + cboCategoriasComQtde.Text;
            } else {
                strResource = "/sites/MLB/featured_items/HP";
            }

            IRestResponse response = m.Get(strResource);

            List<ProdutosDestaque1Pagina> destaque = JsonConvert.DeserializeObject<List<ProdutosDestaque1Pagina>>(response.Content);


            /*  verificar o que falta mostrar!
             
                public class Picture
                {
                    public string id { get; set; }
                    public string url { get; set; }
                }

                public class RootObject
                {
                    public string item_id { get; set; }
                    public string title { get; set; }
                    public double price { get; set; }
                    public object original_price { get; set; }
                    public string currency_id { get; set; }
                    public string permalink { get; set; }
                    public Picture picture { get; set; }
                    public bool accepts_mercado_pago { get; set; }
                    public string category_id { get; set; }
                    public string pool_id { get; set; }
                    public int seller_id { get; set; }
                }             
             */



            string linha = "";

            linha += "<table align='center' class='auto-style1'>";

            linha += "<tr><td class='auto-style7'>Categoria: </td><td class='auto-style6'></td><td class='td_conteudo'>" + cboCategoriasComQtde.Text.ToUpper() + "</td></tr>";

            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
            linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";


            for(int k=0; k<destaque.Count; k++) {
                linha += "<tr><td class='auto-style7'>Categoria ID: </td><td class='auto-style6'></td><td class='td_conteudo'>" + destaque[k].category_id + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Item ID: </td><td class='auto-style6'></td><td class='td_conteudo'>" + destaque[k].item_id + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Título: </td><td class='auto-style6'></td><td class='td_conteudo'>" + destaque[k].title + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Preço: </td><td class='auto-style6'></td><td class='td_conteudo'>" + destaque[k].price.ToString("0.00") + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Link do Anúncio: </td><td class='auto-style6'></td><td class='td_conteudo'><a href='" + destaque[k].permalink + "' target='_blank'>" + destaque[k].permalink + "</a></td></tr>";


                linha += "<tr><td class='auto-style7'></td><td class='auto-style6'></td><td class='td_conteudo'>";
                    linha += "<div style='float: left; overflow: hidden; width: 250px; height: 250px; margin:10px; border: solid 1px #e1e1e1;'>";

                            linha += "<a href='" + destaque[k].permalink + "' target='_blank'>" + "<img src='" + destaque[k].picture.url + "' style='clip:rect(0px,250px,250px,0px); position: relative; top: 50%; left: 50%; margin-top: -125px; margin-left: -125px;' /></a>";
                
                    linha += "</div>";
                linha += "</td></tr>";
                

                linha += "<tr><td class='auto-style7'>Aceita Mercado Pago: </td><td class='auto-style6'></td><td class='td_conteudo'>" + (destaque[k].accepts_mercado_pago ? "[SIM]" : "[NÃO]") + "</td></tr>";
                linha += "<tr><td class='auto-style7'>Pool ID: </td><td class='auto-style6'></td><td class='td_conteudo'>" + destaque[k].pool_id + "</td></tr>";


                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";
                linha += "<tr><td class='auto-style11'></td><td class='auto-style11'></td><td class='auto-style11'></td></tr>";


            }

            linha += "</table>";


            lblResultJSON.Text = linha;

        
        }
    }
}