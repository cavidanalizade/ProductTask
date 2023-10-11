using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask
{
    class Product
    {
        public string Name { get; set; }
        private int _price;

        public int Price
        {
            get { return _price; }
            set 
            {
                if (value > 0)
                {
                _price = value; 
                } 
            }
        }
        private int _count;

        public int Count
        {
            get { return _count; }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }
        }

        public Product(string Name , int Price)
        {
            this.Name = Name;
            this.Price = Price;

        }
    }
}
