using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using algorithmStudy.Models.LinkedList;

namespace algorithmStudy.Services.LinkedList.Tests
{
    [TestClass()]
    public class SinglyLinkTests
    {
        [TestMethod()]
        public void insertTest()
        {
            SinglyLink<string> singly = new SinglyLink<string>();
            singly.Head = new Node<string>("B");
            singly.insert(0, "A");
            singly.insert(1, "C");
            singly.insert(2, "S");
            List<string> result = new List<string>() {
               "A","C","S","B"
            };
            CollectionAssert.AreEqual(singly.display(), result);
        }

        [TestMethod()]
        public void appendTest()
        {
            SinglyLink<string> singly = new SinglyLink<string>();
            singly.Head = new Node<string>("B");
            singly.append("D");
            singly.append("E");
            List<string> result = new List<string>() {
               "B","D","E"
            };
            CollectionAssert.AreEqual(singly.display(), result);
        }

        [TestMethod()]
        public void prependTest()
        {
            SinglyLink<string> singly = new SinglyLink<string>();
            singly.Head = new Node<string>("B");
            singly.prepend("D");
            singly.prepend("E");
            List<string> result = new List<string>() {
             "E","D","B"
            };
            CollectionAssert.AreEqual(singly.display(), result);
        }

        [TestMethod()]
        public void removeTest()
        {
            SinglyLink<string> singly = new SinglyLink<string>();
            singly.Head = new Node<string>("B");
            singly.prepend("A");
            singly.append("C");
            singly.append("D");
            singly.append("E");
            singly.append("F");
            singly.append("G");
            singly.append("H");
            singly.remove(0);
            singly.remove(2);
            singly.remove(5);
            List<string> result = new List<string>() {
              "B","C","E","F","G"
            };
            CollectionAssert.AreEqual(singly.display(), result);
        }

        [TestMethod()]
        public void indexOfTest()
        {
            SinglyLink<string> singly = new SinglyLink<string>();
            singly.Head = new Node<string>("B");
            singly.prepend("A");
            singly.append("C");
            singly.append("D");
            singly.append("E");
            singly.append("F");
            singly.append("G");
            singly.append("H");
            Assert.AreEqual(singly.indexOf("F"), 5);
        }

        [TestMethod()]
        public void getTest()
        {
            SinglyLink<string> singly = new SinglyLink<string>();
            singly.Head = new Node<string>("B");
            singly.prepend("A");
            singly.append("C");
            singly.append("D");
            singly.append("E");
            singly.append("F");
            singly.append("G");
            singly.append("H");
            Assert.AreEqual(singly.get(5), "F");
        }
        [TestMethod()]
        public void clearTest()
        {
            SinglyLink<string> singly = new SinglyLink<string>();
            singly.Head = new Node<string>("B");
            singly.prepend("A");
            singly.append("C");
            singly.append("D");
            singly.append("E");
            singly.append("F");
            singly.append("G");
            singly.append("H");
            Assert.AreEqual(singly.isEmpty, false);
            singly.clear();
            Assert.AreEqual(singly.length, 0);
            Assert.AreEqual(singly.isEmpty, true);
        }
    }
}