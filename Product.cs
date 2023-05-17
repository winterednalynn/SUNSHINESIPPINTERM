using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNSHINESIPPINTERM
{
    abstract class Product //Abstract Class 
    {
        //Fields 
        string _productName;
        int _sku;
        double _price;
        int _points;

        static int _numberOfProduct; 

     

        protected Product(string productName, double price, int points) // Constructor 
        {
            Random rand = new Random(); // Randomizing SKU 
            _productName = productName;
            _price = price;
            _points = points;
            _sku =rand.Next(1000000, 10000000);

            _numberOfProduct++; 

        }

    

        public override string ToString() // BASE STRING 
        {
            return $"Order#: {_sku} Product: {_productName}, Price: {_price}, Points: {_points} -  ";
        }
    }
}
