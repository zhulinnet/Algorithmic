using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _387
    {
        /*
         * 给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1。

 

            示例：
            
            s = "leetcode"
            返回 0
            
            s = "loveleetcode"
            返回 2
             
            
            提示：你可以假定该字符串只包含小写字母。
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/first-unique-character-in-a-string
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public int FirstUniqChar(string s)
            {
                List<char> noRepeatChar = new List<char>();
                List<char> repeatChar = new List<char>();
                foreach (var item in s)
                {
                    if (noRepeatChar.Contains(item)|| repeatChar.Contains(item))
                    {
                        noRepeatChar.RemoveAll(x => x.Equals(item));
                        repeatChar.Add(item);
                    }
                    else 
                    {
                        noRepeatChar.Add(item);
                    }
                }
                if (noRepeatChar.Count == 0)
                {
                    return -1;
                }
                return s.IndexOf(noRepeatChar[0]);
            }
        }
    }
}
