using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace RPM
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseBlend hb = new HouseBlend();
            DarkRoast dr = new DarkRoast();
            Decaf d = new Decaf();
            Espresso e = new Espresso();

            hb.setMilk();
            hb.setMilk();

            dr.setSoy();
            dr.setMocha();

            d.setWhip();
            d.setMocha();
            d.setMilk();

            Console.WriteLine(hb.Description);
            Console.WriteLine(dr.Description);
            Console.WriteLine(d.Description);
            Console.WriteLine(e.Description);

            Console.ReadLine();
        }
    }
}
