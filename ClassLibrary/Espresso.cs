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
            description = "espresso ";
        }

        protected override double Cost()
        {
            return (0.5 * milk) + (0.3 * soy) + (0.2 * mocha) + (0.6 * whip) + 3.99;
        }
    }
}
