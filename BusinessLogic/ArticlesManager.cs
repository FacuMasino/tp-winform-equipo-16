using System;
using System.Collections.Generic;
using DataAccessLayer;
using Domain;
using Utilities;

namespace BusinessLogicLayer
{
    public class ArticlesManager
    {
        private DataAccess _dataAccess = new DataAccess();
        private BrandsManager _brandsManager = new BrandsManager();
        private CategoriesManager _categoriesManager = new CategoriesManager();

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

            foreach (Article article in articles)
            {
                article.Brand = _brandsManager.Read(article.Brand.Id);
                article.Category = _categoriesManager.Read(article.Category.Id);
            }

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

            article.Brand = _brandsManager.Read(article.Brand.Id);
            article.Category = _categoriesManager.Read(article.Category.Id);

            return article;
        }

        public void Add(Article article)
        {
            SetBrandId(article);
            SetCategoryId(article);

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
            SetBrandId(article);
            SetCategoryId(article);

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

            // Verificar si la marca del articulo no pertenece a ningun otro y en tal caso eliminarla
            // Verificar si la categoria del articulo no pertenece a ningun otro y en tal caso eliminarla
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

        private void SetBrandId(Article article)
        {
            if (article.Brand != null)
            {
                int dbBrandId = _brandsManager.GetId(article.Brand);

                if (dbBrandId == 0)
                {
                    _brandsManager.Add(article.Brand);
                    article.Brand.Id = Helper.GetLastId("Marcas");
                }
                else
                {
                    article.Brand.Id = dbBrandId;
                }
            }
        }

        private void SetCategoryId(Article article)
        {
            if (article.Category != null)
            {
                int dbCategoryId = _categoriesManager.GetId(article.Category);

                if (dbCategoryId == 0)
                {
                    _categoriesManager.Add(article.Category);
                    article.Category.Id = Helper.GetLastId("Categorias");
                }
                else
                {
                    article.Brand.Id = dbCategoryId;
                }
            }
        }
    }
}
