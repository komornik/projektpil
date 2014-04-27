using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Nunit;


namespace ClassLibrary2
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void test()
        {
            Krzysztof k = new Krzysztof();
            Assert.AreEqual(1, k.kk());
        }
    }
}
