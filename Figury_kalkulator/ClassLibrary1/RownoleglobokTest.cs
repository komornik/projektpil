﻿using System;
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
            Assert.AreEqual(100, rownoleglobok.pole());
            
        }

        [Test]
        public void ObwodTest()
        {
            Rownoleglobok rownoleglobok = new Rownoleglobok(20, 10, 20);
            Assert.AreEqual(60, rownoleglobok.obwod());
            
        }

    }
}