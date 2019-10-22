using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 8继承  8.2 例题-复数类
 * 要点：
 *       1）重载
 *       2）
 *       3) 
 * 题目： 编写复数类，可以实现两个复数的加法
 *        
 * 时间：2019、06、17
 ***************************************************/
namespace EXAMPLE8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex x1 = new Complex(1.2, 5.36);
            Complex x2 = new Complex(4.1, 8);
            x1.show();
            x2.show();
            Console.WriteLine("通过对象调用方法：");
            Complex x3 = x1.Add(x2);
            x3.show();
            Console.WriteLine("通过类调用方法：");
            Complex x4 = Complex.Add(x1, x2);
            x4.show();
        }
    }
    public class Complex
    {
        private double real;
        private double image;

        public Complex()
        {
            real = image = 0;
        }
        public Complex(double real, double image)
        {
            this.real = real;
            this.image = image;
        }

        public Complex Add(Complex x)                 //对象的方法
        { 
            Complex temp=new Complex();
            temp.real = this.real + x.real;
            temp.image = this.image + x.image;
            return temp;//返回时，栈中的临时索引temp被销毁，但其申请的堆空间还不一定被销毁
        }

        public static Complex Add(Complex x, Complex y) //静态类的方法
        {
            Complex temp = new Complex();
            temp.real = x.real + y.real;
            temp.image = x.image + y.image;
            return temp;
        }
        public void show()
        {
            Console.WriteLine("复数值为：{0}+{1}i",real,image);
        }
    }
}

//复数值为：1.2+5.36i
//复数值为：4.1+8i
//通过对象调用方法：
//复数值为：5.3+13.36i
//通过类调用方法：
//复数值为：5.3+13.36i
//请按任意键继续. . .