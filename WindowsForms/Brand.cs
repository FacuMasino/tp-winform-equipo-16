using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    internal class Brand
    {
        private int Id;
        public int BrandId
        {
            get { return Id; }
            set { Id = value; }
        }


        private string Name;
        public string BrandName
        {
            get { return Name; }
            set { Name = value; }
        }

       }
    }

