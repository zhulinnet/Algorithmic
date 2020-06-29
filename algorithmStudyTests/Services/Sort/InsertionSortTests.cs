using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Sort;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Sort.Tests
{
    [TestClass()]
    public class InsertionSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9 };
            InsertionSort<int> sort = new InsertionSort<int>(arr);
            List<int> result = new List<int>() {
                1,2,3,5,6,9,20,30,70
            };
            CollectionAssert.AreEqual(sort.Sort(), result);
        }
    }
}