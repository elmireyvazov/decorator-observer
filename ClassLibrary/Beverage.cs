using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Beverage
    {
        protected string Description;

        double milk = 0.3;
        double soy = 0.4;
        double mocha = 0.5;
        double whip = 0.6;

        public string getDescription
        {
            get { return Description; }
        }

        public double price { get; set; }
        abstract public double Cost();

        public string setMilk()
        {
            return $"{Description += "добавляем молоко"} : { price += milk}";
        }
        public string setSoy()
        {
            return $"{Description += "добавляем сою"} ; {price += soy}";
        }
        public string setMocha()
        {
            return $"{Description += "добавляем мокко"} : {price += mocha}";
        }
        public string setWhip()
        {
            return $"{Description += "добавляем сливки"} : {price += whip}";
        }
    }
}
