using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    internal class Mugs : Merchandise  // Mugs inherits from Merchandise 
    { //FIELDS 
        string _design;

        public Mugs(string productName, double price, int points, string design) : base(productName, price, points, design) // Field added to constructor 
        {
            _design = design;
        }
        public override string ToString() // Base string + Mugs string 
        {
            return base.ToString() + " " + $"Design: {_design}"; 
        }
    }
}
