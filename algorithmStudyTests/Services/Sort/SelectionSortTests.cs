using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Sort;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Sort.Tests
{
    [TestClass()]
    public class SelectionSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9 };
            SelectionSort<int> sort = new SelectionSort<int>(arr);
            List<int> result = new List<int>() {
                1,2,3,5,6,9,20,30,70
            };
            CollectionAssert.AreEqual(sort.Sort(), result);
        }
    }
}