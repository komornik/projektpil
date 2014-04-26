using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nunit;
using NUnit.Framework;

namespace ClassLibrary1
{
<<<<<<< HEAD
=======
    class wyniki
    {
        public double zmienna;
        public double wynik;
        public double wysokosc;
        public double podstawa_c;

        public double podstawa_b{
            get { return wysokosc; }
        }

        public double podstawa_a
        {
            get { return zmienna;}
        }

        public wyniki(double zmienna, double wynik)
        {
            this.zmienna = zmienna;
            this.wynik = wynik;
        }

        public wyniki(double podstawa, double wysokosc, double wynik)
        {
            this.zmienna = podstawa;
            this.wynik = wynik;
            this.wysokosc=wysokosc;
        }
        public wyniki(double podstawa_a, double podstawa_b,double podstawa_c, double wynik)
        {
            this.zmienna = podstawa_a;
            this.wynik = wynik;
            this.wysokosc = podstawa_b;
            this.podstawa_c = podstawa_c;
        }

    }
>>>>>>> krzysztof_test
    [TestFixture]
    public class KrzysztofSimonTest
    {
        [Test]
        public void TestOkragPole()
        {
<<<<<<< HEAD
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
=======
            List<wyniki> dane = new List<wyniki>();
            dane.Add(new wyniki(2,12.56));
            dane.Add(new wyniki(-50,-1));
            dane.Add(new wyniki(1.4,6.1544));
            Okrag o = new Okrag();
            foreach (var a in dane){
                o.promien = a.zmienna;
                Assert.AreEqual(a.wynik, o.pole());
            }
        }

        [Test]
        public void TestOkragObwod()
        {
            List<wyniki> dane = new List<wyniki>();
            dane.Add(new wyniki(2, 12.56));
            dane.Add(new wyniki(-50, -1));
            dane.Add(new wyniki(3, 18.84));
            foreach (var a in dane)
            {
                Okrag o = new Okrag();
                o.promien = a.zmienna;
                Assert.AreEqual(a.wynik, o.obwod());
            }

        }

        [Test]
        public void TestTrojkatPole()
        {
            List<wyniki> dane = new List<wyniki>();
            dane.Add(new wyniki(3,3,4.5));
            dane.Add(new wyniki(-1,2,-1));
            dane.Add(new wyniki(1,-2,-1));
            dane.Add(new wyniki(10, 6, 30));

            Trojkat t = new Trojkat();

            foreach (var a in dane)
            {
                t.Wysokosc = a.wysokosc;
                t.Szerokosc = a.zmienna;
                Assert.AreEqual(a.wynik, t.pole());
            }
        }

        [Test]
        public void TestTrojkatObwod()
        {
            List<wyniki> dane = new List<wyniki>();
            dane.Add(new wyniki(1, 2, 3, 6));
            dane.Add(new wyniki(-1, 2, 3, -1));
            dane.Add(new wyniki(1, -2, 3, -1));
            dane.Add(new wyniki(1, 2, -3, -1));
            dane.Add(new wyniki(20.5,13,12.789,46.289));
            
            foreach (var a in dane)
            {
                Trojkat t = new Trojkat();
                t.bok_b = a.podstawa_b;
                t.bok_c = a.podstawa_c;
                t.bok_a = a.podstawa_a;
                Assert.AreEqual(a.wynik, t.obwod());

            }
        }
    }

        
>>>>>>> krzysztof_test
}
