using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode.CodingInterviews
{
    class _20
    {
        /*
         * 请实现一个函数用来判断字符串是否表示数值（包括整数和小数）。例如，字符串"+100"、"5e2"、"-123"、"3.1416"、"-1E-16"、"0123"都表示数值，但"12e"、"1a3.14"、"1.2.3"、"+-5"及"12e+5.4"都不是。

            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/biao-shi-shu-zhi-de-zi-fu-chuan-lcof
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public bool IsNumber(string s)
            {
                if(string.IsNullOrWhiteSpace(s))
                {
                    return false;
                }
                s = s.TrimStart().TrimEnd();
                bool numFlag = false;
                bool dotFlag = false;
                bool eFlag = false;

                char[] items = s.ToCharArray();
                int i = 0;
                foreach (var item in items)
                {
                  
                    if (item >= '0' && item <= '9')
                    {
                        numFlag = true;
                    }
                    else if (item == '.' && !dotFlag && !eFlag)
                    {
                        dotFlag = true;
                    }
                    else if ((item == 'e' || item == 'E') && !eFlag && numFlag)
                    {
                        eFlag = true;
                        numFlag = false;                 
                    }
                    else if ((item == '+' || item == '-') && (i == 0 || items[i - 1] == 'e' || items[i - 1] == 'E'))
                    {

                    }
                    else
                    {
                        return false;
                    }
                    i++;
                }
                return numFlag;
            }
        }

    }
}
