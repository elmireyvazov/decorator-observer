using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Decaf : Beverage 
    {
        public Decaf()
        {
            Description = "decaf";
            price = 3.0;
        }
        public override double Cost()
        {
            return price;
        }
    }
}
