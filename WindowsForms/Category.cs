using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WindowsForms
{
    internal class Category
    {

        //CONSTRUCTORES
        public Category(int Id, string Name)
        { this.Id = Id;
        this.Name = Name; }

        public Category() { }
            
            
            
        private int Id;
        public int CategoryId
        { 
        get { return Id; }
        set { Id = value;}
        }

        private string Name;
        public string CategoryName
        {
        get { return Name; }
        set { Name =value;}
        }
    }
}
