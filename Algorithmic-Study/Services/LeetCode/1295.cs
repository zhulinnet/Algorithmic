using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _1295
    {
        /*
         * 示例 1：

        输入：nums = [12,345,2,6,7896]
        输出：2
        解释：
        12 是 2 位数字（位数为偶数） 
        345 是 3 位数字（位数为奇数）  
        2 是 1 位数字（位数为奇数） 
        6 是 1 位数字 位数为奇数） 
        7896 是 4 位数字（位数为偶数）  
        因此只有 12 和 7896 是位数为偶数的数字
        示例 2：
        
        输入：nums = [555,901,482,1771]
        输出：1 
        解释： 
        只有 1771 是位数为偶数的数字。
         
        
        提示：
        
        1 <= nums.length <= 500
        1 <= nums[i] <= 10^5
        
        来源：力扣（LeetCode）
        链接：https://leetcode-cn.com/problems/find-numbers-with-even-number-of-digits
        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public int FindNumbers(int[] nums)
            {
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i].ToString().Length % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
                //int count = 0;
                //for (int i = 0; i < nums.Length; i++)
                //{
                //    if ((int)(Math.Log10(nums[i]) + 1) % 2 == 0)
                //    {
                //        count++;
                //    }
                //}
                //return count;
            }
        }
    }
}
