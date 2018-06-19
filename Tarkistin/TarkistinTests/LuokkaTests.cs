using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tarkistin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkistin.Tests
{
    [TestClass()]
    public class LuokkaTests
    {
        [TestMethod()]
        public void HeTuOkTest()
        {
            Luokka t = new Luokka();
            string hetu = "311092-2008";
            bool expected = true;
            bool actual = t.HeTuOk(hetu);
            Assert.AreEqual(expected, actual, "Joku pielessä, pitäisi olla ok hetu");
        }
    }
}