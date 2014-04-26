﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit
{
    class Prostokat : Figura
    {
        public Prostokat()
        {
            ;
        }

        public Prostokat(double wysokosc, double szerokosc)
        {
            this.Szerokosc = szerokosc;
            this.Wysokosc = wysokosc;
        }

        /// <summary>
        /// Implementacja abstrakcyjnej metody liczenia pola figury
        /// </summary>
        /// <param name="a">wysokosc</param>
        /// <param name="b">szerokosc</param>
        /// <returns>pole prostokata</returns>
        public override double pole()
        {
            return this.Szerokosc * this.Wysokosc;
        }

        public override double obwod()
        {
            return (2 * this.Szerokosc) + (2 * this.Wysokosc);
        }
    }
}
