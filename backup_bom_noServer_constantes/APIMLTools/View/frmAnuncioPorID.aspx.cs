using System;
using System.Collections.Generic;
using Model;
using Models.AnuncioEspecifico;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmAnuncioPorId : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            if(string.IsNullOrEmpty(txtItemsId.Text)) {

                if(!string.IsNullOrEmpty(Request["items"])) {
                    GetDados(Request["items"]);
                }

            } else {
                GetDados(txtItemsId.Text);
            }

        }

        protected void btnBuscaAnuncio_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(txtItemsId.Text)){
                lblResultJSON.Text = "ID Obrigatório!";
                return;
            } else {
                GetDados(txtItemsId.Text);
            }
        }

        private void GetDados(string vItems) {
            // 1 - Instância da Auth
            var m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            var p = new RestSharp.Parameter();
            p.Name = "access_token";
            p.Value = m.AccessToken;

            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);

            string linha = "";

            if(string.IsNullOrEmpty(Request["items"]) && string.IsNullOrEmpty(txtItemsId.Text)) {
                linha += "<br /><hr />";
                linha += "ID DO PRODUTO É OBRIGATÓRIO";
                linha += "<br /><hr />";
                lblResultJSON.Text = linha;
                return;
            }

            string vUrl = "/items/" + vItems;

            AnuncioEspecifico anuncioespecifico;
            try {
                IRestResponse response = m.Get(vUrl, ps);
                anuncioespecifico = JsonConvert.DeserializeObject<AnuncioEspecifico>(response.Content);
            } catch(Exception ex) {
                lblResultJSON.Text = ex.Message;
                return;
            }
            string nick = "[]";

            linha += "<br /><hr />";

            linha += "ID: " + anuncioespecifico.id + "<br />";
            linha += "Site ID: " + anuncioespecifico.site_id + "<br />";
            linha += "Título: " + anuncioespecifico.title + "<br />";


         //   linha += "Subtítulo: " + (anuncioespecifico.subtitle ?? "[]") + "<br />";  // Verificar resultado impresso!

            linha += "ID Vendedor: " + anuncioespecifico.seller_id.ToString() +"<br />";

            nick = Util.GetNick(anuncioespecifico.seller_id, m);

            linha += "<hr />Apelido: " + nick.ToUpper() + "<hr />";

            linha += "ID Categoria: " + anuncioespecifico.category_id + "<br />";
            linha += "Preço: " + anuncioespecifico.price.ToString("0.00") + "<br />";
            linha += "Preço Base: " + anuncioespecifico.base_price.ToString("0.00") + "<br />"; 
            linha += "ID Moeda: " + anuncioespecifico.currency_id + "<br />";
            linha += "Quantidade Anunciada: " + anuncioespecifico.initial_quantity.ToString() +"<br />";
            linha += "Quantidade Disponível: " + anuncioespecifico.available_quantity.ToString() + "<br />";
            linha += "Quantidade de Ofertas: " + anuncioespecifico.sold_quantity.ToString() + "<br />";
            linha += "Modalidade: " + (anuncioespecifico.buying_mode == "buy_it_now" ? "Compre Já" : "[]") + "<br />";
            //"listing_type_id": "gold_premium",
            linha += "Garantia: " + anuncioespecifico.warranty + "<br />";
            linha += "Data da Publicação: " + Convert.ToDateTime(anuncioespecifico.start_time).ToShortDateString() + "<br />";
            linha += "Data do Vencimento: " + Convert.ToDateTime(anuncioespecifico.stop_time).ToShortDateString() + "<br />";
            linha += "Condições do Produto: " + (anuncioespecifico.condition == "new" ? "NOVO" : "[]") + "<hr />";

            linha += "Perfil: " + "<a href=" + anuncioespecifico.permalink + " target='_blank'>" + anuncioespecifico.permalink + "</a>" + "<hr />";

            linha += "Data da Criação: " + Convert.ToDateTime(anuncioespecifico.date_created).ToShortDateString() + "<br />";
            linha += "Última Atualização: " + Convert.ToDateTime(anuncioespecifico.last_updated).ToShortDateString() + "<br />";


         linha += "Foto:<br />";
        
         // Sem altura (height) para manter a proporção;
         linha += "<a href=" + anuncioespecifico.permalink + " target='_blank'><img src='" + anuncioespecifico.thumbnail + "' width='400' /></a>" + "<br />";
            if(anuncioespecifico.pictures.Count > 0) {
                linha += "Mais fotos: <br />";
                // Sem largura (width) para manter a proporção;
                foreach(Models.AnuncioEspecifico.Picture img in anuncioespecifico.pictures) {
                    linha += "<img src='" + img.url + "' height='80' />";
                }
            }




            /*        
                                                                                                              
                    "secure_thumbnail": "https://www.mercadolibre.com/jm/img?s=MLB&v=I&f=4437516153_062013.jpg",
                    "pictures": - [
                      - {
                        "id": "MLB4437516153_062013",
                        "url": "http://img1.mlstatic.com/s_MLB_v_O_f_4437516153_062013.jpg",
                        "secure_url": "https://www.mercadolibre.com/jm/img?s=MLB&v=O&f=4437516153_062013.jpg",
                        "size": "500x500",
                        "max_size": "900x900",
                        "quality": "",
                      },
                      - {
                        "id": "MLB4437539357_062013",
                        "url": "http://img2.mlstatic.com/s_MLB_v_O_f_4437539357_062013.jpg",
                        "secure_url": "https://www.mercadolibre.com/jm/img?s=MLB&v=O&f=4437539357_062013.jpg",
                        "size": "500x280",
                        "max_size": "900x505",
                        "quality": "",
             * 
             * 
             * JÁ UTILIZEI ESTA PARTE AQUI EM CIMA... VER SE DÁ PARA EXPLORAR MAIS...
             * 
             * 
                      },
                    ],
                    "video_id": null,
                    "descriptions": - [
                      - {
                        "id": "MLB489084753-407955619",
                      },
                    ],
                    "accepts_mercadopago": true,
                    "non_mercado_pago_payment_methods": [
                    ],
                    "shipping": - {
                      "profile_id": null,
                      "mode": "me2",
                      "local_pick_up": false,
                      "free_shipping": false,
                      "methods": [
                      ],
                      "dimensions": null,
                    },
                    "seller_address": - {
                      "id": 101377608,
                      "comment": "",
                      "address_line": "",
                      "zip_code": "",
                      "city": - {
                        "id": "",
                        "name": "Rio de Janeiro",
                      },
                      "state": - {
                        "id": "BR-RJ",
                        "name": "Rio de Janeiro",
                      },
                      "country": - {
                        "id": "BR",
                        "name": "Brasil",
                      },
                      "latitude": "",
                      "longitude": "",
                    },
                    "seller_contact": null,
                    "location": null,
                    "geolocation": - {
                      "latitude": "",
                      "longitude": "",
                    },
                    "coverage_areas": [
                    ],
                    "attributes": [
                    ],
                    "listing_source": "",
                    "variations": [
                    ],
                    "status": "active",
                    "sub_status": [
                    ],
                    "tags": [
                    ],
                    "warranty": "1 Mês",
                    "catalog_product_id": null,
                    "parent_item_id": null,
                    "automatic_relist": false,
 
              */

            // ...  tem mais...

            linha += "<br /><hr />";

            lblResultJSON.Text = linha;

 
        }

    }
}