using System.ComponentModel;
using System.Xml.Linq;

namespace Domain
{
    public class Category
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            if (Description != null)
            {
                return Description;
            }
            else
            {
                return " ";
            }
        }
    }
}
