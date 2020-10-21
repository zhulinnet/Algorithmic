using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _844
    {
        /*
         * 给定 S 和 T 两个字符串，当它们分别被输入到空白的文本编辑器后，判断二者是否相等，并返回结果。 # 代表退格字符。

            注意：如果对空文本输入退格字符，文本继续为空。
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/backspace-string-compare
             著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        */
        public class Solution
        {
            public bool BackspaceCompare(string S, string T)
            {
                var backSpaceS = backSpace(S);
                var backSpaceT = backSpace(T);
                if (backSpaceS.Count != backSpaceT.Count)
                {
                    return false;
                }
                else 
                {
                    while (backSpaceS.Count > 0)
                    {
                        if (backSpaceS.Pop() != backSpaceT.Pop())
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return false;
            }
            private Stack<char> backSpace(string str)
            {
                Stack<char> backup = new Stack<char>();
                foreach (var item in str)
                {
                    if (item == '#')
                    {
                        char current = '#';
                        backup.TryPop(out current);
                    }
                    else 
                    {
                        backup.Push(item);
                    }
                }
                return backup;
            }
        }
    }
}
