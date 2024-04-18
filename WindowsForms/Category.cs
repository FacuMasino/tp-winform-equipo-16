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
