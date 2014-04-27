using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Nunit
{
    [TestFixture]
    class ProstokatTest
    {
        [Test]
        public void PoleTest()
        {
            Prostokat prostokat = new Prostokat();

            prostokat.Szerokosc = 10;
            prostokat.Wysokosc = 20;

            Console.WriteLine("Test liczenie pola prostokąta o wartościach w = " + prostokat.Wysokosc + " s = " + prostokat.Szerokosc);
            Assert.AreEqual(200, prostokat.pole());
            
        }

        [Test]
        public void ObwodTest()
        {
            Prostokat prostokat = new Prostokat(20, 10);

            Console.WriteLine("Test liczenie obwodu prostokąta o wartościach w = " + prostokat.Wysokosc + " s = " + prostokat.Szerokosc);
            Assert.AreEqual(60, prostokat.obwod());
            
        }

    }
}
