using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Nunit

namespace Project1
{
    [TestFixture]
    class Class1
    {
    [Test]
        public void TestCalculatorAdding()
    {
        Okrag o = new Okrag();
        o.promien=2;
        string sol = Convert.ToString(o.pole());
        Assert.AreEqual("30",sol); 
    }
    }
}
