using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 6方法  6.7 可选参数\命名参数用法
 * 要点： 1）变长参数表
 *        2）获取数组第N维长度 GetLength(N)
 * 题目： 使用变长参数，求若干个整数的平均值
 *        
 * 时间：2019、06、13
 ***************************************************/
namespace EXAMPLE6_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("均值1：{0}", Average(1));
            Console.WriteLine("均值2：{0}", Average(1,2,3));
            Console.WriteLine("均值3：{0}", Average(4,5));

            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine("均值4：{0}", Average(array));//变长参数也可以这样传递参数
        }
        static double Average(params int[] a) //变长参数修饰符params
        {
            //int b = a.Length;    //获取参数个数的方法1 Lengths
            int b = a.GetLength(0);//获取参数个数的方法2 GetLength()
            double s = 0;            //GetLength(0)如果是二维数组，则获取第二维行的长度
            foreach (int i in a)     //GetLength(1)如果是二维数组，则获取第二维列的长度
                s += i;
            return s / b;
        }
    }
}

//均值1：1
//均值2：2
//均值3：4.5
//均值4：2.5
//请按任意键继续. . .