using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    internal class Article
    {

        private string Code;
        public string ArticleCode
        {
             get { return Code;  }
             set { Code = value; }
        }

        private string Name;
        public int ArticleName
        {
            get { return Name; }
            set { Name = value; }
         }


        private string Description;
        public string ArticleDescription
        {
            get { return Description;  }
            set { Description = value; }
        }

        private float Price;
        public float ArticlePrice
        {

            get { return Price; }
            set { Price = value;  }
        }


        }
    }

