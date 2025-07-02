using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioCategoria
    {

        public List<Categoria> ReadCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            DbConnection connection = new DbConnection();
            
            connection.SetProcedure("ReadCategorias");
            connection.ReadQuery();

            while (connection.Reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Id = int.Parse(connection.Reader["Id"].ToString());
                categoria.Descripcion = connection.Reader["Descripcion"].ToString();

                categorias.Add(categoria);
            }

            return categorias;

        }
    }
}
