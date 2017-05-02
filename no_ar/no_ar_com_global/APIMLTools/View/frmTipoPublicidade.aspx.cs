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
			
			Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString());
			string linha = "";
			List<TipoPublicidade> publicidades;
			try 
			{	        
				IRestResponse response = m.Get("/sites/MLB/listing_types");
				publicidades = JsonConvert.DeserializeObject<List<TipoPublicidade>>(response.Content);

				linha += "<table class='table table-striped'>";
					linha += "<thead>";
					linha += "<tr><th>ID</th><th>Nome</th></tr>";    
					linha += "</thead>";
					linha += "<tbody>";
						foreach(TipoPublicidade tipo in publicidades) {
							linha += "<tr>";
							linha += "<td>" + tipo.id + "</td>";
							linha += "<td>" + tipo.name +"</td>";
							linha += "</tr>";
						}
					linha += "</tbody>";
				linha += "</table>";
		   

			lblResultJSON.Text = linha;

			}
			catch (Exception ex)
			{		
				lblResultJSON.Text = ex.Message;
			}
		}    
	
	}
}