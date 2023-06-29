using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecQuintApp.EntitiesProd
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return ToString();
        }
        
        public override string ToString()
        {
            return $"Produto: {Name} | Preço: {Price}";
        }
    }
}
