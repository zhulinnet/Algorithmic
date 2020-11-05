using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _127
    {
        /*
         * 给定两个单词（beginWord 和 endWord）和一个字典，找到从 beginWord 到 endWord 的最短转换序列的长度。转换需遵循如下规则：

            每次转换只能改变一个字母。
            转换过程中的中间单词必须是字典中的单词。
            说明:
            
            如果不存在这样的转换序列，返回 0。
            所有单词具有相同的长度。
            所有单词只由小写字母组成。
            字典中不存在重复的单词。
            你可以假设 beginWord 和 endWord 是非空的，且二者不相同。
            示例 1:
            
            输入:
            beginWord = "hit",
            endWord = "cog",
            wordList = ["hot","dot","dog","lot","log","cog"]
            
            输出: 5
            
            解释: 一个最短转换序列是 "hit" -> "hot" -> "dot" -> "dog" -> "cog",
                 返回它的长度 5。
            示例 2:
            
            输入:
            beginWord = "hit"
            endWord = "cog"
            wordList = ["hot","dot","dog","lot","log"]
            
            输出: 0
            
            解释: endWord "cog" 不在字典中，所以无法进行转换。
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/word-ladder
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */

        /*参考答案
         * 作者：wangzhen-z
            链接：https://leetcode-cn.com/problems/word-ladder/solution/bfs-ti-jie-jia-you-hua-guo-cheng-by-wangzhen-z/
         */

        public class Solution
        {
            public int LadderLength(string beginWord, string endWord, IList<string> wordList)
            {
                if (!wordList.Contains(endWord)) return 0;

                int Len = beginWord.Length;

                var dic = new Dictionary<string, List<string>>(wordList.Count);

                foreach (var item in wordList)
                {
                    for (int i = 0; i < Len; ++i)
                    {

                        string ch = $"{item.Substring(0, i)}*{item.Substring(i + 1)}";

                        if (dic.ContainsKey(ch)) dic[ch].Add(item);
                        else dic.Add(ch, new List<string> { item });
                    }
                }

                Queue<KeyValuePair<string, int>> queue = new Queue<KeyValuePair<string, int>>(wordList.Count);
                queue.Enqueue(new KeyValuePair<string, int>(beginWord, 1));

                while (queue.Count != 0)
                {
                    var point = queue.Dequeue();
                    string word = point.Key;
                    int count = point.Value;

                    for (int i = 0; i < Len; ++i)
                    {

                        string ch = $"{word.Substring(0, i)}*{word.Substring(i + 1, Len - i - 1)}";

                        if (dic.ContainsKey(ch))
                        {
                            foreach (var item in dic[ch])
                            {
                                if (item == endWord) return ++count;
                                queue.Enqueue(new KeyValuePair<string, int>(item, count + 1));
                            }
                            dic.Remove(ch);
                        }
                    }
                }

                return 0;
            }
            public List<string> GetWords(string word, IList<string> wordList)
            {
                var ls = new List<string>(wordList.Count);
                foreach (var item in wordList)
                {
                    int match = 0;
                    // 添加一个不匹配度个数的对象
                    int notmatch = 0;
                    for (int i = 0; i < item.Length; ++i)
                    {
                        //一旦有两个不匹配 就直接终止
                        if (notmatch == 2) break;

                        if (word[i] == item[i]) ++match;
                        else ++notmatch;
                    }
                    if (match == word.Length - 1) ls.Add(item);
                }
                return ls;

            }

        }
    }
}