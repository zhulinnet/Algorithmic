﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _7
    {
        /*
            给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

            示例 1:

            输入: 123
            输出: 321
             示例 2:
            
            输入: -123
            输出: -321
            示例 3:
            
            输入: 120
            输出: 21
            注意:
            
            假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为 [−231,  231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/reverse-integer
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。         */
        public class Solution
        {
            public int Reverse(int x)
            {
                try
                {
                    string newInt = x>0?"":"-";
                    foreach (var item in x.ToString().Replace("-","").Reverse())
                    {
                        newInt += item;
                    }
                    return Convert.ToInt32(newInt);
                }
                catch 
                {
                    return 0;
                } 
            }
        }
        public class Solution1
        {
            public int Reverse(int x)
            {
                int num= 0;
                while (x != 0)
                {
                    int pop = x % 10;
                    x = x / 10;
                    if (num > Int32.MaxValue / 10 || (num == Int32.MaxValue / 10 && pop > 7)) return 0;
                    if (num < Int32.MinValue / 10 || (num == Int32.MinValue / 10 && pop < -8)) return 0;
                    num = 10 * num + pop;
                }
                return num;
            }
        }

    }
}
