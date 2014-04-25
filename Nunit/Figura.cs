using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit
{
    abstract public class Figura
    {
<<<<<<< HEAD
<<<<<<< HEAD
        private int szerokosc;

        public int Szerokosc
=======
        private double szerokosc;

        public double Szerokosc
>>>>>>> origin/master
=======
        private double szerokosc;

        public double Szerokosc
=======
        private int szerokosc;

        public int Szerokosc
>>>>>>> krisu
>>>>>>> matusek
        {
            get { return szerokosc; }
            set { szerokosc = value; }
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private int wysokosc;
=======
        private double wysokosc;
<<<<<<< HEAD
>>>>>>> matusek

=======
>>>>>>> origin
        public double Wysokosc
<<<<<<< HEAD
>>>>>>> origin/master
=======
=======
        private int wysokosc;

        public int Wysokosc
>>>>>>> krisu
>>>>>>> matusek
        {
            get { return wysokosc; }
            set { wysokosc = value; }
        }

        abstract public double pole();

        abstract public double obwod();


    }
}
