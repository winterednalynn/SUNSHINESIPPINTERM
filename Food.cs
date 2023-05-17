using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    abstract class Food:Product //Abstract Class - Food inherits from product 
    {
        bool isHeated; // Yes or no is heated 

        protected Food(string productName, double price, int points, bool IsHeated) : base(productName, price, points) // Field added to constructor 
        {
           isHeated = IsHeated;
        }
        public override string ToString() // base to string + Food string 
        {
            return base.ToString() + " " + $"is Heated: {isHeated} "; 

        }
    }
}
