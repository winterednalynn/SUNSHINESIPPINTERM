using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    internal class Tea : Drinks // Inheriting from Drink Class 
    {
        string _typeOfTea; // FIELD for TEA class. 

        public Tea(string productName, double price, int points, string sizeCup, string typeOftea) : base(productName, price, points, sizeCup) // CONSTRUCTOR 
        {
            _typeOfTea = typeOftea;
        }

        public override string ToString() // Drinks TO STRING & Tea string 
        {
            return base.ToString() + "" + $"Type of Tea: {_typeOfTea}"; 
        }

    }
}
