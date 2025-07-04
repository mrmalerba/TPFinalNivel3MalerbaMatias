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
        public List<Articulo> ReadArticles() { 
			List<Articulo> articleList = new List<Articulo>();
            DbConnection connection = new DbConnection();
			try
			{

				connection.SetProcedure("ReadArticulos");
				connection.ReadQuery();

				while (connection.Reader.Read()) { 
					Articulo articles = new Articulo();
					articles.Id = (int)connection.Reader["Id"];
                    articles.Codigo = (string)connection.Reader["Codigo"];
                    articles.Nombre = (string)connection.Reader["Nombre"];
                    articles.Descripcion = (string)connection.Reader["DescipcionArticulos"];
                    articles.Marca.Id = (int)connection.Reader["IdMarca"];
                    articles.Marca.Descripcion = connection.Reader["DescripcionMarca"].ToString();
                    articles.Categoria.Id = (int)connection.Reader["IdCategoria"];
                    articles.Categoria.Descripcion = connection.Reader["DescripcionCategoria"].ToString();
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

        public List<Articulo> ReadFavouritesArticles(int userId)
        {
            List<Articulo> articleList = new List<Articulo>();
            DbConnection connection = new DbConnection();
            try
            {

                connection.SetProcedure("ReadFavouritesArticles");
                connection.SetParameter("@IdUser", userId);
                connection.ReadQuery();

                while (connection.Reader.Read())
                {
                    Articulo articles = new Articulo();
                    articles.Id = (int)connection.Reader["Id"];
                    articles.Codigo = (string)connection.Reader["Codigo"];
                    articles.Nombre = (string)connection.Reader["Nombre"];
                    articles.Descripcion = (string)connection.Reader["DescipcionArticulos"];
                    articles.Marca.Id = (int)connection.Reader["IdMarca"];
                    articles.Marca.Descripcion = connection.Reader["DescripcionMarca"].ToString();
                    articles.Categoria.Id = (int)connection.Reader["IdCategoria"];
                    articles.Categoria.Descripcion = connection.Reader["DescripcionCategoria"].ToString();
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


        public Articulo ReadArticle(int Id)
        {
            Articulo article = new Articulo();
            DbConnection connection = new DbConnection();
            try
            {

                connection.SetProcedure("ReadAnArticulo");
                connection.SetParameter("@Id", Id);
                connection.ReadQuery();

                while (connection.Reader.Read())
                {
                    article.Id = (int)connection.Reader["Id"];
                    article.Codigo = (string)connection.Reader["Codigo"];
                    article.Nombre = (string)connection.Reader["Nombre"];
                    article.Descripcion = (string)connection.Reader["Descripcion"];
                    article.Marca.Id = (int)connection.Reader["IdMarca"];
                    article.Categoria.Id = (int)connection.Reader["IdCategoria"];
                    article.ImagenUrl = (string)connection.Reader["ImagenUrl"];
                    article.Precio = (decimal)connection.Reader["Precio"];
                }

                return article;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
