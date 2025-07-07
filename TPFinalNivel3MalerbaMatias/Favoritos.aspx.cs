using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPFinalNivel3MalerbaMatias
{
    public partial class Favoritos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Validar Si sesion iniciada, sino reenviar a Login
            if (NegocioSecurity.IsLoguedIn((User)Session["user"]))
            {
                Negocio.NegocioArticulos negocioArticle = new Negocio.NegocioArticulos();
                ProductCatalog.DataSource = negocioArticle.ReadFavouritesArticles(((User)Session["user"]).Id);
                ProductCatalog.DataBind();
            }
            else
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ManageError("Para ingresar a la página de Favoritos, debe Ingresar con un usuario", "Login.aspx", "Ir a la pagina de Ingreso");
                //Session.Add("ErrorMessage", "Para ingresar a la página de Favoritos, debe Ingresar con un usuario" );
                //Session.Add("RedirectUrl", "Login.aspx");
                //Session.Add("BtnText", "Ir a la página de Ingreso");
                //Response.Redirect("ErrorPage.aspx", false);
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}