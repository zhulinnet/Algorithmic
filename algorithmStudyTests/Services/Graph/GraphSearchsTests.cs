using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Graph.Tests
{
    [TestClass()]
    public class GraphSearchsTests
    {
        [TestMethod()]
        public void BFSTest()
        {
            GraphSearchs<string> graphSearchs = new GraphSearchs<string>();
            List<GraphNode<string>> seed = new List<GraphNode<string>>
            {
                new GraphNode<string>() { Data = "A", Children = new[] { "B", "C", "D" } },
                new GraphNode<string>() { Data = "B", Children = new[] { "E", "F" } },
                new GraphNode<string>() { Data = "C", Children = new[] { "H" } },
                new GraphNode<string>() { Data = "D", Children = new[] { "I", "J" } },
                new GraphNode<string>() { Data = "E", Children = new[] { "K" } },
                new GraphNode<string>() { Data = "F", Children =null},
                new GraphNode<string>() { Data = "H", Children = new[] { "G" } },
                new GraphNode<string>() { Data = "I", Children =null},
                new GraphNode<string>() { Data = "J", Children = new[] { "L" } },
                new GraphNode<string>() { Data = "K", Children =null},
                new GraphNode<string>() { Data = "G", Children =null},
                new GraphNode<string>() { Data = "L", Children =null},
            };
            graphSearchs.NodeList = seed;
            List<string> result = new List<string>() {
                "A","B","C","D","E","F","H","I","J","K"
            };
            List<string> path = new List<string>();
            graphSearchs.BFS(ref path, "A", "G");
            CollectionAssert.AreEqual(path, result);
        }

        [TestMethod()]
        public void BFSTest1()
        {
            GraphSearchs<string> graphSearchs = new GraphSearchs<string>();
            graphSearchs.NodeList = graphSearchs.InitSeed();
            List<string> result = new List<string>() {
                "Alice","Bob","Diana","Fred","Cynthia","Elise"
            };
            List<string> path = new List<string>();
            graphSearchs.BFS(ref path, "Alice");
            CollectionAssert.AreEqual(path, result);
        }

        [TestMethod()]
        public void DFSTest()
        {
            GraphSearchs<string> graphSearchs = new GraphSearchs<string>();
            List<GraphNode<string>> seed = new List<GraphNode<string>>
            {
                new GraphNode<string>() { Data = "A", Children = new[] { "B", "C", "D" } },
                new GraphNode<string>() { Data = "B", Children = new[] { "E", "F" } },
                new GraphNode<string>() { Data = "C", Children = new[] { "H" } },
                new GraphNode<string>() { Data = "D", Children = new[] { "I", "J" } },
                new GraphNode<string>() { Data = "E", Children = new[] { "K" } },
                new GraphNode<string>() { Data = "F", Children =null},
                new GraphNode<string>() { Data = "H", Children = new[] { "G" } },
                new GraphNode<string>() { Data = "I", Children =null},
                new GraphNode<string>() { Data = "J", Children = new[] { "L" } },
                new GraphNode<string>() { Data = "K", Children =null},
                new GraphNode<string>() { Data = "G", Children =null},
                new GraphNode<string>() { Data = "L", Children =null},
            };
            graphSearchs.NodeList = seed;
            List<string> result = new List<string>() {
                "A","D","J","L","I","C","H"
            };
            List<string> path = new List<string>();
            graphSearchs.DFS(ref path, "A", "G");
            CollectionAssert.AreEqual(path, result);
        }

        [TestMethod()]
        public void DFSTest1()
        {
            GraphSearchs<string> graphSearchs = new GraphSearchs<string>();
            graphSearchs.NodeList = graphSearchs.InitSeed();
            List<string> result = new List<string>() {
                "Alice","Fred","Elise","Diana","Bob","Cynthia"
            };
            List<string> path = new List<string>();
            graphSearchs.DFS(ref path, "Alice");
            CollectionAssert.AreEqual(path, result);
        }
    }
}