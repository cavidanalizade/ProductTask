using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask
{
    class Book:Product
    {
        public string Genre { get; set; }
        public int Length { get; internal set; }

        public Book(string Name, int Price , string Genre):base(Name ,Price)
        {
            this.Genre = Genre;
        }
    }
}
