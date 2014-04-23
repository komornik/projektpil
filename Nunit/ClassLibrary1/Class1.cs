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
        public void TestCalculatorAdding()
        {
            Okrag o = new Okrag();
            o.promien = 2;
            string sol = Convert.ToString(o.pole());
            Assert.AreEqual("12,5663706143592", sol);
        }
    }
}
