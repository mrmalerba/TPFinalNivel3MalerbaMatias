using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioArticulos
    {
        public List<Articulos> ReadArticle() { 
			List<Articulos> articleList = new List<Articulos>();
            DbConnection connection = new DbConnection();
			try
			{

				connection.SetProcedure("ReadArticulos");
				connection.ReadQuery();

				while (connection.Reader.Read()) { 
					Articulos articles = new Articulos();
					articles.Id = (int)connection.Reader["Id"];
                    articles.Codigo = (string)connection.Reader["Codigo"];
                    articles.Nombre = (string)connection.Reader["Nombre"];
                    articles.Descripcion = (string)connection.Reader["Descripcion"];
                    articles.Marca.Id = (int)connection.Reader["IdMarca"];
                    articles.Categoria.Id = (int)connection.Reader["IdCategoria"];
                    articles.ImagenUrl = (string)connection.Reader["ImagenUrl"];
                    articles.Precio = (decimal)connection.Reader["Precio"];

                    articleList.Add(articles);
                }

                return articleList;

			}
			catch (Exception ex)
			{

				throw ex;
			}

        }
    }
}
