using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _941
    {
        /*
         * 给定一个整数数组 A，如果它是有效的山脉数组就返回 true，否则返回 false。

            让我们回顾一下，如果 A 满足下述条件，那么它是一个山脉数组：
            
            A.length >= 3
            在 0 < i < A.length - 1 条件下，存在 i 使得：
            A[0] < A[1] < ... A[i-1] < A[i]
            A[i] > A[i+1] > ... > A[A.length - 1]
             
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/valid-mountain-array
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public bool ValidMountainArray(int[] A)
            {
                if (A.Length < 3)
                {
                    return false;
                }
                var Pre = Int32.MinValue;
                var Max = Int32.MinValue;
                bool IsMax = false;
                for (int i = 0; i < A.Length; i++)
                {
                    if (!IsMax||A[i] > Max)
                    {
                        //未达到峰值
                        if (Pre >= A[i])
                        {
                            return false;
                        }
                        Max = A[i];
                    }
                    else 
                    {
                        IsMax = true;
                        //已达到峰值
                        if (Pre <= A[i])
                        {
                            return false;
                        }
                    }
                    Pre = A[i];
                }
                if (Max == A[A.Length - 1]|| Max==A[0])
                {
                    return false;
                }
                return true;
            }
        }
    }
}
