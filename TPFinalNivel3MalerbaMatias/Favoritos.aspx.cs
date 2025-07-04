using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace TPFinalNivel3MalerbaMatias
{
    public partial class Favoritos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Validar Si sesion iniciada, sino reenviar a Login
            if (Session["user"] != null)
            {
                Negocio.NegocioArticulos negocioArticle = new Negocio.NegocioArticulos();
                ProductCatalog.DataSource = negocioArticle.ReadFavouritesArticles(((User)Session["user"]).Id);
                ProductCatalog.DataBind();
            }
            else
            {
                Response.Redirect("Login.aspx", false);
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}