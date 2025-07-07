using Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioSecurity
    {
        public bool CheckLogin(string email, string pass)
        {
            bool LoginSuccesful = false;

            DbConnection connection = new DbConnection();
            connection.SetProcedure("ReadUser");
            connection.SetParameter("@email", email);
            connection.SetParameter("@pass", pass);
            connection.ReadQuery();

            User user = new User();
            while (connection.Reader.Read())
            {
                user.Id = int.Parse(connection.Reader["Id"].ToString());
            }

            if (!string.IsNullOrEmpty(user.Id.ToString()))
                if(user.Id != 0)
                    LoginSuccesful = true;

            return LoginSuccesful;
        }

        public static bool IsLoguedIn(User user)
        {
            bool loguedIn = false;

            if (!(user is null))
            {
                if (user.Id != 0)
                    loguedIn = true;
            }
                return loguedIn;
        }

        public static bool IsAdmin(User user)
        {
            return user.Admin ? true : false;
        }
    }
}
