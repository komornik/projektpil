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
<<<<<<< HEAD
       
=======

>>>>>>> d4b53367ebb6710eef0f682733572ff617c4bc4f
        /// <summary>
        /// klasa licz¹ca pole osmiokatu
        /// </summary>
        /// <returns> jeœli nie podano boku zwraca -1</returns>
        public override double pole()
        {
<<<<<<< HEAD
            if (a >= 0)
=======
            if (r >= 0)
>>>>>>> d4b53367ebb6710eef0f682733572ff617c4bc4f
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
<<<<<<< HEAD
            if (a != null)
=======
            if (r != null)
>>>>>>> d4b53367ebb6710eef0f682733572ff617c4bc4f
            {
                return (8*a);
            }
            else
            {
                return -1;
            }
        }
<<<<<<< HEAD
         
=======
>>>>>>> d4b53367ebb6710eef0f682733572ff617c4bc4f
    }
}
