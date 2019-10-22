using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 10异常  10.2 例题-异常
 * 题目：
 *       1）除数为0时，捕获异常
 *       2）格式不正确时，捕获异常
 * 要点： 
 *       1）
 * 时间：2019、06、25
 ***************************************************/
namespace EXAMPLE10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入除法运算的两个整数：");
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = a / b;//异常会在这里产生
                    Console.WriteLine(c);
                    break;//代码运行到这里，说明无异常
                }
                catch (DivideByZeroException excep)//捕获DivideByZeroException异常(被零除异常)
                {
                    Console.WriteLine(excep.Message);//打印异常消息提示
                    Console.WriteLine("Try again!");
                }
                catch (FormatException excep)////捕获FormatException异常(格式异常)
                {
                    Console.WriteLine(excep.Message);
                    Console.WriteLine("Try again!");
                }
            }
        }
    }
}
//请输入除法运算的两个整数：
//10
//0
//尝试除以零。
//Try again!
//请输入除法运算的两个整数：
//12
//y
//输入字符串的格式不正确。
//Try again!
//请输入除法运算的两个整数：
//12
//2
//6
//请按任意键继续. . .