using System.ComponentModel;

namespace Domain
{
    public class Brand
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
