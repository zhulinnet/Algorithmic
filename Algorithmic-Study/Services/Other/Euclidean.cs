using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Other
{
    /// <summary>
    /// 欧几里得算法
    /// </summary>
    public class Euclidean
    {
        /// <summary>
        /// 求最大公约数
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns></returns>
        public int GetGCD(int numberA, int numberB)
        {
            var gcd = 0;
            var remainder = 0;
            if (numberA > numberB)
            {
                remainder = numberA % numberB;
                gcd = numberB;
            }
            else
            {
                remainder = numberB % numberA;
                gcd = numberA;
            }
            if (remainder == 0)
            {
                return gcd;
            }
            return GetGCD(remainder, gcd);
        }
    }
}
