using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _442
    {
        /*
         * 给定一个整数数组 a，其中1 ≤ a[i] ≤ n （n为数组长度）, 其中有些元素出现两次而其他元素出现一次。

            找到所有出现两次的元素。
            
            你可以不用到任何额外空间并在O(n)时间复杂度内解决这个问题吗？
            
            示例：
            
            输入:
            [4,3,2,7,8,2,3,1]
            
            输出:
            [2,3]
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/find-all-duplicates-in-an-array
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public IList<int> FindDuplicates(int[] nums)
            {
                List<int> result = new List<int>();
                var numList = nums.GroupBy(x => x).Where(x => x.Count() >= 2);
                foreach (var item in numList)
                {
                    for (int i = 1; i < item.Count(); i++)
                    {
                        result.Add(item.Key);
                    }
                }
                return result;
            }
        }
    }
}
