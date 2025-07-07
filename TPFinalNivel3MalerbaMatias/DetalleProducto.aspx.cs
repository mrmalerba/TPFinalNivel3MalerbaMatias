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
    public partial class DetalleProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NegocioMarcas negocioMarcas = new NegocioMarcas();
                NegocioCategoria negocioCategoria = new NegocioCategoria();
                List<Marca> marcas = negocioMarcas.ReadMarcas();
                List<Categoria> categorias = negocioCategoria.ReadCategorias();

            }

            if (Request.QueryString["Id"] != null)
            {
                NegocioMarcas negocioMarcas = new NegocioMarcas();
                NegocioCategoria negocioCategoria = new NegocioCategoria();
                List<Marca> marcas = negocioMarcas.ReadMarcas();
                List<Categoria> categorias = negocioCategoria.ReadCategorias();

                NegocioArticulos negocioArticulos = new NegocioArticulos();
                Articulo article = negocioArticulos.ReadArticle(int.Parse(Request.QueryString["Id"]));

                
                txtId.Text = article.Id.ToString();
                txtCodigo.Text = article.Codigo.ToString();
                txtNombre.Text = article.Nombre.ToString();
                txtDescripcion.Text = article.Descripcion.ToString();
                ddlMarca.DataSource = marcas;
                ddlMarca.DataTextField = "Descripcion";
                ddlMarca.DataValueField = "Id";
                ddlMarca.DataBind();
                ddlMarca.SelectedValue = article.Marca.Id.ToString();
                ddlCategoria.DataSource = categorias;
                ddlCategoria.DataTextField = "Descripcion";
                ddlCategoria.DataValueField = "Id";
                ddlCategoria.DataBind();
                ddlCategoria.SelectedValue = article.Categoria.Id.ToString();
                txtPrecio.Text = article.Precio.ToString();
                ProductImage.ImageUrl = article.ImagenUrl.ToString();
                ProductImage.DescriptionUrl = article.Codigo.ToString() + "_Image";

            }
        }
    }
}