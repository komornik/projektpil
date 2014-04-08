using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit
{
    abstract class Figura
    {
        private double szerokosc;

        public double Szerokosc
        {
            get { return szerokosc; }
            set { szerokosc = value; }
        }

        private double wysokosc;

        public double Wysokosc
        {
            get { return wysokosc; }
            set { wysokosc = value; }
        }

        abstract public double pole();

        abstract public double obwod();


    }
}
