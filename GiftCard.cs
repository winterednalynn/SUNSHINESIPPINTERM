using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    internal class GiftCard :Product // Gift card inherits from Product 
    {
        double _amount; // amount as double for decimal purposes EX : 2.45 , 50.55, 90,99. 

        public GiftCard(string productName, double price, int points, double amount) : base(productName, price, points) // FIELD ADDED to constructor 
        {
            _amount = amount;
        }

        public override string ToString() // base string + GiftCard String 
        {
            return base.ToString() + "" + $"Amount in GiftCard: {_amount}"; 
        }
    }
}
