using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 6方法  6.3例题-静态变量、静态方法
 * 要点： 1）
 *        2）
 * 题目： 
 * 时间：2019、06、13
 ***************************************************/
namespace EXAMPLE6_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            Sample s1 = new Sample();
            Console.WriteLine(Sample.count);
            //s.SampleMethod();//语法错误-调用不允许
            Sample.SampleMethod();//静态方法由类调用
            Sample.count++; //静态变量由类访问
            s.a++; //实例访问非静态成员
            //s.count++;//语法错误-静态变量，不能实例访问
        }
    }
    class Sample
    {
        public static int count = 0; //指定为静态的公有成员
        public int a = 0;  //默认非静态
        public static void SampleMethod()
        {
            Console.WriteLine("the static SampleMethod!");
        }

        public Sample()
        {
            count++;
        }
    }
}

//2
//the static SampleMethod!
//请按任意键继续. . .