using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPFinalNivel3MalerbaMatias
{
    public partial class AdministracionProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioArticulos negocioArticulos = new NegocioArticulos();
            List<Articulo> articulos = negocioArticulos.ReadArticles();

            gridAdministrarProductos.DataSource = articulos;
            gridAdministrarProductos.DataBind();

        }
    }
}