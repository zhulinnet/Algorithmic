using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Other;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Other.Tests
{
    [TestClass()]
    public class EuclideanTests
    {
        [TestMethod()]
        public void GetGCDTest()
        {
            Euclidean euc = new Euclidean();
            Assert.AreEqual(euc.GetGCD(1112, 695),139);
        }
    }
}