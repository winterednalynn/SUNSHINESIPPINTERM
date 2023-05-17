using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    internal class Breakfast: Food // Breakfast inherits from food class 
    {
        bool _hasDairy; // yes or no dairy 

  

        public Breakfast(string productName, double price, int points, bool hasDairy ) : base(productName, price, points, hasDairy) // Added field to constructor 
        { 
             _hasDairy = hasDairy;
            
        }

        public override string ToString() // Base string + Breakfast String 
        {
            return base.ToString() + " " + $"Dairy : {_hasDairy} "; 
        }
    }
}
