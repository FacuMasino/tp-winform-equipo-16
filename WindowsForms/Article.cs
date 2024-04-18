using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    internal class Article
    {

        // Constructores
        public Article ( string ArticleCode, string Name, string Description, decimal Price)
        {
            this.ArticleCode = ArticleCode;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;

        }

        public Article() { }



        private string Code;
        public string ArticleCode
        {
             get { return Code;  }
             set { Code = value; }
        }

        private string Name;
        public string ArticleName
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

        private decimal Price;
        public decimal ArticlePrice
        {

            get { return Price; }
            set { Price = value;  }
        }

        private Brand BrandId;


        }
    }

