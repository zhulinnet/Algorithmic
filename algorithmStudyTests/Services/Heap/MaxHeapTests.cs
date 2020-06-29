using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Heap;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Heap.Tests
{
    [TestClass()]
    public class MaxHeapTests
    {

        [TestMethod()]
        public void PushTest()
        {
            MaxHeap<int> maxHeap = new MaxHeap<int>(10);
            maxHeap.Push(10);
            maxHeap.Push(2);
            maxHeap.Push(3);
            maxHeap.Push(1);
            maxHeap.Push(5);
            List<int> result = new List<int>() {
                10,5,3,1,2
            };
            CollectionAssert.AreEqual(maxHeap.display(), result);
        }

        [TestMethod()]
        public void PopTest()
        {
            MaxHeap<int> maxHeap = new MaxHeap<int>(10);
            maxHeap.Push(10);
            maxHeap.Push(2);
            maxHeap.Push(3);
            maxHeap.Push(1);
            maxHeap.Push(5);
            Assert.AreEqual(maxHeap.Pop(), 10);
            List<int> result = new List<int>() {
                5,2,3,1
            };
            CollectionAssert.AreEqual(maxHeap.display(), result);
        }
    }
}