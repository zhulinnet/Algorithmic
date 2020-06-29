using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Stack;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Stack.Tests
{
    [TestClass()]
    public class SeqStackTests
    {

        [TestMethod()]
        public void clearTest()
        {
            SeqStack<string> seqStack = new SeqStack<string>(10);
            seqStack.push("A");
            seqStack.push("B");
            seqStack.push("C");
            seqStack.clear();
            Assert.AreEqual(seqStack.isEmpty, true);
        }

        [TestMethod()]
        public void popTest()
        {
            SeqStack<string> seqStack = new SeqStack<string>(10);
            seqStack.push("A");
            seqStack.push("B");
            seqStack.push("C");
            seqStack.pop();
            Assert.AreEqual(seqStack.getTop(), "B");
        }

        [TestMethod()]
        public void pushTest()
        {
            SeqStack<string> seqStack = new SeqStack<string>(10);
            seqStack.push("A");
            seqStack.push("B");
            seqStack.push("C");
            List<string> result = new List<string>() {
               "C","B","A"
            };
            CollectionAssert.AreEqual(seqStack.display(), result);
        }

        [TestMethod()]
        public void getTopTest()
        {
            SeqStack<string> seqStack = new SeqStack<string>(10);
            seqStack.push("A");
            seqStack.push("B");
            seqStack.push("C");
            Assert.AreEqual(seqStack.getTop(),"C");
        }
    }
}