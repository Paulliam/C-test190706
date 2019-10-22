using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 9多态  9.4 例题-运算符重载
 * 题目：创建一个复数类，可以实现两个复数的加法
 *       1）
 *       2）
 * 要点： 关键字operator
 * 时间：2019、06、21
 ***************************************************/
namespace EXAMPLE9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex x1 = new Complex(1,2);
            Complex x2 = new Complex(2, 3);
            Console.WriteLine("复数x1：");
            Console.WriteLine(x1);
            Console.WriteLine("复数x2：");
            Console.WriteLine(x2);
            Console.WriteLine("方法1，复数x3=x1+x2：");
            Complex x3 = x1.Add(x2);
            Console.WriteLine(x3);
            Console.WriteLine("方法2，复数x4=x1+x2：");
            Complex x4 = Complex.Add(x1,x2);
            Console.WriteLine(x4);
            Console.WriteLine("方法3，复数x5=x1+x2：");
            Complex x5 = x1+x2;
            Console.WriteLine(x5);
        }
    }
    public class Complex
    {
        private double real;
        private double image;
        public Complex(double r, double i)
        {
            real = r;
            image = i;
        }
        public void Set(double r, double i)
        {
            real = r;
            image = i;
        }
        public override string ToString()
        {
            return string.Format("{0}+{1}i", real, image); //返回一个带格式的合成字符串
        }
        public Complex Add(Complex x)
        {
            Complex t = new Complex(0,0);
            t.real = x.real + real;
            t.image = x.image + image;
            return t;
        }
        public static Complex Add(Complex x1, Complex x2) //静态公有访问的Add方法，可与上一个方法重名】】】】
        {
            Complex t = new Complex(0, 0);
            t.real = x1.real + x2.real;
            t.image = x1.image + x2.image;
            return t;
        }
        public static Complex operator +(Complex x1, Complex x2) //C#运算符重载只能在静态方法中，而C++不限制】】】】
        {
            Complex t = new Complex(0, 0);
            t.real = x1.real + x2.real;
            t.image = x1.image + x2.image;
            return t;
        }
    }
}
//复数x1：
//1+2i
//复数x2：
//2+3i
//方法1，复数x3=x1+x2：
//3+5i
//方法2，复数x4=x1+x2：
//3+5i
//方法3，复数x5=x1+x2：
//3+5i
//请按任意键继续. . .