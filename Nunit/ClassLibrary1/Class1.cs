using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nunit;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestokragPole()
        {
            Okrag o = new Okrag();
            o.promien = 2;
            string sol = Convert.ToString(o.pole());
            Assert.AreEqual("12,56", sol);
        }

        [Test]
        public void TestokragPole2()
        {
            Okrag o = new Okrag();
            o.promien=-50;
            string sol = Convert.ToString(o.pole());
            Assert.AreEqual("-1", sol);
        }

        [Test]
        public void TestokragPole3()
        {
            Okrag o = new Okrag();
            o.promien = 1.4;
            string sol = Convert.ToString(o.pole());
            Assert.AreEqual("6,1544", sol);
        }

        
    }
}
