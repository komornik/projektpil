using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit
{
    public class Prostokat : Figura
    {
        /// <summary>
        /// Pusty konstruktor klasy prostokąt
        /// </summary>
        public Prostokat()
        {
            ;
        }

        /// <summary>
        /// Konstruktor dwu argumentowy
        /// </summary>
        /// <param name="wysokosc">Bok B prostokąta (wysokość)</param>
        /// <param name="szerokosc">Bok A prostokąta (szerokość)</param>
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
            if (this.Szerokosc > 0 && this.Wysokosc > 0)
            {
                return this.Szerokosc * this.Wysokosc;
            }
            else
            {
                throw new ArgumentException();
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda obliczająca obwód prostokąta
        /// </summary>
        /// <returns>Obwód prostokąt</returns>
        public override double obwod()
        {
            if (this.Szerokosc > 0 && this.Wysokosc > 0)
            {
                return (2 * this.Szerokosc) + (2 * this.Wysokosc);
            }else
            {
                throw new ArgumentException();
            }
            throw new NotImplementedException();
        }
    }
}
