using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Queue;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Queue.Tests
{
    [TestClass()]
    public class SeqQueueTests
    {
        [TestMethod()]
        public void clearTest()
        {
            SeqQueue<string> seqQueue = new SeqQueue<string>(10);
            seqQueue.enter("A");
            seqQueue.enter("B");
            seqQueue.enter("C");
            seqQueue.enter("D");
            seqQueue.clear();
            Assert.AreEqual(seqQueue.isEmpty ,true);
        }

        [TestMethod()]
        public void enterTest()
        {
            SeqQueue<string> seqQueue = new SeqQueue<string>(10);
            seqQueue.enter("A");
            seqQueue.enter("B");
            seqQueue.enter("C");
            seqQueue.enter("D");
            seqQueue.enter("E");
            List<string> result = new List<string>() {
                "A","B","C","D","E"
            };
            CollectionAssert.AreEqual(seqQueue.display(), result);
        }

        [TestMethod()]
        public void exitTest()
        {
            SeqQueue<string> seqQueue = new SeqQueue<string>(10);
            seqQueue.enter("A");
            seqQueue.enter("B");
            seqQueue.enter("C");
            seqQueue.enter("D");
            seqQueue.enter("F");
            Assert.AreEqual(seqQueue.exit(), "A");
        }

        [TestMethod()]
        public void getFrontTest()
        {
            SeqQueue<string> seqQueue = new SeqQueue<string>(10);
            seqQueue.enter("A");
            seqQueue.enter("B");
            seqQueue.enter("C");
            seqQueue.enter("D");
            Assert.AreEqual(seqQueue.getFront(), "A");
        }

        [TestMethod()]
        public void getRearTest()
        {
            SeqQueue<string> seqQueue = new SeqQueue<string>(10);
            seqQueue.enter("A");
            seqQueue.enter("B");
            seqQueue.enter("C");
            seqQueue.enter("D");
            Assert.AreEqual(seqQueue.getRear(),"D");
        }
    }
}