﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Graph.Tests
{
    [TestClass()]
    public class WeightedGraphTests
    {
        [TestMethod()]
        public void BellmanFordTest()
        {
            WeightedGraph<string> weightedGraph = new WeightedGraph<string>();
            List<WeightedGraphNode<string>> seed = new List<WeightedGraphNode<string>>
            {
                new WeightedGraphNode<string>() { Data = "A",Weight=0, Children = new Dictionary<string, double>{  {"B",9},{"C",2} }  },
                new WeightedGraphNode<string>() { Data = "B", Children = new Dictionary<string, double>{ { "A", 9 }, { "C", 6 }, { "D",3},{"E",1} }  },
                new WeightedGraphNode<string>() { Data = "C", Children = new Dictionary<string, double>{ { "A", 2 }, { "B",6},{"D",2}, { "F", 9 } }  },
                new WeightedGraphNode<string>() { Data = "D", Children = new Dictionary<string, double>{  {"B",3},{"C",2}, { "E", 5 } , { "F", 6 } }  },
                new WeightedGraphNode<string>() { Data = "E", Children = new Dictionary<string, double>{  {"B",1},{"D",5}, { "F", 3 }, { "G", 7 } }  },
                new WeightedGraphNode<string>() { Data = "F", Children = new Dictionary<string, double>{  {"C",9},{"D",6}, { "E", 3 } , { "G", 4 } } },
                new WeightedGraphNode<string>() { Data = "G", Children =new Dictionary<string, double>{  {"E",7},{"F",4} } },
            };
            weightedGraph.NodeList = seed;
       
            List<string> result = new List<string>() {
                "A","C","D","F","G"
            };
            List<string> path = new List<string>();
            weightedGraph.BellmanFord();
            weightedGraph.GetShortest(ref path,"A", "G");
            path.Reverse();
            CollectionAssert.AreEqual(path, result);
        }

        [TestMethod()]
        public void DijkstraTest()
        {
            WeightedGraph<string> weightedGraph = new WeightedGraph<string>();
            List<WeightedGraphNode<string>> seed = new List<WeightedGraphNode<string>>
            {
                new WeightedGraphNode<string>() { Data = "A",Weight=0, Children = new Dictionary<string, double>{  {"B",2},{"C",5} }  },
                new WeightedGraphNode<string>() { Data = "B", Children = new Dictionary<string, double>{ { "A", 2 }, { "C", 6 }, { "D",1},{"E",3} }  },
                new WeightedGraphNode<string>() { Data = "C", Children = new Dictionary<string, double>{ { "A", 5 }, { "B",6},{ "F", 8 } }  },
                new WeightedGraphNode<string>() { Data = "D", Children = new Dictionary<string, double>{  {"B",1}, { "E", 4 } }  },
                new WeightedGraphNode<string>() { Data = "E", Children = new Dictionary<string, double>{  {"B",3},{"D",4}, { "G", 9 }}  },
                new WeightedGraphNode<string>() { Data = "F", Children = new Dictionary<string, double>{  {"C",8},{ "G", 7 } } },
                new WeightedGraphNode<string>() { Data = "G", Children =new Dictionary<string, double>{  {"E",9},{"F",7} } },
            };
            weightedGraph.NodeList = seed;
            weightedGraph.Dijkstra("A","G");
            List<string> result = new List<string>() {
                "A","B","E","G"
            };
            List<string> path = new List<string>();
            weightedGraph.GetShortest(ref path, "A", "G");
            path.Reverse();
            CollectionAssert.AreEqual(path, result);
        }
    }
}