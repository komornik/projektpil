using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Nunit
{
    public class Trapez : Figura
    {
        private double a,b,c,d,h;

        public double podstawa_dolna
        {
            get { return a; }
            set { a = value; }
        }

        public double podstawa_gorna
        {
            get { return b; }
            set { b = value; }
        }

        public double ramie_c
        {
            get { return c; }
            set { c = value; }
        }

        public double ramie_d
        {
            get { return d; }
            set { d = value; }
        }

        public double wysokosc
        {
            get { return h; }
            set { h = value; }
        }

        public Trapez()
        {


        }

        /// <summary>
        /// klasa licz¹ca pole trapezu
        /// </summary>
        /// <returns> jeœli jakiœ bok lub wysokoœæ jest ujemna to zwraca -1</returns>
        public override double pole()
        {
            if (a >= 0 || b >= 0 || c >= 0 || d >= 0 || h >= 0)
            {
                return (a+b+c+d);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// klasa licz¹ca obwód trapezu
        /// </summary>
        /// <returns>jeœli jakiœ bok lub wysokoœæ jest ujemna to zwraca -1</returns>
        public override double obwod()
        {
            if (a >= 0 || b >= 0 || h >= 0)
            {
                return (0.5*(a+b)*h);
            }
            else
            {
                return -1;
            }
        }
    }
}
