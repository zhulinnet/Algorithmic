using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Other
{
    /// <summary>
    /// 素性测试是判断一个自然数是否为素数的测试。
    /// 素数（prime number）就是只能被1和其自身整除，且大于1的自然数
    /// </summary>
    public class Primality
    {
        /// <summary>
        /// 判断一个数字是否为素数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool GeneralTest(int number)
        {
            bool IsPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            return IsPrime;
        }
        /// <summary>
        /// 判断一个数字是否为素数(费马测试)
        /// </summary>
        /// <param name="number"></param>
        /// <param name="testNum">测试次数</param>
        /// <returns></returns>
        public bool FermatTest(int number,int testNum=10)
        {
            if (testNum <= 0)
            {
                return true;
            }
            Random ran = new Random();
            int ranNumber = ran.Next(1, number - 1);
            if (!(Math.Pow(ranNumber, number) % number).Equals(ranNumber))
            {
                return false;
            }
            return FermatTest(number, testNum - 1);
        }
    }
}
