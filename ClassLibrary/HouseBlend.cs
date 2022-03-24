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
            Description = "houseblend";
            price = 5.0;
        }
        public override double Cost()
        {
            return price;
        }
    }
}
