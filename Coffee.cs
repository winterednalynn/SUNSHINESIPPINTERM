using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    internal class Coffee : Drinks  // Coffee inherits from Drinks 
    {
        string _typeOfRoast; // Fields 

        public Coffee(string productName, double price, int points, string sizeCup, string typeOfRoast) : base(productName, price, points, sizeCup) // Added Coffee field to constructor of base
        {
            _typeOfRoast = typeOfRoast;
        }

        public override string ToString() // base to string + Coffee string 
        {
            return base.ToString() + "-" + $" Type of Roast: {_typeOfRoast}";
        }


    }
}
