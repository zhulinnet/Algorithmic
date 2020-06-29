using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Heap;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Heap.Tests
{
    [TestClass()]
    public class MinHeapTests
    {

        [TestMethod()]
        public void PushTest()
        {
            MinHeap<int> minHeap = new MinHeap<int>(10);
            minHeap.Push(10);
            minHeap.Push(2);
            minHeap.Push(3);
            minHeap.Push(1);
            minHeap.Push(5);
            List<int> result = new List<int>() {
                1,2,3,10,5
            };
            CollectionAssert.AreEqual(minHeap.display(), result);
        }

        [TestMethod()]
        public void PopTest()
        {
            MinHeap<int> minHeap = new MinHeap<int>(10);
            minHeap.Push(10);
            minHeap.Push(2);
            minHeap.Push(3);
            minHeap.Push(1);
            minHeap.Push(5);
            minHeap.Push(7);
            Assert.AreEqual(minHeap.Pop(), 1);
            List<int> result = new List<int>() {
                2,5,3,10,7
            };
            CollectionAssert.AreEqual(minHeap.display(), result);
        }
    }
}