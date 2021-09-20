using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FåKoerekortet.Models
{
    public class School
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public double Price { get; set; }

        public School(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public School(string name, double price, string link)
        {
            Name = name;
            Price = price;
            Link = link;
        }
    }
}
