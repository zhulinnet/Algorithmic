using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _485
    {
        /*
         * 给定一个二进制数组， 计算其中最大连续1的个数。

            示例 1:
            
            输入: [1,1,0,1,1,1]
            输出: 3
            解释: 开头的两位和最后的三位都是连续1，所以最大连续1的个数是 3.
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/max-consecutive-ones
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public int FindMaxConsecutiveOnes(int[] nums)
            {
                int count = 0,maxCount=0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] !=1)
                    {
                        
                        count = 0;
                        if (nums.Length - (i + 1) < maxCount)
                        {
                            break;
                        }
                        continue;
                    }
                    count++;
                    maxCount = maxCount > count ? maxCount : count;
                }
                return maxCount;
            }
        }
    }
}
