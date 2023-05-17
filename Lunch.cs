using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    internal class Lunch:Food //Lunch Class , inherits from Food Class 
    {
        bool isCombo; // yes or no , is it a combo 

        public Lunch(string productName, double price, int points, bool IsCombo) : base(productName, price, points, IsCombo) // added field to constructor 
        {
            isCombo = IsCombo;
        }

        public override string ToString() // Base String + Lunch String 
        {
            return base.ToString() + "" + $"Is it a combo: {isCombo}"; 
        }
    }
}
