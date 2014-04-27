using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Nunit
{
    public class Osmiokat : Figura
    {
        private double a;

        public double bok_a
        {
            get { return a; }
            set { a = value; }
        }
        public Osmiokat()
        {


        }

        /// <summary>
        /// klasa licz¹ca pole osmiokatu
        /// </summary>
        /// <returns> jeœli nie podano boku zwraca -1</returns>
        public override double pole()
        {
            if (a >= 0)
            {
                return (2 * (1 + Math.Sqrt(2))*(a*a));
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// klasa licz¹ca obwód osmiokatu
        /// </summary>
        /// <returns> jeœli nie podano boku zwraca -1</returns>
        public override double obwod()
        {
            if (a != null)
            {
                return (8*a);
            }
            else
            {
                return -1;
            }
        }
    }
}
