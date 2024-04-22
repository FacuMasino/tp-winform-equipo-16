using System;
using System.Collections.Generic;
using Domain;

namespace BusinessLogicLayer
{
    public class ArticlesManager
    {
        private DataAccess _dataAccess = new DataAccess();

        public List<Article> List()
        {
            List<Article> articles = new List<Article>();

            try
            {
                _dataAccess.SetQuery("select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio from Articulos");
                _dataAccess.ExecuteRead();

                while (_dataAccess.Reader.Read())
                {
                    Article article = new Article();

                    article.Id = (int)_dataAccess.Reader["Id"];

                    if (!(_dataAccess.Reader["Codigo"] is DBNull))
                    {
                        article.Code = (string)_dataAccess.Reader["Codigo"];
                    }

                    if (!(_dataAccess.Reader["Nombre"] is DBNull))
                    {
                        article.Name = (string)_dataAccess.Reader["Nombre"];
                    }

                    if (!(_dataAccess.Reader["Descripcion"] is DBNull))
                    {
                        article.Description = (string)_dataAccess.Reader["Descripcion"];
                    }

                    if (!(_dataAccess.Reader["IdMarca"] is DBNull))
                    {
                        article.Brand.Id = (int)_dataAccess.Reader["IdMarca"];
                    }

                    if (!(_dataAccess.Reader["IdCategoria"] is DBNull))
                    {
                        article.Category.Id = (int)_dataAccess.Reader["IdCategoria"];
                    }

                    if (!(_dataAccess.Reader["Precio"] is DBNull))
                    {
                        article.Price = (decimal)_dataAccess.Reader["Precio"];
                    }

                    articles.Add(article);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _dataAccess.CloseConnection();
            }

            // aca me falta hacer un forich para reediarle acada elemento de la lista su marca y categoria, pero necesito antes hacer los manasher de branes y categorises

            return articles;
        }

        public Article Read(int id)
        {
            Article article = new Article();

            try
            {
                _dataAccess.SetQuery("select Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio from Articulos where Id = @Id");
                _dataAccess.SetParameter("@Id", id);
                _dataAccess.ExecuteRead();

                if (_dataAccess.Reader.Read())
                {
                    article.Id = id;

                    if (!(_dataAccess.Reader["Codigo"] is DBNull))
                    {
                        article.Code = (string)_dataAccess.Reader["Codigo"];
                    }

                    if (!(_dataAccess.Reader["Nombre"] is DBNull))
                    {
                        article.Name = (string)_dataAccess.Reader["Nombre"];
                    }

                    if (!(_dataAccess.Reader["Descripcion"] is DBNull))
                    {
                        article.Description = (string)_dataAccess.Reader["Descripcion"];
                    }

                    if (!(_dataAccess.Reader["IdMarca"] is DBNull))
                    {
                        article.Brand.Id = (int)_dataAccess.Reader["IdMarca"];
                    }

                    if (!(_dataAccess.Reader["IdCategoria"] is DBNull))
                    {
                        article.Category.Id = (int)_dataAccess.Reader["IdCategoria"];
                    }

                    if (!(_dataAccess.Reader["Precio"] is DBNull))
                    {
                        article.Price = (decimal)_dataAccess.Reader["Precio"];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _dataAccess.CloseConnection();
            }

            // lo mismo pero para uno solo

            return article;
        }

        public void Add(Article article)
        {
            //aca hay que primero agregar o editar marca y categoria, obtener sus ids y luego escribir en tabla de articulos esos ides

            try
            {
                _dataAccess.SetQuery("insert into Articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                SetParameters(article);
                _dataAccess.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _dataAccess.CloseConnection();
            }
        }

        public void Edit(Article article)
        {
            // lo mismo

            try
            {
                _dataAccess.SetQuery("update Articulos set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio where Id = @Id");
                _dataAccess.SetParameter("@Id", article.Id);
                SetParameters(article);
                _dataAccess.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _dataAccess.CloseConnection();
            }
        }

        public void delete(Article article)
        {
            try
            {
                _dataAccess.SetQuery("delete from Articulos where Id = @Id");
                _dataAccess.SetParameter("@Id", article.Id);
                _dataAccess.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _dataAccess.CloseConnection();
            }

            // en caso de que no haya otro article con cierta marca y otro articulo con cierta categoria, eliminarlas aca 
        }

        public int GetId(Article article)
        {
            if (article == null)
            {
                return 0;
            }

            int id = 0;

            try
            {
                _dataAccess.SetQuery("select Id from Articulos where Codigo = @Codigo");
                _dataAccess.SetParameter("@Codigo", article.Code);
                _dataAccess.ExecuteRead();

                if (_dataAccess.Reader.Read())
                {
                    id = (int)_dataAccess.Reader["Id"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _dataAccess.CloseConnection();
            }

            return id;
        }

        private void SetParameters(Article article)
        {
            if (article.Code != null)
            {
                _dataAccess.SetParameter("@Codigo", article.Code);
            }

            if (article.Name != null)
            {
                _dataAccess.SetParameter("@Nombre", article.Name);
            }

            if (article.Description != null)
            {
                _dataAccess.SetParameter("@Descripcion", article.Description);
            }

            if (article.Brand != null)
            {
                _dataAccess.SetParameter("@IdMarca", article.Brand.Id);
            }

            if (article.Category != null)
            {
                _dataAccess.SetParameter("@IdCategoria", article.Category.Id);
            }

            _dataAccess.SetParameter("@Price", article.Price);
        }
    }
}
