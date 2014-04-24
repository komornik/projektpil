using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Nunit
{
    [TestFixture]
    class RownoleglobokTest
    {
        [Test]
        public void PoleTest()
        {
            Rownoleglobok rownoleglobok = new Rownoleglobok();

            rownoleglobok.Szerokosc = 10;
            rownoleglobok.Wysokosc = 20;
            rownoleglobok.H = 10;

            Console.WriteLine("Test liczenie pola równoległoboku o wartościach A = " + rownoleglobok.Szerokosc + " H = " + rownoleglobok.h);
            Assert.AreEqual(100, rownoleglobok.pole());
            Console.ReadKey();
        }

        [Test]
        public void ObwodTest()
        {
            Rownoleglobok rownoleglobok = new Rownoleglobok(20, 10, 20);

            Console.WriteLine("Test liczenie obwodu równoległoboku o wartościach A = " + rownoleglobok.Szerokosc + " B = " + rownoleglobok.Wysokosc);
            Assert.AreEqual(60, rownoleglobok.obwod());
            Console.ReadKey();
        }

    }
}
