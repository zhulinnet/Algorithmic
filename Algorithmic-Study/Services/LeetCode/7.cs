using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _7
    {
        /*
         * 给定一个非空的字符串，判断它是否可以由它的一个子串重复多次构成。给定的字符串只含有小写英文字母，并且长度不超过10000。

            示例 1:
            
            输入: "abab"
            
            输出: True

            解释: 可由子字符串 "ab" 重复两次构成。
            示例 2:
            
            输入: "aba"
            
            输出: False
            示例 3:
            
            输入: "abcabcabcabc"
            
            输出: True
            
            解释: 可由子字符串 "abc" 重复四次构成。 (或者子字符串 "abcabc" 重复两次构成。)
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/repeated-substring-pattern
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public bool RepeatedSubstringPattern(string s)
            {
                //return (s + s).IndexOf(s, 1) != s.Length;
                Queue<string> queueStr = new Queue<string>();
                int count_repeat = 0, index = 0;
                bool IsStartRepeat = false;
                foreach (var item in s)
                {
                    index++;
                    var str = item.ToString();
                    if (!queueStr.Contains(str))
                    {
                        if (!IsStartRepeat)
                        {
                            count_repeat++;
                        }
                        queueStr.Enqueue(str);
                    }
                    else
                    {
                       
                        IsStartRepeat = true;
                        var current = queueStr.Dequeue();
                        if (str != current)
                        {
                            return false;
                        }
                        if (queueStr.Count<0|| s.Length - (index ) >= count_repeat)
                        {
                            queueStr.Enqueue(str);
                        }
                       

                    }
                }
                if (queueStr.Count >0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
