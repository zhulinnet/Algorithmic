﻿using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _389
    {
        /*
         * 给定两个字符串 s 和 t，它们只包含小写字母。

            字符串 t 由字符串 s 随机重排，然后在随机位置添加一个字母。
            
            请找出在 t 中被添加的字母。
            
             
            
            示例 1：
            
            输入：s = "abcd", t = "abcde"
            输出："e"
            解释：'e' 是那个被添加的字母。
            示例 2：
            
            输入：s = "", t = "y"
            输出："y"
            示例 3：
            
            输入：s = "a", t = "aa"
            输出："a"
            示例 4：
            
            输入：s = "ae", t = "aea"
            输出："a"
             
            
            提示：
            
            0 <= s.length <= 1000
            t.length == s.length + 1
            s 和 t 只包含小写字母
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/find-the-difference
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public char FindTheDifference(string s, string t)
            {
                int _as = 0, _at = 0;
                foreach (var item in s)
                {
                    _as += item;
                }
                foreach (var item in t)
                {
                    _at += item;
                }
                return (char)(_at - _as);
            }
        }
    }
}
