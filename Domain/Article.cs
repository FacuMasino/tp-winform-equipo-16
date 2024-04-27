using System.Collections.Generic;
using System.ComponentModel;

namespace Domain
{
    public class Article
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Código")]
        public string Code { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Precio")]
        public decimal Price { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Marca")]
        public Brand Brand { get; set; }

        [DisplayName("Categoría")]
        public Category Category { get; set; }

        public List<Image> Images { get; set; }

        public Article()
        {
            Brand = new Brand();
            Category = new Category();
            Images = new List<Image>();
        }
    }
}
