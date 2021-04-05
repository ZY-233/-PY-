using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode
{
    class Class5
    {
        public bool One_Edition(string str1,string str2)//时间复杂度O（str.Length+256）(没有考虑到字符串替换)
        {
            if (Math.Abs(str1.Length - str2.Length) > 1)
            {
                return false;
            }
            int length = (str1.Length < str2.Length ? str1.Length : str2.Length);
            int[] flag = new int[256];
            for (int i = 0; i < length; i++)
            {
                flag[(int)str1[i]]++; 
                flag[(int)str2[i]]--;
            }
            if (str1.Length > str2.Length)
            {
                flag[(int)str1[str1.Length - 1]]++;
            }
            else { flag[(int)str2[str2.Length - 1]]--; }

            length = 0;
            for(int i = 0; i < flag.Length; i++)
            {
                if (flag[i] != 0)
                {
                    length++;
                }
            }

            if (length > 1)
            {
                return false;
            }
            return true;    
        }
        

        //推荐解法
        public bool oneEditAway(string str1,string str2)//时间复杂度更小，最差O（str.Length）最好O（1）
        {
            int n1 = str1.Length;
            int n2 = str2.Length;
            if (Math.Abs(n1 - n2) > 1)
            {
                return false;
            }
            if (n1 + n2 <= 2)
            {
                return true;
            }

            if (str1[0] != str2[0])
            {
                if (n1==n2)
                {
                    return str1[1..] == str2[1..];
                }
                else
                {
                    return str1 == str2[1..] || str1[1..] == str2;
                }
            }
            else
            {
                return oneEditAway(str1[1..], str2[1..]);
            }
        }

        static void Main(string[] args)
        {
            string str1 = "pale";
            string str2 = "pele";
            Class5 c = new Class5();


            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("{0}", c.One_Edition(str1, str2));
            watch.Stop();
            Console.WriteLine("{0}",watch.ElapsedMilliseconds.ToString());
            watch.Reset();


            watch.Start();
            Console.WriteLine("{0}", c.oneEditAway(str1, str2));
            watch.Stop();
            Console.WriteLine("{0}",watch.ElapsedMilliseconds.ToString());
        }
    }
}
