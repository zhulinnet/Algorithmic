using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _763
    {
        /*
         * 字符串 S 由小写字母组成。我们要把这个字符串划分为尽可能多的片段，同一个字母只会出现在其中的一个片段。返回一个表示每个字符串片段的长度的列表。

 

        示例 1：

        输入：S = "ababcbacadefegdehijhklij"
        输出：[9,7,8]
        解释：
        划分结果为 "ababcbaca", "defegde", "hijhklij"。
        每个字母最多出现在一个片段中。
        像 "ababcbacadefegde", "hijhklij" 的划分是错误的，因为划分的片段数较少。
         
        
        提示：
        
        S的长度在[1, 500]之间。
        S只包含小写字母 'a' 到 'z' 。
        
        来源：力扣（LeetCode）
        链接：https://leetcode-cn.com/problems/partition-labels
        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public IList<int> PartitionLabels(string S)
            {
                IList<int> result = new List<int>();
                List<char> backup = new List<char>();
                List<char> chars = S.ToCharArray().ToList();
                for (int i = 0; i < S.Length; i++)
                {
                    if (backup.Count==0)
                    {
                        backup.Add(S[i]);
                        chars.RemoveAt(0);
                        continue;
                    }
                    if (backup.Any(x => chars.Contains(x)))
                    {
                        backup.Add(S[i]);
                        chars.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(backup.Count());
                        backup = new List<char>();
                        backup.Add(S[i]);
                        chars.RemoveAt(0);
                    }
                }
                if (backup.Count != 0)
                {
                    result.Add(backup.Count());
                }
                return result;
            }
        }
    }
}
