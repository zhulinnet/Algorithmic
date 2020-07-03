

using algorithmStudy.Services.Clustering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithmStudy
{
    class Program
    { 
        static void Main(string[] args)
        {
            Hanoi hanoi = new Hanoi();
            hanoi.Move('A','B','C',5);
        }
    }
}

