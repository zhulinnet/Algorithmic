using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using algorithmStudy.Models.LinkedList;

namespace algorithmStudy.Services.LinkedList.Tests
{
    [TestClass()]
    public class LoopLinkTests
    {

        [TestMethod()]
        public void clearTest()
        {
            LoopLink<string> loop = new LoopLink<string>();
            loop.Head = new Node<string>("B");
            loop.Tail = new Node<string>("B");
            loop.Head.Next = loop.Head;
            loop.prepend("A");
            loop.append("C");
            loop.append("D");
            loop.append("E");
            loop.append("F");
            loop.append("G");
            loop.append("H");
            Assert.AreEqual(loop.isEmpty, false);
            loop.clear();
            Assert.AreEqual(loop.length, 0);
            Assert.AreEqual(loop.isEmpty, true);
        }
        [TestMethod()]
        public void insertTest()
        {
            LoopLink<string> loop = new LoopLink<string>();
            loop.Head = new Node<string>("B");
            loop.Tail = new Node<string>("B");
            loop.Head.Next = loop.Head;
            loop.insert(0, "A");
            loop.insert(1, "C");
            loop.insert(2, "S");
            List<string> result = new List<string>() {
               "A","C","S","B"
            };
            CollectionAssert.AreEqual(loop.display(), result);
        }

        [TestMethod()]
        public void appendTest()
        {
            LoopLink<string> loop = new LoopLink<string>();
            loop.Head = new Node<string>("B");
            loop.Tail = new Node<string>("B");
            loop.Head.Next = loop.Head;
            loop.append("D");
            loop.append("E");
            List<string> result = new List<string>() {
               "B","D","E"
            };
            CollectionAssert.AreEqual(loop.display(), result);
        }

        [TestMethod()]
        public void prependTest()
        {
            LoopLink<string> loop = new LoopLink<string>();
            loop.Head = new Node<string>("B");
            loop.Tail = new Node<string>("B");
            loop.Head.Next = loop.Head;
            loop.prepend("D");
            loop.prepend("E");
            List<string> result = new List<string>() {
             "E","D","B"
            };
            CollectionAssert.AreEqual(loop.display(), result);
        }

        [TestMethod()]
        public void removeTest()
        {
            LoopLink<string> loop = new LoopLink<string>();
            loop.Head = new Node<string>("B");
            loop.Tail = new Node<string>("B");
            loop.Head.Next = loop.Head;
            loop.prepend("A");
            loop.append("C");
            loop.append("D");
            loop.append("E");
            loop.append("F");
            loop.append("G");
            loop.append("H");
            loop.remove(0);
            loop.remove(2);
            loop.remove(5);
            List<string> result = new List<string>() {
              "B","C","E","F","G"
            };
            CollectionAssert.AreEqual(loop.display(), result);
        }

        [TestMethod()]
        public void indexOfTest()
        {
            LoopLink<string> loop = new LoopLink<string>();
            loop.Head = new Node<string>("B");
            loop.Tail = new Node<string>("B");
            loop.Head.Next = loop.Head;
            loop.prepend("A");
            loop.append("C");
            loop.append("D");
            loop.append("E");
            loop.append("F");
            loop.append("G");
            loop.append("H");
            Assert.AreEqual(loop.indexOf("F"), 5);
        }
        [TestMethod()]
        public void getTest()
        {
            LoopLink<string> loop = new LoopLink<string>();
            loop.Head = new Node<string>("B");
            loop.Tail = new Node<string>("B");
            loop.Head.Next = loop.Head;
            loop.prepend("A");
            loop.append("C");
            loop.append("D");
            loop.append("E");
            loop.append("F");
            loop.append("G");
            loop.append("H");
            Assert.AreEqual(loop.get(5), "F");
        }
    }
}