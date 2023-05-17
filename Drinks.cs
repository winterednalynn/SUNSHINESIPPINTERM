using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    abstract class Drinks : Product //Abstract class , Drinks inherits from Product 
    {
        public enum Sizes {Short, Tall, Grade, Venti, Trenta }; //Enumerator for sizes . 
        string _sizeCup; // size of cup 

        protected Drinks(string productName, double price, int points, string sizeCup) : base(productName, price, points) // Field added to Constructor 
        {
            _sizeCup = sizeCup;
        }
    }
}
