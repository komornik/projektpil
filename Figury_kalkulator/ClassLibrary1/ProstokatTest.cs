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
            Assert.AreEqual(200, prostokat.pole());
            
        }

        [Test]
        public void ObwodTest()
        {
            Prostokat prostokat = new Prostokat(20, 10);
            Assert.AreEqual(60, prostokat.obwod());
            
        }

    }
}
