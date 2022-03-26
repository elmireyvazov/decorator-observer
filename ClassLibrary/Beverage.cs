using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Beverage
    {
        protected string description;

        protected int milk = 0;
        protected int soy = 0;
        protected int mocha = 0;
        protected int whip = 0;

        public string Description
        {
            get { return description + hasMilk() + hasSoy() + hasMocha() + hasWhip() + Cost() + "$"; }
        }

        protected abstract double Cost();

        public void setMilk()
        {
            milk++;
        }
        protected string hasMilk()
        {
            if (milk > 0)
            {
                return "+ " + milk + " молоко ";
            }
            return "";
        }

        public void setSoy()
        {
            soy++;
        }
         protected string hasSoy()
        {
            if (soy > 0)
            {
                return "+ " + soy + " соя ";
            }
            return "";
        }

        public void setMocha()
        {
            mocha++;
        }
        protected string hasMocha()
        {
            if (mocha > 0)
            {
                return "+ " + mocha + " моча ";
            }
            return "";
        }

        public void setWhip()
        {
            whip++;
        }
        protected string hasWhip()
        {
            if (whip > 0)
            {
                return "+ " + whip + " молоко ";
            }
            return "";
        }
    }
}
