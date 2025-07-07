using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Dominio;

namespace Negocio
{
    public class NegocioUsers
    {
        public User ReadUser(string email, string pass)
        {
            try
            {
                User user = new User();
                DbConnection connection = new DbConnection();

                connection.SetProcedure("ReadUser");
                connection.SetParameter("@email", email);
                connection.SetParameter("@pass", pass);
                connection.ReadQuery();

                while (connection.Reader.Read())
                {
                    user.Id = int.Parse(connection.Reader["Id"].ToString());
                    user.Email = connection.Reader["email"].ToString();
                    user.Pass = connection.Reader["pass"].ToString();
                    user.Nombre = connection.Reader["nombre"].ToString();
                    user.Apellido = connection.Reader["apellido"].ToString();
                    user.UrlImagenPerfil = connection.Reader["urlImagenPerfil"].ToString();
                    user.Admin = bool.Parse(connection.Reader["admin"].ToString());
                }

                return user;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }
}
