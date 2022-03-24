using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DarkRoast : Beverage 
    {
        public DarkRoast()
        {
            Description = "darkroast";
            price = 2.0;
        }
        public override double Cost()
        {
            return price;
        }
    }
}
