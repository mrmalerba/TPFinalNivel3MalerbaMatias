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
            if (NegocioSecurity.IsLoguedIn((User)Session["user"]))
            {
                if (NegocioSecurity.IsAdmin((User)Session["user"]))
                {
                    NegocioArticulos negocioArticulos = new NegocioArticulos();
                    List<Articulo> articulos = negocioArticulos.ReadArticles();

                    gridAdministrarProductos.DataSource = articulos;
                    gridAdministrarProductos.DataBind();
                }
                else
                {
                    ErrorManagement errorManagement = new ErrorManagement();
                    errorManagement.ManageError("No tienes permiso para ingresar a esta página.", "ListaProductos.aspx", "Volver a Página de Inicio");
                }
            }
            else
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ManageError("Para utilizar esta página debe Ingresar con un usuario administrador", "Login.aspx", "Ir a la página de Ingreso");
            }
        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarModificarEliminarProducto.aspx", false);
        }

        protected void gridAdministrarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedProductId = gridAdministrarProductos.SelectedDataKey.Value.ToString();
            Response.Redirect("AgregarModificarEliminarProducto.aspx?Id=" + selectedProductId, false);
        }
    }
}