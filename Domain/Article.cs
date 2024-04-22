using System.Collections.Generic;

namespace Domain
{
    internal class Article
    {
        private string _code;
        private string _name;
        private decimal _price;
        private string _description;
        private Brand _brand;
        private Category _category;

        // Esta propiedad es "readonly" para que no se pueda reasignar
        // de nuevo en alguna otra parte de la clase
        private readonly List<Image> _image = new List<Image>();

        // Constructores
        public Article(
            string code,
            string name,
            string description,
            decimal price,
            Brand brand,
            Category category
        )
        {
            this._code = code;
            this._name = name;
            this._description = description;
            this._price = price;
            Brand = brand;
            Category = category;
        }

        public Article() { }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Brand Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        // Devuelve toda la lista de imágenes
        public List<Image> Images
        {
            get { return _image; }
        }

        // Agregar imagen a la lista
        public void AddImage(Image image)
        {
            _image.Add(image);
        }

        // Quita una imagen de la lista por ID
        public bool RemoveImage(int id)
        {
            foreach (Image image in _image)
            {
                if (image.Id == id)
                {
                    _image.Remove(image);
                    return true;
                }
            }
            return false; // Si no encuentra la imágen devuelve false
        }
    }
}
