using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    abstract class Merchandise: Product //Merchandise inherits from product 
    {
        string _color; // field , color 

        protected Merchandise(string productName, double price, int points, string color) : base(productName, price, points) // added to constructor 
        {
            _color = color; 
        }

        public override string ToString() // base to string + Merchandise string 
        {
            return base.ToString() + " " + $"Color: {_color}"; 
        }
    }
}
