using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPFinalNivel3MalerbaMatias
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio.NegocioArticulos negocioArticle = new Negocio.NegocioArticulos();
            ProductCatalog.DataSource = negocioArticle.ReadArticle();
            ProductCatalog.DataBind();
        }
    }
}