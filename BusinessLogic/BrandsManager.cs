using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public void Delete(Brand brand)
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

        /// <summary>
        /// Verifica si la marca del artículo no pertenece a ningun otro y en tal caso la elimina.
        /// </summary>
        public void PurgeBrand(Brand brand)
        {
            bool brandInUse = BrandIsInUse(brand);
            Debug.Print($"Verificando si la marca {brand} está en uso => {brandInUse}");

            if (!brandInUse)
            {
                Delete(brand);
            }
        }

        private bool BrandIsInUse(Brand brand)
        {
            try
            {
                _dataAccess.SetQuery(
                    "select COUNT(*) as Total from Articulos where IdMarca = @BrandId"
                );
                _dataAccess.SetParameter("@BrandId", brand.Id);
                return _dataAccess.ExecuteScalar() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Ocurrió un error al verificar si la marca {brand?.Description} existe.",
                    ex
                );
            }
            finally
            {
                _dataAccess.CloseConnection();
            }
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
