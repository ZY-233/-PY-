using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class8
    {
        public void TurnToZero(int[,] p)
        {
            int x = p.GetLength(0);//矩阵的列数
            int y = p.Length / x;  //矩阵的行数
            int[,] p_new = p;

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine(p[i, j]);
                    if (p[i, j] == 0)
                    {
                        for(int k = 0; k < 3; k++)
                        {
                            p_new[ k,i] = 0;
                        }
                        for(int k = 0; k < 3; k++)
                        {
                            p_new[j,k] = 0;
                        }
                    }
                }
            }

            for(int i = 0; i <y; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    Console.Write(p_new[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] p = new int[3, 3]
            {
              { 1,2,3},
              { 4,0,6},
              { 7,8,9}
            };
            Class8 c = new Class8();
            c.TurnToZero(p);
        }
    }
}
