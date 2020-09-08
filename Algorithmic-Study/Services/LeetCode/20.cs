using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _20
    {
        /*
         * 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。

            有效字符串需满足：
            
            左括号必须用相同类型的右括号闭合。
            左括号必须以正确的顺序闭合。
            注意空字符串可被认为是有效字符串。
            
            示例 1:
            
            输入: "()"
            输出: true
            示例 2:
            
            输入: "()[]{}"
            输出: true
            示例 3:
            
            输入: "(]"
            输出: false
            示例 4:
            
            输入: "([)]"
            输出: false
            示例 5:
            
            输入: "{[]}"
            输出: true
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/valid-parentheses
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public bool IsValid(string s)
            {
                Hashtable pairs = new Hashtable();
                pairs.Add('}', '{');
                pairs.Add(']', '[');
                pairs.Add(')', '(');
                Stack<char> backup = new Stack<char>();
                foreach (var item in s)
                {
                    if (pairs.ContainsKey(item))
                    {
                        if (backup.Count==0 || (char)pairs[item] != backup.Peek())
                        {
                            return false;
                        }
                        //若匹配成功则出栈
                        backup.Pop();
                    }
                    else 
                    {
                        //栈中只存前半个括号
                        backup.Push(item);
                    }
                  
                }
                if (backup.Count > 0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
