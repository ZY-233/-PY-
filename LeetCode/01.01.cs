using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class1
    {
//        ## 题目描述

//<!-- 这里写题目描述 -->
//<p>实现一个算法，确定一个字符串<code> s</code> 的所有字符是否全都不同。</p>

//<p><strong>示例 1：</strong></p>

//<pre><strong>输入:</strong> <code>s</code> = &quot; leetcode&quot;
//<strong>输出:</strong> false 
//</pre>

//<p><strong>示例 2：</strong></p>

//<pre><strong>输入:</strong> <code>s</code> = &quot;abc&quot;
//<strong>输出:</strong> true
//</pre>

//<p><strong>限制：</strong></p>
//<ul>
//	<li><code>0 <= len(s) <= 100 </code></li>
//	<li>如果你不使用额外的数据结构，会很加分。</li>
//</ul>

//## 解法

//<!-- 这里可写通用的实现逻辑 -->

//根据示例，可以假定字符串中只包含小写字母（实际验证，也符合假设）。

//用 bitmap 标记小写字母是否出现过。

//<!-- tabs:start -->

        public bool IsDifferent(string str)  //双循环时间复杂度O(n*n)
        {
            if (str.Length > 52)
            {
                Console.WriteLine("String is Beyond Length Limite");
                return false;
            }
            int i = 0;
            int j = 0;
            //双循环：依次将每个字符与全部字符进行比较
            for( i = 0; i < str.Length-1; i++)
            {
                for (j = i+1; j < str.Length; j++)
                {
                   
                    if (str[i] == str[j])
                    {
                        return false;
                    }
                    
                }
                
            }
            
            //如果比较完成，ij应当满足如下关系
            if (i+1 == j)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string p = "lemtcode";
            string q = "codeqw";
            Class1 c = new Class1();
            Console.WriteLine("{0},{1}", c.IsDifferent(p),c.IsDifferent(q));
            Console.WriteLine("{0},{1}", c.IsUnique(p), c.IsUnique(q));
        }

        public bool IsUnique(string str)  //利用ASCII值对应的布尔数组的值来确定字符是否在字符串中出现过
        {
            if (str.Length > 256 || str.Length==0 )//时间复杂度O(n)
            {
                return false;
            }
            bool[] flag = new bool[256];//存放flag的布尔数组
            for(int i = 0; i < str.Length; i++)
            {
                if (flag[str[i]])//将字符的ASCII码值的位置 置为1 ，如果这个字符曾经出现过，则他的ASCII码值的位置为true
                {
                    return false;//直接返回false
                }
                flag[str[i]] = true;
            }
            return true;
        }

        public bool IsUnique2(string str)//利用位向量 
        {
            if (str.Length > 26)
            {
                return false;
            }
            int checker = 0;
            for(int i = 0; i < str.Length; i++)
            {
                int val = (int)str[i] - (int)'a';
                if((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }
            return false;
        }
    }
}
