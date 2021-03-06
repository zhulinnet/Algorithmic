﻿using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _204
    {
        /*
         * 统计所有小于非负整数 n 的质数的数量。

 

        示例 1：
        
        输入：n = 10
        输出：4
        解释：小于 10 的质数一共有 4 个, 它们是 2, 3, 5, 7 。
        示例 2：
        
        输入：n = 0
        输出：0
        示例 3：
        
        输入：n = 1
        输出：0
         
        
        提示：
        
        0 <= n <= 5 * 106
        
        来源：力扣（LeetCode）
        链接：https://leetcode-cn.com/problems/count-primes
        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public int CountPrimes(int n)
            {
                int result = 0;
                for (int i = 1; i <=n; i++)
                {
                    if (GeneralTest(i))
                    {
                        result++;
                    }
                }
                return result;
            }
            public bool GeneralTest(int number)
            {
                for (int i = 2; i * i <= number; ++i)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
