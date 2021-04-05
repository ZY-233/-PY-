using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class basic3
    {
        public List<string> Replaceblank(string str)//时间复杂度O（n）
        {
            if (str == "")
            {
                return default(List<string>);
            }
            List<string> p = new List<string>();

            for(int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ')
                {
                    p.Add("%20");
                }
                else
                {
                    p.Add(str[i].ToString());
                }
            }
         
            return p;
        }

        //static void Main(string[] args)
        //{
        //    string str = new string("Mr John Smith     ");
        //    basic3 b = new basic3();
        //    List<string> str_new = b.Replaceblank(str);
        //    for (int i = 0; i < str_new.Count; i++)
        //        Console.Write(str_new[i]);
        //}
    }
}
