using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Collections.Specialized.BitVector32;

namespace TPFinalNivel3MalerbaMatias
{
    public class ErrorManagement
    {
        public void ManageError(string errorMessage, string redirectUrl, string btnText)
        {
            HttpContext.Current.Session.Add("ErrorMessage", errorMessage);
            HttpContext.Current.Session.Add("RedirectUrl", redirectUrl);
            HttpContext.Current.Session.Add("BtnText", btnText);
            HttpContext.Current.Response.Redirect("ErrorPage.aspx", false);
        }
    }
}