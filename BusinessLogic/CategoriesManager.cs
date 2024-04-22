﻿using System;
using System.Collections.Generic;
using Domain;

namespace BusinessLogicLayer
{
    public class CategoriesManager
    {
        private DataAccess _dataAccess = new DataAccess();

        public List<Category> List()
        {
            List<Category> categories = new List<Category>();

            try
            {
                _dataAccess.SetQuery("select Id, Descripcion from Categories");
                _dataAccess.ExecuteRead();

                while (_dataAccess.Reader.Read())
                {
                    Category category = new Category();

                    category.Id = (int)_dataAccess.Reader["Id"];

                    if (!(_dataAccess.Reader["Descripcion"] is DBNull))
                    {
                        category.Description = (string)_dataAccess.Reader["Descripcion"];
                    }

                    categories.Add(category);
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

            return categories;
        }

        public Category Read(int id)
        {
            Category category = new Category();

            try
            {
                _dataAccess.SetQuery("select Descripcion from Categories where Id = @Id");
                _dataAccess.SetParameter("@Id", id);
                _dataAccess.ExecuteRead();

                if (_dataAccess.Reader.Read())
                {
                    category.Id = id;

                    if (!(_dataAccess.Reader["Descripcion"] is DBNull))
                    {
                        category.Description = (string)_dataAccess.Reader["Descripcion"];
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

            return category;
        }

        public void Add(Category category)
        {
            try
            {
                _dataAccess.SetQuery("insert into Categories (Descripcion) values (@Descripcion)");
                SetParameters(category);
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

        public void Edit(Category category)
        {
            try
            {
                _dataAccess.SetQuery("update Categories set Descripcion = @Descripcion where Id = @Id");
                _dataAccess.SetParameter("@Id", category.Id);
                SetParameters(category);
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

        public void delete(Category category)
        {
            try
            {
                _dataAccess.SetQuery("delete from Categories where Id = @Id");
                _dataAccess.SetParameter("@Id", category.Id);
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

        public int GetId(Category category)
        {
            if (category == null)
            {
                return 0;
            }

            int id = 0;

            try
            {
                _dataAccess.SetQuery("select Id from Categories where Descripcion = @Descripcion");
                _dataAccess.SetParameter("@Descripcion", category.Description);
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

        private void SetParameters(Category category)
        {
            if (category.Description != null)
            {
                _dataAccess.SetParameter("@Descripcion", category.Description);
            }
        }
    }
}
