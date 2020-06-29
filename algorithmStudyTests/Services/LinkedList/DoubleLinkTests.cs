using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using algorithmStudy.Models.LinkedList;

namespace algorithmStudy.Services.LinkedList.Tests
{
    [TestClass()]
    public class DoubleLinkTests
    {

        [TestMethod()]
        public void appendTest()
        {
            DoubleLink<string> doubleL = new DoubleLink<string>(new Node<string>("B"));
            doubleL.append("D");
            doubleL.append("E");
            List<string> result = new List<string>() {
               "B","D","E"
            };
            CollectionAssert.AreEqual(doubleL.display(), result);
        }

        [TestMethod()]
        public void clearTest()
        {
            DoubleLink<string> doubleL = new DoubleLink<string>(new Node<string>("B"));
            doubleL.prepend("A");
            doubleL.append("C");
            doubleL.append("D");
            doubleL.append("E");
            doubleL.append("F");
            doubleL.append("G");
            doubleL.append("H");
            Assert.AreEqual(doubleL.isEmpty, false);
            doubleL.clear();
            Assert.AreEqual(doubleL.length, 0);
            Assert.AreEqual(doubleL.isEmpty, true);
        }

        [TestMethod()]
        public void getTest()
        {
            DoubleLink<string> doubleL = new DoubleLink<string>(new Node<string>("B"));
            doubleL.prepend("A");
            doubleL.append("C");
            doubleL.append("D");
            doubleL.append("E");
            doubleL.append("F");
            doubleL.append("G");
            doubleL.append("H");
            Assert.AreEqual(doubleL.get(5), "F");
        }

        [TestMethod()]
        public void indexOfTest()
        {
            DoubleLink<string> doubleL = new DoubleLink<string>(new Node<string>("B"));
            doubleL.prepend("A");
            doubleL.append("C");
            doubleL.append("D");
            doubleL.append("E");
            doubleL.append("F");
            doubleL.append("G");
            doubleL.append("H");
            Assert.AreEqual(doubleL.indexOf("F"), 5);
        }

        [TestMethod()]
        public void insertTest()
        {
            DoubleLink<string> doubleL = new DoubleLink<string>(new Node<string>("B"));
            doubleL.insert(0, "A");
            doubleL.insert(1, "C");
            doubleL.insert(2, "S");
            List<string> result = new List<string>() {
               "A","C","S","B"
            };
            CollectionAssert.AreEqual(doubleL.display(), result);
        }

        [TestMethod()]
        public void prependTest()
        {
            DoubleLink<string> doubleL = new DoubleLink<string>(new Node<string>("B"));
            doubleL.prepend("D");
            doubleL.prepend("E");
            List<string> result = new List<string>() {
             "E","D","B"
            };
            CollectionAssert.AreEqual(doubleL.display(), result);
        }

        [TestMethod()]
        public void removeTest()
        {
            DoubleLink<string> doubleL = new DoubleLink<string>(new Node<string>("B"));
            doubleL.prepend("A");
            doubleL.append("C");
            doubleL.append("D");
            doubleL.append("E");
            doubleL.append("F");
            doubleL.append("G");
            doubleL.append("H");
            doubleL.remove(0);
            doubleL.remove(2);
            doubleL.remove(5);
            List<string> result = new List<string>() {
              "B","C","E","F","G"
            };
            CollectionAssert.AreEqual(doubleL.display(), result);
        }
    }
}