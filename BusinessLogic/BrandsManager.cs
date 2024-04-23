using System;
using System.Collections.Generic;
using DataAccessLayer;
using Domain;

namespace BusinessLogicLayer
{
    public class BrandsManager
    {
        private readonly DataAccess _dataAccess = new DataAccess();

        public List<Brand> List()
        {
            List<Brand> brands = new List<Brand>();

            try
            {
                _dataAccess.SetQuery("select Id, Descripcion from Marcas");
                _dataAccess.ExecuteRead();

                while (_dataAccess.Reader.Read())
                {
                    Brand brand = new Brand();

                    brand.Id = (int)_dataAccess.Reader["Id"];

                    /*
                     * Esta forma de escribir el código es igual a utilizar la forma:
                     * if (!(_dataAccess.Reader["Codigo"] is DBNull)) pero
                     * Estamos utilizando el operador de acceso condicional a miembros ?.
                     * Solo accede a la propiedad si el objeto no contiene null */
                    brand.Description = _dataAccess.Reader["Descripcion"]?.ToString();

                    brands.Add(brand);
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

            return brands;
        }

        public Brand Read(int id)
        {
            Brand brand = new Brand();

            try
            {
                _dataAccess.SetQuery("select Descripcion from Marcas where Id = @Id");
                _dataAccess.SetParameter("@Id", id);
                _dataAccess.ExecuteRead();

                if (_dataAccess.Reader.Read())
                {
                    brand.Id = id;

                    brand.Description = _dataAccess.Reader["Descripcion"]?.ToString();
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

            return brand;
        }

        public void Add(Brand brand)
        {
            try
            {
                _dataAccess.SetQuery("insert into Marcas (Descripcion) values (@Descripcion)");
                SetParameters(brand);
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

        public void Edit(Brand brand)
        {
            try
            {
                _dataAccess.SetQuery("update Marcas set Descripcion = @Descripcion where Id = @Id");
                _dataAccess.SetParameter("@Id", brand.Id);
                SetParameters(brand);
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

        public void delete(Brand brand)
        {
            try
            {
                _dataAccess.SetQuery("delete from Marcas where Id = @Id");
                _dataAccess.SetParameter("@Id", brand.Id);
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

        public int GetId(Brand brand)
        {
            if (brand == null)
            {
                return 0;
            }

            int id = 0;

            try
            {
                _dataAccess.SetQuery("select Id from Marcas where Descripcion = @Descripcion");
                _dataAccess.SetParameter("@Descripcion", brand.Description);
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

        private void SetParameters(Brand brand)
        {
            if (brand.Description != null)
            {
                _dataAccess.SetParameter("@Descripcion", brand.Description);
            }
        }
    }
}
