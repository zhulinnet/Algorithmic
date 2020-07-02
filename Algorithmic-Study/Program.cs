

using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithmStudy
{
    class Program
    { 
        public static int P { get; } = 15;
        public static int G { get; } = 1;
        static void Main(string[] args)
        {
            int x = 5,y= 3;
            double xa = Math.Pow(G, x) % P;
            double ya = Math.Pow(G, y) % P;
            Console.WriteLine(Math.Pow(xa, y) % P== Math.Pow(ya, x) % P);
        }
    }
}

