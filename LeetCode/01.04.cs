using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class4
    {
        public bool Reversable(string str)//时间复杂度O（n）
        {
            if (str == "")
            {
                return false;
            }
            int[] flag = new int[256];
            for(int i = 0; i < str.Length; i++)
            {
                flag[(int)str[i]]++;
            }
            int p = 0;
            for(int i = 0; i < flag.Length; i++)
            {
                if (flag[i] / 2 != 0)
                {
                    p++;
                }
            }
            if (p > 1)
            {
                return false;
            }
            return true;
        }
    }
}
