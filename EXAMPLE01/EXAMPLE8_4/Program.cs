using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 8继承  8.3 例题-点和圆
 * 要点：
 *       1）
 * 题目： 创建一个点类，并从点类继承，创建一个圆类，点是圆心；
 *        添加半径，计算面积
 * 时间：2019、06、17
 ***************************************************/
namespace EXAMPLE8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(2,3,4);
            Console.WriteLine("子类对象调用父类继承来的show:");
            c1.Show();
            Console.WriteLine();

            Console.WriteLine("子类对象调用自己的方法show2:");
            c1.Show2();
            Console.WriteLine();
            Console.WriteLine("c1的面积是：{0:0.00}",c1.Area());

            Circle c2 = new Circle();
            c2.Show2();
            Console.WriteLine();
        }
    }
    public class Point
    {
        protected double x; //可被继承
        protected double y; //可被继承
        public Point()
        {
            x = y = 0;
        }
        public Point(double x1, double y1)
        {
            x = x1;
            y = y1;
        }
        public void Show() //可被继承
        {
            Console.Write("x={0},y={1}",x,y);
        }
    }
    public class Circle : Point //Circle继承Point的语法格式
    {
        protected double r;
        public Circle()
        {
            r = 0;
        }
        public Circle(double x1,double y1,double r1):base(x1,y1) //派生类传递参数给基类
        //public Circle(double x1,double y1,double r1):base(x1,y1) //派生类传递参数给基类
        {
            r = r1;
        }
        public double Area()
        {
            return Math.PI * r * r; //Math.PI即可获得圆周率π
        }
        public void Show2()
        {
            Show();//子类可以直接调用从父类继承来的函数
            Console.Write(",r={0}",r);
        }
    }
}

//子类对象调用父类继承来的show:
//x=2,y=3
//子类对象调用自己的方法show2:
//x=2,y=3,r=4
//c1的面积是：50.27
//x=0,y=0,r=0
//请按任意键继续. . .