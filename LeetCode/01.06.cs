using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class6
    {
        public String StringZip(String str) //时间复杂度O（n）
        {
            int flag = 1;
            string str_new = "";
            int i = 1;
            for( i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1])
                {
                    str_new += (str[i - 1] + flag.ToString());
                    flag = 1;
                }
                else
                {
                    flag += 1;
                }
            }

            str_new += (str[i - 1] + flag.ToString());

            if (str.Length <= str_new.Length)
            {
                return str;
            }
            else
            {
                return str_new;
            }
        } 

        //static void Main(string[] args)
        //{
        //    string str = "aabccccaaabcdefZZZZZZZZ";
        //    Class6 c = new Class6();
        //    Console.WriteLine(c.StringZip(str));
        //}
    }
}
