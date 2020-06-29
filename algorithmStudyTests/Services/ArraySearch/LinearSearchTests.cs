using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.ArraySearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.ArraySearch.Tests
{
    [TestClass()]
    public class LinearSearchTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9 };
            LinearSearch<int> search = new LinearSearch<int>(arr);
            Assert.AreEqual(search.Search(1),7);
            Assert.AreEqual(search.Search(0), -1);
            Assert.AreEqual(search.Search(80), -1);
        }
    }
}