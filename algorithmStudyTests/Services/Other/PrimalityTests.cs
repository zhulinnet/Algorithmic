using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Other;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Other.Tests
{
    [TestClass()]
    public class PrimalityTests
    {
        [TestMethod()]
        public void GeneralTestTest()
        {
            Primality p = new Primality();
            Assert.AreEqual(p.GeneralTest(3599), false);
            Assert.AreEqual(p.GeneralTest(113), true);
        }

        [TestMethod()]
        public void FermatTestTest()
        {
            Primality p = new Primality();
            Assert.AreEqual(p.FermatTest(3599), false);
            Assert.AreEqual(p.GeneralTest(113), true);
        }
    }
}