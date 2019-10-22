using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 6方法  6.7 可选参数\命名参数用法
 * 要点： 1）可选参数
 *        2）命名参数用法
 * 题目： 
 *        
 * 时间：2019、06、13
 ***************************************************/
namespace EXAMPLE6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            double b = 45;
            int c = 23;
            char d = 'Y';
            Console.WriteLine("--------1---------");
            Sam(a,b,c,d);
            Console.WriteLine("--------2---------");
            Sam(a, b, c); //省略d，调用时，形参d使用默认值R
            Console.WriteLine("--------3---------");
            Sam(a, b, 20,d);
            Console.WriteLine("--------4---------");
            Sam(a, b, d:d); //命名参数用法，前一个d标识形参，后一个d是实参(对应值为'Y')
        }
        static void Sam(int a, double b, int c = 1, char d = 'R') //这里的参数c和d是可选参数
        {
            Console.WriteLine("a={0},b={1},c={2},d={3}",a,b,c,d);
        }
    }
}

//--------1---------
//a=2,b=45,c=23,d=Y
//--------2---------
//a=2,b=45,c=23,d=R
//--------3---------
//a=2,b=45,c=20,d=Y
//--------4---------
//a=2,b=45,c=1,d=Y
//请按任意键继续. . .