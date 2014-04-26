using System;
using System.Collections.Generic;
using System.Text;


namespace Nunit
{
    abstract public class Figura
    {
<<<<<<< HEAD
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
=======
        private double szerokosc;

        public double Szerokosc
>>>>>>> krzysztof_test
        {
            get { return szerokosc; }
            set { szerokosc = value; }
        }

<<<<<<< HEAD
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
=======
        private double wysokosc;

        public double Wysokosc
>>>>>>> krzysztof_test
        {
            get { return wysokosc; }
            set { wysokosc = value; }
        }

        abstract public double pole();

        abstract public double obwod();


    }
}
