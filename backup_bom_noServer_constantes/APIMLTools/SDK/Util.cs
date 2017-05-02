using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.AnuncioComAttributes;
using Model.AnuncioPorNickName;
using Models.Perfil;
using Models.Pergunta;
using Models.TotalDeVisitas;


namespace SDK {
    public static class Util {

        // Busca Apelido através do seller_id (Vendedor)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sellerid"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static string GetNick(int sellerid, Meli m) {
            string vCliente = "";
           // m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());
            string vUrl = "/users/" + sellerid;

            Perfil perfil;
            try {
                IRestResponse response = m.Get(vUrl);
                perfil = JsonConvert.DeserializeObject<Perfil>(response.Content);
            } catch {                
                return "[]";
            }

            vCliente = perfil.nickname;

            return vCliente;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nick"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static string GetIDUser(string nick, Meli m) {

            string sellerID = "";

            string vUrl = "/sites/MLB/search?nickname=" + nick + "&access_token=" + m.AccessToken;

            AnuncioPorNickName anuncPorNickName;

            try {
                IRestResponse response = m.Get(vUrl);
                anuncPorNickName = JsonConvert.DeserializeObject<AnuncioPorNickName>(response.Content);
            } catch(Exception ex) {
                return ex.Message;
            }

            sellerID = anuncPorNickName.seller.id.ToString();

            return sellerID;

        }



