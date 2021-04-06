using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class7
    {
        //比较容易理解的解法
        public int[,] Rotation1(int[,] p)
        {
            int n = (int)Math.Sqrt(p.Length);
            int[,] p_new = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    p_new[j, n - 1 - i] = p[i, j];
                   
                }
              
            }
           
            return p_new;
        }
        //推荐解法
        public int[,] Rotation(int[,] matrix)
        {
            int n = (int)Math.Sqrt(matrix.Length);

            for(int i = 0; i < n/2; i++)
            {
                for(int j = i; j < n-1-i; j++)
                {
                    int t = matrix[i,j];
                    matrix[i,j] = matrix[n - j - 1,i];
                    matrix[n - j - 1,i] = matrix[n - i - 1,n - j - 1];
                    matrix[n - i - 1,n - j - 1] = matrix[j,n - i - 1];
                    matrix[j,n - i - 1] = t;
                }
            }
            //a++;
            return matrix;
        }


        //static void Main(string[] args)
        //{
        //    int[,] p = new int[3, 3]
        //    {
        //      { 1,2,3},
        //      { 4,5,6},
        //      { 7,8,9}
        //    };
        //    Class7 c = new Class7();
        //    //int a = 0;
        //    //Console.WriteLine(a);

        //    p=c.Rotation1(p);
        // ;  for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write(p[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }

        //}
    }
}
