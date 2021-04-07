using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class9
    {
        public bool StringRotation(string str1,string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            if ((str2 + str2).IndexOf(str1) != 0)
            {
                return true;
            }
            return false;
        }
    }
}
