using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Clustering
{
    public class Hanoi
    {
        public  void Move(char A, char B, char C, int count)
        {
            if (count == 1)
            {
                Console.WriteLine($"第1号圆盘，从{A}移动到{B}");
            }
            else
            {
                Move(A, C, B, count - 1);
                Console.WriteLine($"第{count}号圆盘，从{A}移动到{B}");
                Move(C, B, A, count - 1);
            }
        }
    }
}
