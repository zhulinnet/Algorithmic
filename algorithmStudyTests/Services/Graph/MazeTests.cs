using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Graph.Tests
{
    [TestClass()]
    public class MazeTests
    {
        [TestMethod()]
        public void AStarTest()
        {
            string[,] graph = new string[7, 7]
                {
                    {"A","B" ,"C",null,null,null,null},
                    {"D",null,"E",null,null,null,null},
                    {"F",null,"G","H" ,"I" ,"J" ,"K"},
                    {"L",null,"M",null,null,null,"N"},
                    {"O",null,"P",null,"Q" ,"R" ,"S"},
                    {"T",null,"U",null,"V" ,null,null},
                    {"W","X" ,"Y","Z" ,"A1","A2","A3"}
                };
            Maze maze = new Maze(graph);
            maze.AStar(new MazePointer() { X=2,Y=2}, new MazePointer() { X = 6, Y = 6 });
            List<string> path = new List<string>();
            maze.GetShortest(ref path,new MazePointer() { X = 2, Y = 2 }, new MazePointer() { X = 6, Y = 6 });
            List<string> result = new List<string>() {
                "A3","A2","A1","Z","Y","U","P","M","G"
            };
            CollectionAssert.AreEqual(path,result);
        }
    }
}