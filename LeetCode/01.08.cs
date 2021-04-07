using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class8
    {
        /// <summary>
        /// 构建新矩阵时
        /// /// <param p_new=p></param>
        /// p_new 与 p 指向同一个内存地址，p变化也会引起p_new的变化
        /// 此尝试失败
        /// 
        /// 但是使用clone方法；可以创建p的一个副本，操作实现
        /// </summary>
        /// <param name="args"></param>
        /// 

        public void TurnToZero(int[,] p)
        {
            int x = p.GetLength(0);//矩阵的列数
            int y = p.Length / x;  //矩阵的行数
            int[,] p_new = new int[y,x];
            p_new = (int[,])p.Clone();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    if (p[i, j] == 0)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            p_new[k, i] = 0;
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            p_new[j, k] = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(p_new[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //static void Main(string[] args)
        //{
        //    int[,] p = new int[3, 3]
        //    {
        //      { 0,2,3},
        //      { 4,5,6},
        //      { 7,8,0}
        //    };
        //    Class8 c = new Class8();
        //    c.TurnToZero(p);
        //    c.TurnToZero1(p);
        //}



        //推荐解法
        public void TurnToZero1(int[,] p)
        {
            List<int> x = new List<int>(p.Length);
            List<int> y = new List<int>(p.Length);

            for (int i = 0; i < (int)Math.Sqrt(p.Length); i++)
            {
                for(int j=0;j< (int)Math.Sqrt(p.Length); j++)
                {
                    if (p[i, j] == 0)
                    {
                        x.Add(i);
                        y.Add(j);
                    }
                }
            }

            for(int k = 0; k < x.Count; k++)
            {
                for(int h = 0;h< (int)Math.Sqrt(p.Length); h++)
                {
                    p[x[k], h] = 0;
                    p[h, y[k]] = 0;
                }
            }
        }
    }
}
