using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPFinalNivel3MalerbaMatias
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ErrorMessage"] != null)
            {
                txtError.InnerText = Session["ErrorMessage"].ToString();
                btnErrorRedirect.NavigateUrl = Session["RedirectUrl"].ToString();
                btnErrorRedirect.Text = Session["BtnText"].ToString();
                btnErrorRedirect.Visible = true;
            }
        }
    }
}