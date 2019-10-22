using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 9多态  9.2 例题-多态
 * 题目：创建一个继承层次，体现出多态的使用意义。
 *       1）创建一个父类-圆，Circle，可计算圆面积Area()
 *       2）创建一个子类-球Sphere，继承父类的Area,但要重写Area，
 *          求出求的面积
 *       3）创建一个子类-圆柱Cylinder,继承父类的Area,但要重写Area，
 *          求出圆柱的面积
 * 要点： 关键字virtual override
 * 时间：2019、06、20
 ***************************************************/
namespace EXAMPLE9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1);
            Console.WriteLine("圆的面积：{0:0.00}", Area(c));
            Sphere s = new Sphere(1);
            Console.WriteLine("球的面积：{0:0.00}", Area(s));
            Cylinder y = new Cylinder(1,2);
            Console.WriteLine("圆柱的面积：{0:0.00}", Area(y));
        }
        static double Area(Circle c) //【【【神奇的用法，共用静态函数Area可以和父类，子类的方法名一样】】
        {
            return c.Area();//----【【如果父类子类没有相关修饰符修饰，则此处，调用的方法都会默认调用父类的Area
        }
    }
    public class Circle
    {
        protected double radius;
        public Circle(double r)
        {
            radius = r >= 0 ? r : 0;
        }
        public virtual double Area() //虚基类
        {
            return Math.PI * radius * radius;
        }
    }
    public class Sphere:Circle
    {
        public Sphere(double r):base(r)
        { }
        public override double Area() //【【【【重写虚基类的方法】】】
        {
            return Math.PI * radius * radius*4;
        }
    }
    public class Cylinder : Circle
    {
        protected double height;
        public Cylinder(double r,double h):base(r)
        {
            height = h >= 0 ? h : 0;
        }
        public override double Area() //重写虚基类的方法
        {
            return Math.PI * radius * radius * 2+2*Math.PI*radius*height;
        }
    }
}
/* 如果父类的Area没有virtual修饰，且子类没有override，则，结果输出如下： */
//圆的面积：3.14
//球的面积：3.14     //----【【如果父类子类没有相关修饰符修饰，则此处，调用的方法都会默认调用父类的Area
//圆柱的面积：3.14
//请按任意键继续. . .
/* 反之，结果输出如下： */
//圆的面积：3.14
//球的面积：12.57
//圆柱的面积：18.85
//请按任意键继续. . .