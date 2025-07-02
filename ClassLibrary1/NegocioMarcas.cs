using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMarcas
    {
        public List<Marca> ReadMarcas()
        {
            List<Marca> marcas = new List<Marca>();
            DbConnection connection = new DbConnection();

            connection.SetProcedure("ReadMarcas");
            connection.ReadQuery();

            while (connection.Reader.Read())
            {
                Marca marca = new Marca();
                marca.Id = int.Parse(connection.Reader["Id"].ToString());
                marca.Descripcion = connection.Reader["Descripcion"].ToString();

                marcas.Add(marca);
            }

            return marcas;

        }
    }
}
