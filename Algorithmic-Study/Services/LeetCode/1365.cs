using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _1365
    {
        /*
         * 给你一个数组 nums，对于其中每个元素 nums[i]，请你统计数组中比它小的所有数字的数目。

            换而言之，对于每个 nums[i] 你必须计算出有效的 j 的数量，其中 j 满足 j != i 且 nums[j] < nums[i] 。
            
            以数组形式返回答案。
            
             
            
            示例 1：
            
            输入：nums = [8,1,2,2,3]
            输出：[4,0,1,1,3]
            解释： 
            对于 nums[0]=8 存在四个比它小的数字：（1，2，2 和 3）。 
            对于 nums[1]=1 不存在比它小的数字。
            对于 nums[2]=2 存在一个比它小的数字：（1）。 
            对于 nums[3]=2 存在一个比它小的数字：（1）。 
            对于 nums[4]=3 存在三个比它小的数字：（1，2 和 2）。
            示例 2：
            
            输入：nums = [6,5,4,8]
            输出：[2,1,0,3]
            示例 3：
            
            输入：nums = [7,7,7,7]
            输出：[0,0,0,0]
             
            
            提示：
            
            2 <= nums.length <= 500
            0 <= nums[i] <= 100
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/how-many-numbers-are-smaller-than-the-current-number
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public int[] SmallerNumbersThanCurrent(int[] nums)
            {
                int[] result = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (i != j)
                        {
                            if (nums[i] > nums[j])
                            {
                                count++;
                            }
                        }
                    }
                    result[i] = count;
                }
                return result;
            }
        }
        public class Solution1
        {
            public int[] SmallerNumbersThanCurrent(int[] nums)
            {
                int n = nums.Length;
                int[][] data = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    data[i] = new int[2];
                    data[i][0] = nums[i];
                    data[i][1] = i;
                }
                Array.Sort(data, (p1, p2) => p1[0].CompareTo(p2[0]));
                int[] ret = new int[n];
                int prev = -1;
                for (int i = 0; i < n; i++)
                {
                    if (prev == -1 || data[i][0] != data[i - 1][0])
                    {
                        prev = i;
                    }
                    ret[data[i][1]] = prev;
                }
                return ret;
            }
        }
        public class Solution2
        {
            public int[] SmallerNumbersThanCurrent(int[] nums)
            {
                int[] cnt = new int[101];
                int n = nums.Length;
                for (int i = 0; i < n; i++)
                {
                    cnt[nums[i]]++;
                }
                for (int i = 1; i <= 100; i++)
                {
                    cnt[i] += cnt[i - 1];
                }
                int[] ret = new int[n];
                for (int i = 0; i < n; i++)
                {
                    ret[i] = nums[i] == 0 ? 0 : cnt[nums[i] - 1];
                }
                return ret;

            }
        }
    }
}
