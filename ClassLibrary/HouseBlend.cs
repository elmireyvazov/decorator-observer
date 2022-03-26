using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace ClassLibrary
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "houseblend ";
        }

        protected override double Cost()
        {
            return (0.5 * milk) + (0.3 * soy) + (0.2 * mocha) + (0.6 * whip) + 4.99;
        }
    }
}
