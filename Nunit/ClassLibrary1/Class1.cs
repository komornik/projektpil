using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nunit;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class KrzysztofSimonTest
    {
        [Test]
        public void TestOkragPole()
        {
            Okrag o = new Okrag();
            o.promien = 2;
            string sol = Convert.ToString(o.pole());
            Assert.AreEqual("12,56", sol);
        }

        [Test]
        public void TestOkragPole2()
        {
            Okrag o = new Okrag();
            o.promien=-50;
            string sol = Convert.ToString(o.pole());
            Assert.AreEqual("-1", sol);
        }

        [Test]
        public void TestOkragPole3()
        {
            Okrag o = new Okrag();
            o.promien = 1.4;
            string sol = Convert.ToString(o.pole());
            Assert.AreEqual("6,1544", sol);
        }

        
    }
}