        public static string GetTitleItems(string vItemID, Meli m) {
            string vRetval;

            string vUrl = "/items/" + vItemID;

            // adaptar no futuro os attributes;
            //   /items/MLB598578869?attributes=title,permalink,thumbnail

            AnuncioComAttributes vObj;
            try {
                IRestResponse response = m.Get(vUrl);
                vObj = JsonConvert.DeserializeObject<AnuncioComAttributes>(response.Content);
            } catch(Exception ex) {
                return ex.Message;
            }


            //vRetval = "<div><table><tr>";
            //vRetval += "<td style='width: 70px; height: 70px;' rowspan='2'><img src='"+ vObj.thumbnail +"' border='0' /></td><td><a href='"  + vObj.permalink + "' target='_blank'>" + vObj.title + "</a></td>";
            //vRetval += "</tr></table></div>";


            vRetval = "<table>";
            vRetval += "<tr>";
            vRetval += "<td style='width: 70px; height: 70px;' rowspan='2'><img src='"+ vObj.thumbnail +"' border='0' /></td>";
            vRetval += "<td>"+ vItemID +"</td>";
            vRetval += "</tr>";
            vRetval += "<tr>";
            vRetval += "<td><a href='"  + vObj.permalink + "' target='_blank'>" + vObj.title + "</a></td>";
            vRetval += "</tr>";
            vRetval += "</table>";


            return vRetval;
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static Perfil GetPerfil(Meli m, int userID){

            string vID = userID.ToString();

            string vUrl = "/users/" + vID;

            Perfil perfil;
            try {
                IRestResponse response = m.Get(vUrl);
                perfil = JsonConvert.DeserializeObject<Perfil>(response.Content);
            } catch {
                return null;
            }

            return perfil;
        
        }





        
        /// <summary>
        /// NÃO ESTÁ FUNCIONANDO, POIS DÁ ERRO NO ACCESS_TOKEN. TAVEZ SEJA PELO FATO DE SER STATIC.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static Pergunta GetPergunta(Meli m, string userID){

            string vUrl = "/questions/search?seller_id=" + userID + "&access_token=" + m.AccessToken.ToString();

            Pergunta pergunta;
            try {
                IRestResponse response = m.Get(vUrl);
                pergunta = JsonConvert.DeserializeObject<Pergunta>(response.Content);
            } catch {
                return null;
            }

            return pergunta;
        
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string LimpaApostrofe(string texto) {
            string novoTexto = texto.Replace("'", "");
            return novoTexto;
        }

        /*

					{"id":"not_verified","name":"Not verified"},
					{"id":"cancelled","name":"Cancelled"},	
         *          {"id":"closed","name":"Closed"},


					{"id":"delivered","name":"Delivered"},
					{"id":"not_delivered","name":"Not Delivered"},
					{"id":"paid","name":"Order Paid"},
					{"id":"not_paid","name":"Order Not Paid"},
					{"id":"claim_closed","name":"Claim Closed"},
					{"id":"claim_opened","name":"Claim Opened"},
					{"id":"not_processed","name":"Not processed order"},
					{"id":"processed","name":"Processed order"}
					{"id":"cost_exceeded","name":"Cost exceeded"},
					{"id":"regenerating","name":"Regenerating"},
					{"id":"waiting_for_label_generation","name":"Waiting for label generation"},
					{"id":"ready_to_print","name":"Ready to print"},
					{"id":"invoice_pending","name":"Invoice pending"},
					{"id":"printed","name":"Printed"},
					{"id":"in_pickup_list","name":"In pikcup list"},
					{"id":"ready_for_pickup","name":"Ready for pickup"},
					{"id":"picked_up","name":"Picked up"},
					{"id":"in_hub","name":"In hub"},
					{"id":"measures_ready","name":"Measures and weight ready"},
					{"id":"waiting_for_carrier_authorization","name":"Waiting for carrier authorization"},
					{"id":"authorized_by_carrier","name":"Authorized by carrier"},
					{"id":"in_plp","name":"In PLP"},
					{"id":"delayed","name":"Delayed"},
					{"id":"waiting_for_withdrawal","name":"Waiting for withdrawal"},
					{"id":"contact_with_carrier_required","name":"Contact with carrier required"},
					{"id":"receiver_absent","name":"Receiver absent"},
					{"id":"reclaimed","name":"Reclaimed"},
					{"id":"not_localized","name":"Not localized"},
					{"id":"forwarded_to_third","name":"Forwarded to third party"},
					{"id":"soon_deliver","name":"Soon deliver"},
					{"id":"refused_delivery","name":"Delivery refused"},
					{"id":"bad_address","name":"Bad address"},

         *          {"id":"error","name":"Error"},
					{"id":"active","name":"Active"},
					{"id":"not_specified","name":"Not specified"},
        */





        /// <summary>
        /// 
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string GetTextoPtBR(string texto) {

            string vTextoTraduzido = "";
            string vTextoOrigem = texto;

            switch(vTextoOrigem) {
                case "refunded":
                    vTextoTraduzido = "Reembolsado";
                    break;
                case "paid":
                    vTextoTraduzido = "Pago (a ser creditado)";
                    break;
                case "confirmed":
                    vTextoTraduzido = "Confirmado";
                    break;
                case "pending":
                    vTextoTraduzido = "Pendente";
                    break;
                case "stale_ready_to_ship":
                    vTextoTraduzido = "[Obsoleto] Pronto para enviar";
                    break;
                case "stolen":
                    vTextoTraduzido = "Roubado";
                    break;
                case "account_money":
                    vTextoTraduzido = "Dinheiro na Conta";
                    break;
                case "shipping":
                    vTextoTraduzido = "Expedição";
                    break;
                case "ticket":
                    vTextoTraduzido = "Boleto";
                    break;

                case "invalid":
                    vTextoTraduzido = "Inválido";
                    break;

                case "no_action_taken":
                    vTextoTraduzido = "Nenhuma ação pelo comprador";
                    break;

                case "fulfilled_feedback":
                    vTextoTraduzido = "Tudo OK por parte do comprador";
                    break;

                case "damaged":
                    vTextoTraduzido = "Defeituoso ou Estragado";
                    break;        
                    

                case "payment_required":
                    vTextoTraduzido = "Pagto requerido";
                    break;
                case "payment_in_process":
                    vTextoTraduzido = "Pgto processando...";
                    break;
                case "cancelled":
                    vTextoTraduzido = "Cancelado";
                    break;
                case "accredited":
                    vTextoTraduzido = "Pago e Creditado";
                    break;
                case "retained":
                    vTextoTraduzido = "Retido";
                    break;

                case "need_review":
                    vTextoTraduzido = "Necessidade de rever o estado para entender o que aconteceu";
                    break;

                case "negative_feedback":
                    vTextoTraduzido = "[Obsoleto] Não entregue devido ao feedback negativo pelo comprador";
                    break;
                    
                case "approved":
                    vTextoTraduzido = "Aprovado";
                    break;

                case "repproved":
                    vTextoTraduzido = "Reprovado";
                    break;

                case "is_closed":
                    vTextoTraduzido = "Encerrado";
                    break;
                case "claim_closed":
                    vTextoTraduzido = "Reclamação Encerrada";
                    break;
                case "delivered":
                    vTextoTraduzido = "Entregue";
                    break;
                case "not_paid":
                    vTextoTraduzido = "Não Pago";
                    break;
                case "not_delivered":
                    vTextoTraduzido = "Não Entregue";
                    break;
                case "ready_to_ship":
                    vTextoTraduzido = "Pronto para enviar";
                    break;
                case "handling":
                    vTextoTraduzido = "Preparando...";
                    break;
                case "to_be_agreed":
                    vTextoTraduzido = "A combinar";
                    break;
                case "not_specified":
                    vTextoTraduzido = "Não verificado";
                    break;
                case "regular_payment":
                    vTextoTraduzido = "Pagto regular";
                    break;
                case "credit_card":
                    vTextoTraduzido = "Cartão de crédito";
                    break;
                case "returning_to_sender":
                    vTextoTraduzido = "Retornando ao remetente";
                    break;  
                                        
                case "negative":
                    vTextoTraduzido = "Negativo";
                    break;   
                case "neutral":
                    vTextoTraduzido = "Neutro";
                    break;   
                case "positive":
                    vTextoTraduzido = "Positivo";
                    break;
                case "shipped":
                    vTextoTraduzido = "Eviado";
                    break;
                case "custom_shipping":
                    vTextoTraduzido = "Transporte personalizado";
                    break; 


                case "returned":
                    vTextoTraduzido = "Voltou";
                    break;                 
                case "confiscated":
                    vTextoTraduzido = "Confiscado";
                    break;                 
                case "to_review":
                    vTextoTraduzido = "Rever remessa";
                    break;                 
                case "destroyed":
                    vTextoTraduzido = "Destruída";
                    break; 
                          

                case "installments":
                    vTextoTraduzido = "Parcelas";
                    break;                    
                default:
                    vTextoTraduzido = vTextoOrigem;
                    break;
            }

            return vTextoTraduzido;


        }


        public static int getVisitas(string item_id, Meli m) {

            // https://api.mercadolibre.com/items/{Items_id}/visits?date_from={Date_from}&date_to={Date_to}

            // vamos obter a data de hoje
            DateTime hoje = DateTime.Now;

            // vamos subtrair 12 meses da data de hoje
            DateTime data_passado = hoje.AddMonths(-12);

            string vFormatDataHoje = hoje.Year.ToString() + "-" + hoje.Month.ToString() + "-" + hoje.Day + "T00:00.000-00:00";
            string vFormatDataPassada = data_passado.Year.ToString() + "-" + data_passado.Month.ToString() + "-" + data_passado.Day + "T00:00.000-00:00";

            var p = new RestSharp.Parameter();
            p.Name = "date_from";
            p.Value = vFormatDataPassada;

            var p2 = new RestSharp.Parameter();
            p2.Name = "date_to";
       //     p2.Value = "2015-06-01T00:00:00.000-00:00";
            p2.Value = vFormatDataHoje;

            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);
            ps.Add(p2);

            TotalDeVisitasPorItem tVisitas;
            try {
                IRestResponse response = m.Get("/items/" + item_id + "/visits", ps);
                tVisitas = JsonConvert.DeserializeObject<TotalDeVisitasPorItem>(response.Content);
            } catch {
                throw new Exception("Erro ao obter número de visitas");
            }


            return tVisitas.total_visits;

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="total"></param>
        /// <param name="limit"></param>
        /// <param name="numPag"></param>
        /// <param name="vServer"></param>
        /// <param name="code"></param>
        /// <param name="vOffset"></param>
        /// <param name="vCat"></param>
        /// <param name="arq"></param>
        /// <returns></returns>
        public static string GetPaginacao(int total, int limit, int numPag, string vServer, string code, int vOffset, string vCat, string arq) {

            int LinksPorLinha = 7;
            string linha = "";

            int paginaAtual = vOffset;
            int pagIniIntervalo = 0;
            int pagFimIntervalo = pagIniIntervalo + LinksPorLinha;

            if(paginaAtual > 2 && paginaAtual < (numPag -3)) {
                pagIniIntervalo = (paginaAtual - 3);
                pagFimIntervalo = (paginaAtual + 3);
            } else if(paginaAtual <= 2) {
                pagIniIntervalo = 0;
                pagFimIntervalo = 6;
            } else if(paginaAtual > (numPag - 3)) {
                pagIniIntervalo = numPag-7;
                pagFimIntervalo = numPag;
            }

            int anterior = paginaAtual-1;
            int seguinte = paginaAtual+1;
            if(anterior < 0) { anterior = 0; }
            if(seguinte > numPag) { seguinte = numPag; }

            linha += "<div class='col-lg-12'>";

            linha += "<div class='panel-body'>";
            linha += "<ul class='pagination'>";

            string classAtual = "";
            string classPrimeiro = "";
            string classAnterior = "";
            string classSeguinte = "";
            string classUltimo = "";

            if(paginaAtual > 0) {
                classPrimeiro = " class='first'";
            } else {
                classPrimeiro = " class='first disabled'";
                classAnterior = " class='previous disabled'";
            }

            linha += "<li "+ classPrimeiro +"><a href='" + vServer + "/" + arq + "?code=" + code + "&offset=" + 0 + "&cat=" + vCat + "'>Primeiro</a>";
            linha += "<li" + classAnterior + "><a href='" + vServer + "/" + arq + "?code=" + code + "&offset=" + anterior + "&cat=" + vCat + "'><i class='fa fa-angle-left'></i></a>";



            for(int k=pagIniIntervalo; k <= pagFimIntervalo; k++) {
                if(paginaAtual != k) {
                    classAtual = "";
                } else {
                    classAtual = " class='disabled'";
                }
                linha += "<li" + classAtual + "><a href='" + vServer + "/" + arq + "?code=" + code + "&offset=" + k + "&cat=" + vCat + "'>" + (k+1) + "</a></li>";
            }

            if(paginaAtual < numPag) {
                classSeguinte = " class='next'";
            } else {
                classSeguinte = " class='next disabled'";
                classUltimo = " class='last disabled'";
            }

            linha += "<li" + classSeguinte + "><a href='" + vServer + "/" + arq + "?code=" + code + "&offset=" + seguinte + "&cat=" + vCat + "'><i class='fa fa-angle-right'></i></a>";
            linha += "<li" + classUltimo + "><a href='" + vServer + "/" + arq + "?code=" + code + "&offset=" + numPag + "&cat=" + vCat + "'>Último</a></li>";

            linha += "</ul>";
            linha += "</div>";

            linha += "</div>";



            return linha;


        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="total"></param>
        /// <param name="limit"></param>
        /// <param name="numPag"></param>
        /// <param name="vServer"></param>
        /// <param name="code"></param>
        /// <param name="vOffset"></param>
        /// <param name="arq"></param>
        /// <returns></returns>
        public static string GetPaginacao(string keyword, int total, int limit, int numPag, string vServer, string code, int vOffset, string arq) {

            int LinksPorLinha = 7;
            string linha = "";

            int paginaAtual = vOffset;
            int pagIniIntervalo = 0;
            int pagFimIntervalo = pagIniIntervalo + LinksPorLinha;

            if(paginaAtual > 2 && paginaAtual < (numPag -3)) {
                pagIniIntervalo = (paginaAtual - 3);
                pagFimIntervalo = (paginaAtual + 3);
            } else if(paginaAtual <= 2) {
                pagIniIntervalo = 0;
                pagFimIntervalo = 6;
            } else if(paginaAtual > (numPag - 3)) {
                pagIniIntervalo = numPag-7;
                pagFimIntervalo = numPag;
            }

            int anterior = paginaAtual-1;
            int seguinte = paginaAtual+1;
            if(anterior < 0) { anterior = 0; }
            if(seguinte > numPag) { seguinte = numPag; }

            linha += "<div class='col-lg-12'>";

            linha += "<div class='panel-body'>";
            linha += "<ul class='pagination'>";

            string classAtual = "";
            string classPrimeiro = "";
            string classAnterior = "";
            string classSeguinte = "";
            string classUltimo = "";

            if(paginaAtual > 0) {
                classPrimeiro = " class='first'";
            } else {
                classPrimeiro = " class='first disabled'";
                classAnterior = " class='previous disabled'";
            }

            linha += "<li "+ classPrimeiro +"><a href='" + vServer + "/" + arq + "?code=" + code + "&offset=" + 0 + "&keyword=" + keyword + "'>Primeiro</a>";
            linha += "<li" + classAnterior + "><a href='" + vServer + "/" + arq + "?code=" + code + "&offset=" + anterior + "&keyword=" + keyword + "'><i class='fa fa-angle-left'></i></a>";



            for(int k=pagIniIntervalo; k <= pagFimIntervalo; k++) {
                if(paginaAtual != k) {
                    classAtual = "";
                } else {
                    classAtual = " class='disabled'";
                }
                linha += "<li" + classAtual + "><a href='" + vServer + "/" + arq + "?code=" + code + "&offset=" + k + "&keyword=" + keyword + "'>" + (k+1) + "</a></li>";
            }

            if(paginaAtual < numPag) {
                classSeguinte = " class='next'";
            } else {
                classSeguinte = " class='next disabled'";
                classUltimo = " class='last disabled'";
            }

            linha += "<li" + classSeguinte + "><a href='" + vServer + "/" + arq + "?code=" + code + "&offset=" + seguinte + "&keyword=" + keyword + "'><i class='fa fa-angle-right'></i></a>";
            linha += "<li" + classUltimo + "><a href='" + vServer + "/" + arq + "?code=" + code + "&offset=" + numPag + "&keyword=" + keyword + "'>Último</a></li>";

            linha += "</ul>";
            linha += "</div>";

            linha += "</div>";



            return linha;


        }





    }
}
