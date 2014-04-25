using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nunit
{
    class Trojkat:Figura

    {
        private double c;

        public double bok_c
        {
            get { return c; }
            set { c = value; }
        }

        private double b;

        public double bok_b
        {
            get { return b; }
            set { b = value; }
        }

        public Trojkat()
        {

        }
        public Trojkat(double wysokosc, double podstawa)
        {
            this.Wysokosc = wysokosc;
            this.Szerokosc = podstawa;
        }

        public Trojkat(double wysokosc, double podstawa, double bok_b, double bok_c)
        {
            this.Wysokosc = wysokosc;
            this.Szerokosc = podstawa;
            this.bok_c = bok_c;
            this.bok_b = bok_b;

        }

        /// <summary>
        /// funkcja zwracająca pole trójkąta
        /// </summary>
        /// <returns>jeśli nie podano boku Wyskości lub Podstawy funkcja zwraca -1</returns>
        public override double pole()
        {
            if (Wysokosc == null || Szerokosc == null)
            {
                return -1;
            }
            else
            {
                return (0.5 * (Wysokosc * Szerokosc));
            }
        }

        /// <summary>
        /// Funkcja zwracająca obwód trójkąta
        /// </summary>
        /// <returns>jeśli nie podano boku c i b funkcja zwraca -1</returns>
        public override double obwod()
        {
            if (b == null || c == null)
            {
                return -1;
            }
            else
            {
                return (Szerokosc * b * c);
            }

        }

    }
}
