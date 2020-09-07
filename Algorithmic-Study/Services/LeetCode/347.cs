using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _347
    {
        /*
         * 347. 前 K 个高频元素
            给定一个非空的整数数组，返回其中出现频率前 k 高的元素。
            
             
            
            示例 1:
            
            输入: nums = [1,1,1,2,2,3], k = 2
            输出: [1,2]
            示例 2:
            
            输入: nums = [1], k = 1
            输出: [1]
             
            
            提示：
            
            你可以假设给定的 k 总是合理的，且 1 ≤ k ≤ 数组中不相同的元素的个数。
            你的算法的时间复杂度必须优于 O(n log n) , n 是数组的大小。
            题目数据保证答案唯一，换句话说，数组中前 k 个高频元素的集合是唯一的。
            你可以按任意顺序返回答案。
         */
        public class Solution
        {
            public int[] TopKFrequent(int[] nums, int k)
            {
                int[] result = new int[k];
                var numList = nums.GroupBy(x => x).OrderByDescending(x => x.Count());
                var i = 0;
                foreach (var item in numList)
                {
                    if (i < k)
                    {
                        result[i] = item.Key;
                        i++;
                    }
                }
                return result;
            }
        }
        public class Solution1
        {
            public int[] TopKFrequent(int[] nums, int k)
            {
                int[] result = new int[k];
                SortedList<int, int> keyValues = new SortedList<int, int>();
                foreach (var item in nums)
                {
                    if (keyValues.ContainsKey(item))
                    {
                        var count = keyValues[item];
                        keyValues.Remove(item);
                        keyValues.Add(item, ++count);
                    }
                    else
                    {
                        keyValues.Add(item, 1);
                    }
                }
               
                for (int i = 0; i < k; i++)
                {
                    int top=keyValues.OrderByDescending(x => x.Value).First().Key;
                    result[i] = top;
                    keyValues.Remove(top);
                }
                //var i = 0;
                //foreach (var item in keyValues.OrderByDescending(x => x.Value))
                //{

                //    if (i < k)
                //    {
                //        result[i] = item.Key;
                //        i++;
                //    }
                //}
                return result;
            }
        }
    }

}


