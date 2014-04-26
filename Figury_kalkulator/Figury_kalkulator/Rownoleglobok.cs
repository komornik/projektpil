using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit
{
    class Rownoleglobok : Figura
    {
        /// <summary>
        /// Wysokość równoległoboku
        /// </summary>
        private double h;

        public double H
        {
            get { return h; }
            set { h = value; }
        }


        public Rownoleglobok()
        {
            ;
        }

        /// <summary>
        /// Kostruktor ustawiający podstawowe zmienne
        /// </summary>
        /// <param name="a">Bok a</param>
        /// <param name="b">Bok b</param>
        /// <param name="h">Wysokość</param>
        public Rownoleglobok(double a, double b, double h)
        {
            this.Szerokosc = a;
            this.Wysokosc = b;
            this.h = h;
        }


        /// <summary>
        /// Obliacznie pola równoległoboku
        /// </summary>
        /// <returns>Pole równoległoboku, w przypadku błędu zwraca 0</returns>
        public override double pole()
        {
            if (this.Szerokosc > 0 && this.h > 0)
            {
                return this.Szerokosc * this.h;
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda obliczająca obwód równoległoboku
        /// </summary>
        /// <returns>Obwód równoległoboku</returns>
        public override double obwod()
        {
            if (this.Szerokosc > 0 && this.Wysokosc > 0)
            {
                return (2 * this.Szerokosc) + (2 * this.Wysokosc);
            }
            throw new NotImplementedException();
        }
    }
}
