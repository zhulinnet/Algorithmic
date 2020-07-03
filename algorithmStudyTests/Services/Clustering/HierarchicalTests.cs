using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Clustering;
using System;
using System.Collections.Generic;
using System.Text;
using algorithmStudy.Models.Clustering;

namespace algorithmStudy.Services.Clustering.Tests
{
    [TestClass()]
    public class HierarchicalTests
    {
        [TestMethod()]
        public void ComputeTest()
        {
            List<Pointer> pointers = new List<Pointer>() {
                new  Pointer(){X=1,Y=21,Z=0 },
                new  Pointer(){X=12,Y=23,Z=0 },
                new  Pointer(){X=10,Y=2,Z=0 },
                new  Pointer(){X=3,Y=10,Z=0 },
                new  Pointer(){X=13,Y=12,Z=0 },
                new  Pointer(){X=4,Y=15,Z=0 },
                new  Pointer(){X=9,Y=6,Z=0 },
                new  Pointer(){X=21,Y=8,Z=0 },
                new  Pointer(){X=11,Y=6,Z=0 },
                new  Pointer(){X=21,Y=9,Z=0 },
                new  Pointer(){X=13,Y=6,Z=0 },
                new  Pointer(){X=20,Y=19,Z=0 },
                  new  Pointer(){X=20,Y=19,Z=0 },
                      new  Pointer(){X=1,Y=21,Z=0 },
                new  Pointer(){X=12,Y=23,Z=0 },
                new  Pointer(){X=10,Y=2,Z=0 },
                new  Pointer(){X=3,Y=10,Z=0 },
                new  Pointer(){X=13,Y=12,Z=0 },
                new  Pointer(){X=4,Y=15,Z=0 },
                new  Pointer(){X=9,Y=6,Z=0 },
                new  Pointer(){X=21,Y=8,Z=0 },
                new  Pointer(){X=11,Y=6,Z=0 },
                new  Pointer(){X=21,Y=9,Z=0 },
                new  Pointer(){X=13,Y=6,Z=0 },
                new  Pointer(){X=20,Y=19,Z=0 },
                  new  Pointer(){X=20,Y=19,Z=0 },
            };
            Hierarchical kmeans = new Hierarchical(pointers);
            kmeans.Compute(3);
        }
    }
}