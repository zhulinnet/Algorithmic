using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Tree.Tests
{
    [TestClass()]
    public class BinaryTreeTests
    {

        [TestMethod()]
        public void indexOfTest()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(100);
            binaryTree.Add(80);
            binaryTree.Add(108);
            binaryTree.Add(70);
            binaryTree.Add(60);
            binaryTree.Add(30);
            binaryTree.Add(20);
            binaryTree.Add(8);
            binaryTree.Add(6);
            binaryTree.Add(3);
            binaryTree.Add(101);
            binaryTree.Add(102);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(15);
            binaryTree.Add(9);
            binaryTree.Add(23);
            binaryTree.Add(3);
            binaryTree.Add(12);
            binaryTree.Add(17);
            binaryTree.Add(28);
            binaryTree.Add(8);
            binaryTree.Add(1);
            binaryTree.Add(4);
            binaryTree.Remove(28);
            binaryTree.Remove(8);
            binaryTree.Remove(9);
            List<int> result = new List<int>() {
                15,12,3,1,4,23,17
            };
            List<int> reality = new List<int>();
            binaryTree.PreorderTraversal(ref reality, binaryTree.Head);
            CollectionAssert.AreEqual(reality, result);
        }

        [TestMethod()]
        public void PreorderTraversalTest()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(15);
            binaryTree.Add(9);
            binaryTree.Add(23);
            binaryTree.Add(3);
            binaryTree.Add(12);
            binaryTree.Add(17);
            binaryTree.Add(28);
            binaryTree.Add(8);
            List<int> result = new List<int>() {
               15,9,3,8,12,23,17,28
            };
            List<int> reality = new List<int>();
            binaryTree.PreorderTraversal(ref reality, binaryTree.Head);
            CollectionAssert.AreEqual(reality, result);
        }

        [TestMethod()]
        public void InorderTraversalTest()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(15);
            binaryTree.Add(9);
            binaryTree.Add(23);
            binaryTree.Add(3);
            binaryTree.Add(12);
            binaryTree.Add(17);
            binaryTree.Add(28);
            binaryTree.Add(8);
            List<int> result = new List<int>() {
            3,8,9,12,15,17,23,28
            };
            List<int> reality = new List<int>();
            binaryTree.InorderTraversal(ref reality, binaryTree.Head);
            CollectionAssert.AreEqual(reality, result);
        }

        [TestMethod()]
        public void PostorderTraversalTest()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(15);
            binaryTree.Add(9);
            binaryTree.Add(23);
            binaryTree.Add(3);
            binaryTree.Add(12);
            binaryTree.Add(17);
            binaryTree.Add(28);
            binaryTree.Add(8);
            List<int> result = new List<int>() {
                8,3,12,9,17,28,23,15
            };
            List<int> reality = new List<int>();
            binaryTree.PostorderTraversal(ref reality, binaryTree.Head);
            CollectionAssert.AreEqual(reality, result);
        }
    }
}