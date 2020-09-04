﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _414
    {
        /*
         * 给定一个非空数组，返回此数组中第三大的数。如果不存在，则返回数组中最大的数。要求算法时间复杂度必须是O(n)。

            示例 1:
            
            输入: [3, 2, 1]
            
            输出: 1
            
            解释: 第三大的数是 1.
            示例 2:
            
            输入: [1, 2]
            
            输出: 2
            
            解释: 第三大的数不存在, 所以返回最大的数 2 .
            示例 3:
            
            输入: [2, 2, 3, 1]
            
            输出: 1
            
            解释: 注意，要求返回第三大的数，是指第三大且唯一出现的数。
            存在两个值为2的数，它们都排第二。
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/third-maximum-number
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public int ThirdMax(int[] nums)
            {
                if (nums.Length == 0)
                {
                    return 0;
                }
                var orderNums = nums.GroupBy(x => x).OrderByDescending(x => x.Key);
                var num = 0;
                if (orderNums.Count() >= 3)
                {
                    num = orderNums.Skip(2).Take(1).First().Key;
                }
                else 
                {
                    num = orderNums.Take(1).First().Key;
                }
                return num;
            }
        }
    }
}
