using System;
using System.Collections.Generic;
using DataAccessLayer;
using Domain;

namespace BusinessLogicLayer
{
    public class ImagesManager
    {
        private readonly DataAccess _dataAccess = new DataAccess();

        public List<Image> List(int articleId)
        {
            List<Image> images = new List<Image>();

            try
            {
                _dataAccess.SetQuery("select * from imagenes where IdArticulo = @articleId");
                _dataAccess.SetParameter("@articleId", articleId);
                _dataAccess.ExecuteRead();

                while (_dataAccess.Reader.Read())
                {
                    Image auxImg = new Image();
                    auxImg.Id = _dataAccess.Reader["Id"] as int? ?? auxImg.Id;
                    auxImg.Url = _dataAccess.Reader["ImagenUrl"]?.ToString();

                    images.Add(auxImg);
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

            return images;
        }

        public void Add(Image image, int articleId)
        {
            try
            {
                _dataAccess.SetQuery(
                    "insert into imagenes(IdArticulo, ImagenUrl) values (@articleId, @imageUrl)"
                );
                _dataAccess.SetParameter("@articleId", articleId);
                _dataAccess.SetParameter("@imageUrl", image.Url);
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

        public void Add(List<Image> images, int articleId)
        {
            try
            {
                foreach (Image image in images)
                {
                    _dataAccess.SetQuery(
                        "insert into imagenes(IdArticulo, ImagenUrl) values (@articleId, @imageUrl)"
                    );
                    _dataAccess.SetParameter("@articleId", articleId);
                    _dataAccess.SetParameter("@imageUrl", image.Url);
                    _dataAccess.ExecuteAction();
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
        }

        public void Edit(Image image)
        {
            try
            {
                _dataAccess.SetQuery("update imagenes set ImagenUrl = @imageUrl where Id = @Id");
                _dataAccess.SetParameter("@Id", image.Id);
                _dataAccess.SetParameter("@imageUrl", image.Url);
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

        public void Delete(Image image)
        {
            try
            {
                _dataAccess.SetQuery("delete from imagenes where Id = @Id");
                _dataAccess.SetParameter("@Id", image.Id);
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

        public int GetId(Image image)
        {
            if (image == null)
            {
                return 0;
            }

            int id = 0;

            try
            {
                _dataAccess.SetQuery("select Id from imagenes where ImagenUrl = @ImageUrl");
                _dataAccess.SetParameter("@ImageUrl", image.Url);
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
    }
}
