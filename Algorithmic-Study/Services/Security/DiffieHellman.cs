using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Security
{
    public class DiffieHellman
    {
        /// <summary>
        /// 素数P
        /// 当前算法素数不能过大会造成精度丢失从而发生错误，目前测试最大23 o(╥﹏╥)o
        /// http://www.cnpaf.net/class/rfcen/200502/4588.html
        /// </summary>
        public int P { get; set; }
        /// <summary>
        /// G是素数P所对应的生成元（或者“原根”）中的一个
        /// http://www.cnpaf.net/class/rfcen/200502/4588.html
        /// </summary>
        public int G { get; set; }
        public DiffieHellman()
        {
            this.P = 7;
            this.G = 5;
        }
        public DiffieHellman(int p, int g)
        {
            this.P = p;
            this.G = g;
        }
        /// <summary>
        /// 判断是否为素数
        /// 质数是指在大于1的自然数中，除了1和它本身以外不再有其他因数的自然数
        /// </summary>
        /// <returns></returns>
        public bool IsPrime(int p)
        {
            if (p <= 1)
            {
                return false;
            }
            int divisorCount = 0;
            for (int i = 1; i <= p; i++)
            {
                if (p % i == 0)
                {
                    divisorCount += 1;
                }
            }
            if (divisorCount == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 获取素数的原根
        /// 假设一个数g是P的原根，那么g^i mod P的结果两两不同，且有 1<g<P，0<i<P，归根到底就是g^(P-1) = 1 (mod P)当且仅当指数为P-1的时候成立.(这里P是素数)。
        /// 简单来说，g^i mod p ≠ g^j mod p （p为素数），其中i≠j且i, j介于1至(p-1)之间，则g为p的原根。
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public List<int> GetPrimitiveRoot(int p)
        {
            List<int> rootList = new List<int>();
            for (int i = 1; i < p; i++)
            {
                int g = i;
                bool flag = false;
                for (int j = i ; j < p ; j++)
                {
                    if (i!=j&&Math.Pow(g, i) % p == Math.Pow(g, j) % p)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    rootList.Add(g);
                }
            }
            return rootList;
        }
        /// <summary>
        /// 获得A和B各自的私钥
        /// </summary>
        /// <returns></returns>
        public int GetS()
        {
            Random ran = new Random();
            return ran.Next(1, P-1);
        }
        /// <summary>
        /// 合成后的P-SA/P-SB
        /// </summary>
        /// <param name="S">A和B各自的私钥SA/SB 取值范围：[1, p-1]</param>
        /// <returns></returns>
        public double GetCalculation(int S)
        {
            return Math.Pow(G, S) % P;
        }
        /// <summary>
        /// 获得最终的Key P-SA-SB
        /// </summary>
        /// <param name="Calculation">合成后的P-SA/P-SB</param>
        /// <param name="S">A和B各自的私钥SA/SB  取值范围：[1, p-1]</param>
        /// <returns></returns>
        public double GetKey(double Calculation, int S)
        {
            return Math.Pow(Calculation, S) % P;
        }
    }
}
