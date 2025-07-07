using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPFinalNivel3MalerbaMatias
{
    public partial class PerfilDeUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                User currentUser = (Dominio.User)Session["user"];
                if (NegocioSecurity.IsLoguedIn(currentUser))
                {
                    string nombre = string.IsNullOrEmpty(currentUser.Nombre) ? string.Empty : currentUser.Nombre;
                    string apellido = string.IsNullOrEmpty(currentUser.Apellido) ? string.Empty : currentUser.Apellido;
                    string email = string.IsNullOrEmpty(currentUser.Email) ? string.Empty : currentUser.Email;
                    string imageUrl = string.IsNullOrEmpty(currentUser.UrlImagenPerfil) ? string.Empty : currentUser.UrlImagenPerfil;

                    if (string.IsNullOrEmpty(email))
                    {
                        HeaderNombreDeUsuario.InnerText = "Invitado";
                        txtNombre.Visible = false;
                        txtApellido.Visible = false;
                        txtEMail.Visible = false;
                        btnGuardarPerfil.Visible = false;
                        productImage.Visible = false;
                    }
                    else
                    {
                        txtEMail.Text = email;

                        if (!string.IsNullOrEmpty(nombre))
                        {
                            HeaderNombreDeUsuario.InnerText = nombre;
                            txtNombre.Text = nombre;
                            HeaderNombreDeUsuario.InnerText = nombre;
                        }
                        else
                        {
                            txtNombre.Text = string.Empty;
                            HeaderNombreDeUsuario.InnerText = email;
                        }

                        if (!string.IsNullOrEmpty(apellido))
                        {
                            txtApellido.Text = apellido;
                        }
                        else
                        {
                            txtApellido.Text = string.Empty;
                        }

                        if (!string.IsNullOrEmpty(imageUrl))
                            productImage.ImageUrl = imageUrl;
                        else
                            productImage.ImageUrl = "https://i.imgur.com/V4RclNb.png";

                        if (currentUser.Admin == true)
                        {
                            lblTipoDeUsuario.InnerText = "Administrador 🔑";
                        }

                    }
                }
            }
            else
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ManageError("Para ingresar a la página de Perfil, debe Ingresar con un usuario", "Login.aspx", "Ir a la página de Ingreso");
            }
        }

        protected void btnGuardarPerfil_Click(object sender, EventArgs e)
        {

        }

        protected void btnCerrarPerfil_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("ListaProductos.aspx", false);
        }
    }
}