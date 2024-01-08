using prjBibliotec.API.util;
using prjListaLivros.logica;
using prjListaLivros.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjBibliotec.API
{
    public partial class livros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json";
            Response.AddHeader("Access-Control-Allow-Origin", "*");
            //Response.AddHeader("Access-Control-Allow-Origin", "https://localhost:8100");
            Response.AddHeader("Access-Control-Allow-Methods", "GET");
            LivroLogica livroLogica = new LivroLogica();

            int inicio = 0;
            int quantidade = 20;
            string filtro = "";

            if (!String.IsNullOrEmpty(Request["inicio"]) && Numero.ehNumero(Request["inicio"]))
            {
                inicio = int.Parse(Request["inicio"]);
            }
            if (!String.IsNullOrEmpty(Request["quantidade"]) && Numero.ehNumero(Request["quantidade"]))
            {
                quantidade = int.Parse(Request["quantidade"]);
            }
            if (!String.IsNullOrEmpty(Request["filtro"]))
            {
                filtro = Request["filtro"];
            }

            if (!String.IsNullOrEmpty(Request["categoria"]) && Numero.ehNumero(Request["categoria"]))
            {
                int categoria = int.Parse(Request["categoria"]);
                Response.Write(new JavaScriptSerializer().Serialize(livroLogica.Listar(categoria, inicio, quantidade)));
                return;
            }

            if (!String.IsNullOrEmpty(Request["mais-reservados"]))
            {
                Response.Write(new JavaScriptSerializer().Serialize(livroLogica.ListarMaisReservados(inicio, quantidade)));
                return;
            }

            Response.Write(new JavaScriptSerializer().Serialize(livroLogica.Listar(filtro, inicio, quantidade)));
        }
    }
}