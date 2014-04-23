using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Nunit
{
   public class Okrag : Figura
    {
        private double r;

        public double promien
        {
            get { return r; }
            set { r = value; }
        }
        public Okrag()
        {
           

        }

        /// <summary>
        /// klasa licząca pole okregu
        /// </summary>
        /// <returns> jeśli nie podano promienia zwraca -1</returns>
        public override double pole()
        {
            if (r != null)
            {
                return (Math.PI * (r * r));
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// klasa licząca obwód okręgu
        /// </summary>
        /// <returns> jeśli nie podano promienia zwraca -1</returns>
        public override double obwod()
        {
            if (r != null)
            {
                return (2*Math.PI * r);
            }
            else
            {
                return -1;
            }
        }
    }
}
