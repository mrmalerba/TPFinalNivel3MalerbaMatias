using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPFinalNivel3MalerbaMatias
{
    public partial class AgregarModificarEliminarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Negocio.NegocioSecurity.IsLoguedIn((Dominio.User)Session["user"]))
                {



                    if (!(Request.QueryString["Id"] is null))
                    {
                        btnModificarProducto.Visible = true;
                        btnAgregarProducto.Visible = false;
                    }
                    else
                    {
                        txtId.Text = "El Id se generará automaticamente";
                        btnModificarProducto.Visible = false;
                        btnAgregarProducto.Visible = true;
                        btnEliminarProducto.Visible = false;
                    }

                    if (!IsPostBack)
                    {
                        NegocioMarcas negocioMarcas = new NegocioMarcas();
                        NegocioCategoria negocioCategoria = new NegocioCategoria();
                        List<Marca> marcas = negocioMarcas.ReadMarcas();
                        List<Categoria> categorias = negocioCategoria.ReadCategorias();
                        ddlMarca.DataSource = marcas;
                        ddlMarca.DataTextField = "Descripcion";
                        ddlMarca.DataValueField = "Id";
                        ddlMarca.DataBind();
                        ddlCategoria.DataSource = categorias;
                        ddlCategoria.DataTextField = "Descripcion";
                        ddlCategoria.DataValueField = "Id";
                        ddlCategoria.DataBind();


                        int productoId;
                        if (!(Request.QueryString["Id"] is null))
                        {

                            productoId = int.Parse(Request.QueryString["Id"].ToString());

                            NegocioArticulos negocioArticulos = new NegocioArticulos();
                            Articulo currentArticle = negocioArticulos.ReadArticle(productoId);

                            txtheadertitulo.InnerText = "Modificar detalles";
                            txtId.Text = currentArticle.Id.ToString();
                            txtCodigo.Text = currentArticle.Codigo;
                            txtNombre.Text = currentArticle.Nombre;
                            txtDescripcion.Text = currentArticle.Descripcion;
                            txtPrecio.Text = currentArticle.Precio.ToString();
                            ddlMarca.SelectedValue = currentArticle.Marca.Id.ToString();
                            ddlCategoria.SelectedValue = currentArticle.Categoria.Id.ToString();
                            ProductImage.ImageUrl = currentArticle.ImagenUrl;

                            btnModificarProducto.Visible = true;
                            btnAgregarProducto.Visible = false;
                        }
                    }
                }
                else
                {
                    ErrorManagement errorManagement = new ErrorManagement();
                    errorManagement.ManageError("Debe estar logueado para acceder a esta página", "Login.aspx", "Ir al Ingreso");
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ManageError(ex.ToString(), "ListaProductos.aspx", "Volver al Catalogo");
            }

        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            NegocioArticulos negocioArticulos = new NegocioArticulos();
            Articulo articuloAInsertar = new Articulo();

            articuloAInsertar.Codigo = txtCodigo.Text;
            articuloAInsertar.Nombre = txtCodigo.Text;
            articuloAInsertar.Descripcion = txtDescripcion.Text;
            articuloAInsertar.Categoria.Id = int.Parse(ddlCategoria.SelectedItem.Value);
            articuloAInsertar.Marca.Id = int.Parse(ddlMarca.SelectedItem.Value);
            articuloAInsertar.ImagenUrl = ProductImage.ImageUrl;
            articuloAInsertar.Precio = decimal.Parse(txtPrecio.Text);


            int newArticleId = negocioArticulos.InsertArticle(articuloAInsertar);

            Response.Redirect("AgregarModificarEliminarProducto.aspx?Id=" + newArticleId, false);
        }

        protected void btnModificarProducto_Click(object sender, EventArgs e)
        {
            NegocioArticulos negocioArticulos = new NegocioArticulos();
            Articulo articuloAModificar = new Articulo();

            articuloAModificar.Id = int.Parse(txtId.Text);
            articuloAModificar.Codigo = txtCodigo.Text;
            articuloAModificar.Nombre = txtCodigo.Text;
            articuloAModificar.Descripcion = txtDescripcion.Text;
            articuloAModificar.Categoria.Id = int.Parse(ddlCategoria.SelectedItem.Value);
            articuloAModificar.Marca.Id = int.Parse(ddlMarca.SelectedItem.Value);
            articuloAModificar.ImagenUrl = ProductImage.ImageUrl;
            articuloAModificar.Precio = decimal.Parse(txtPrecio.Text);

            negocioArticulos.UpdateArticle(articuloAModificar);
        }

        protected void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            btnEliminarProducto.Visible = false;
            panelConfirmacion.Visible = true;
        }

        protected void btnConfirmarEliminarProducto_Click(object sender, EventArgs e)
        {
            NegocioArticulos negocio = new NegocioArticulos();
            if (checkConfirmarEliminar.Checked == true)
            {
                negocio.DeleteArticulo(int.Parse(txtId.Text));
                Response.Redirect("AdministracionProducto.aspx", false);
            }
            else
            {
                Response.Write("<script>alert('Debe confirmar que desea eliminar el Articulo')</script>");
            }
        }

        protected void btnCancelarEliminacion_Click(object sender, EventArgs e)
        {
            btnEliminarProducto.Visible = true;
            panelConfirmacion.Visible = false;
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministracionProducto.aspx", false);
        }

    }
}