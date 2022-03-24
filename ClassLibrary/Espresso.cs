using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Espresso : Beverage 
    {
        public Espresso()
        {
            Description = "espresso";
            price = 4.0;
        }
        public override double Cost()
        {
           return price;
        }
    }
}
