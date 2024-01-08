using prjListaLivros.logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjBibliotec.API
{
    public partial class categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json";
            Response.AddHeader("Access-Control-Allow-Origin", "*");
            //Response.AddHeader("Access-Control-Allow-Origin", "https://localhost:8100");
            Response.AddHeader("Access-Control-Allow-Methods", "GET");

            CategoriaLogica categoriaLogica = new CategoriaLogica();

            if (!String.IsNullOrEmpty(Request["codigo"]))
            {
                string codigo = Request["codigo"];
                Response.Write(new JavaScriptSerializer().Serialize(categoriaLogica.ListarPorCodigo(codigo)));
                return;
            }

            Response.Write(new JavaScriptSerializer().Serialize(categoriaLogica.Listar()));
        }
    }
}