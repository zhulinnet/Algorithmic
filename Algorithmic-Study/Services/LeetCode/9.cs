using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _9
    {
        /*
         * 给定一个仅包含数字 2-9 的字符串，返回所有它能表示的字母组合。

            给出数字到字母的映射如下（与电话按键相同）。注意 1 不对应任何字母。
            
            
            
            示例:
            
            输入："23"
            输出：["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
            说明:
            尽管上面的答案是按字典序排列的，但是你可以任意选择答案输出的顺序。
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/letter-combinations-of-a-phone-number
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            private readonly string[] dic = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            public IList<string> LetterCombinations(string digits)
            {
                List<string> combinations = new List<string>();
                foreach (var item in digits)
                {
                    backtrack(ref combinations, int.Parse(item.ToString()));
                }
                return combinations;
            }
            public void backtrack(ref List<string> combinations,int digit=0)
            {
                string letters = dic[digit];
                if (combinations.Count == 0)
                {
                    foreach (var item in letters)
                    {
                        combinations.Add(item.ToString());
                    }
                }
                else
                {
                    int count = combinations.Count;
                    for (int i = 0; i < count; i++)
                    {
                        string combination = combinations[0];
                        combinations.Remove(combination);
                        foreach (var item in letters)
                        {
                            combinations.Add(combination+item.ToString());
                        }
                    }
                }
            }
        }
    }
}
