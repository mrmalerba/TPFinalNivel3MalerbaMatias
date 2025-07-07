using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPFinalNivel3MalerbaMatias
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = string.IsNullOrEmpty(txtEMail.Text) ? "" : txtEMail.Text;
                string pass = string.IsNullOrEmpty(txtPass.Text) ? "" : txtPass.Text;
                NegocioSecurity seguridad = new NegocioSecurity();
                if (seguridad.CheckLogin(email, pass)) // chequear condicion, bajar el cheuqeo del ID dentro del IF
                {
                    NegocioUsers usercreation = new NegocioUsers();
                    User activeUser = usercreation.ReadUser(txtEMail.Text, txtPass.Text);
                    Session.Add("user", activeUser);
                    Response.Redirect("PerfilDeUsuario.aspx", false);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}