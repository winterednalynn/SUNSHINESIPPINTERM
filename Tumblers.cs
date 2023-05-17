using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    internal class Tumblers:Product // TUMBLER inherits from Product 
    {//FIELDS 
        string _color;

        public Tumblers(string productName, double price, int points, string color) : base(productName, price, points) // FIELD added to constructor 
        {
            _color = color; 
        }
        public override string ToString() // BASE TO string + Tumbler string 
        {
            return base.ToString() + " " + $"Style of Tumbler: {_color}";
        }
    }
}
