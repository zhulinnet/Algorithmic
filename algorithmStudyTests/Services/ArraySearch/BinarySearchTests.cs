using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.ArraySearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.ArraySearch.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            int[] arr1 = { 1, 2, 3, 5, 6, 9, 20, 30, 70 };
            BinarySearch<int> search = new BinarySearch<int>(arr1);
            Assert.AreEqual(search.Search(1), 0);
            Assert.AreEqual(search.Search(30), 7);
            Assert.AreEqual(search.Search(80), -1);
        }
    }
}