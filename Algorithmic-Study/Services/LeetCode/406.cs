using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _406
    {
        /*
         * 假设有打乱顺序的一群人站成一个队列。 每个人由一个整数对(h, k)表示，其中h是这个人的身高，k是排在这个人前面且身高大于或等于h的人数。 编写一个算法来重建这个队列。

            注意：
            总人数少于1100人。
            
            示例
            
            输入:
            [[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]]
            
            输出:
            [[5,0], [7,0], [5,2], [6,1], [4,4], [7,1]]
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/queue-reconstruction-by-height
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public int[][] ReconstructQueue(int[][] people)
            {
                Array.Sort(people, new PersonComparer());
                List<int[]> list = new List<int[]>();
                foreach (var item in people)
                {
                    list.Insert(item[1], item);
                }
                return list.ToArray();
            }
        }
        public class PersonComparer : IComparer<int[]>
        {
            public int Compare(int[] person1, int[] person2)
            {
                if (person1[0] != person2[0])
                {
                    return person2[0] - person1[0];
                }
                else
                {
                    return person1[1] - person2[1];
                }
            }
        }
    }
}
