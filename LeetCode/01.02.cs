using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class 字符重排
    {
        /// <summary>
        /// 思路1：利用判断字符是否出现来确定能否实现重排 (有缺陷）
        /// 思路2：快速排序，每个元素依次比较
        /// 思路3：直接遍历，比较元素是否相同
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>

        public int[] QuickSort(int[] arr,int low,int high)
        {
            int i = low;
            int j = high;
            int tmp = arr[low];

            while (low < high)
            {
                while ((low < high) && (arr[high] >= tmp))
                {
                    high--;
                }
                if ((low < high) && (arr[high] < tmp))
                {
                    arr[low] = arr[high];
                    low++;
                }
                while ((low < high) && (arr[low] <= tmp))
                {
                    low++;
                }
                if ((low < high) && (arr[low] > tmp))
                {
                    arr[high] = arr[low];
                    high--;
                }
            }

            arr[low] = tmp;
            if (low - 1 > i)
            {
                QuickSort(arr, i, low - 1);
            }
            if (low + 1 < j)
            {
                QuickSort(arr, low + 1, j);
            }
            return arr;
        }
        public bool ReSort(string str1,string str2)//时间复杂度O(lg(n))
        {
            if (str1.Length!=str2.Length)
            {
                return false;
            }

            int[] s1 = new int[str1.Length];
            int[] s2 = new int[str1.Length];

            for(int i = 0; i < str1.Length; i++)
            {
                s1[i] = (int)str1[i] - (int)'a';
                s2[i] = (int)str2[i] - (int)'a';
            }

            s1 = QuickSort(s1, 0, s1.Length-1);
            s2 = QuickSort(s2, 0, s2.Length-1);

            for (int i=0; i < str1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }
            return true;
        }

        //static void Main(string[] args)
        //{
        //    string str1 = "LeetCode";
        //    string str2 = "edoCteeL";
        //    字符重排 z = new 字符重排();
        //    Console.WriteLine("{0}",z.ReSort(str1,str2));
        //    Console.WriteLine("{0}", z.Resort2(str1, str2));
        //}

        public  bool Resort2(string str1,string str2)//时间复杂度O(n)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            int[] flag1 = new int[256];
            int[] flag2 = new int[256];
            for (int i = 0; i < str1.Length; i++)
            {
                
                flag1[(int)str1[i]]+=1;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                
                flag2[(int)str2[i]]+=1;
            }
            for(int i = 0; i < str1.Length; i++)
            {
                if (flag1[i] != flag2[i])
                {
                    return false;
                }
            }
            return true;
        }

        //推荐解法：时间复杂度O(n)  空间复杂度比上面的小
        public bool Resort3(string str1,string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            int[] flag = new int[256];
            for(int i = 0; i < str1.Length; i++)
            {
                flag[(int)str1[i]] += 1;
                flag[(int)str2[i]] -= 1;
            }
            for(int i = 0; i < flag.Length; i++)
            {
                if(flag[i]!= 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
