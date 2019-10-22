using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 6方法  6.8 方法的重载
 * 要点：重载要求：
 *       1）方法参数数目不同
 *       2）参数数目相同，但类型不同
 *       3) 参数数目类型都一样，当出现先后顺序不同
 * 题目： 求三角形的面积
 *        
 * 时间：2019、06、13
 ***************************************************/
namespace EXAMPLE6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Area1 is:{0}", TriangleArea(3d, 4d, 5d));  //数据后缀d，指明该数为double类型
            Console.WriteLine( "Area2 is:{0}", TriangleArea(3, 4, 1.2));
            Console.WriteLine( "Area3 is:{0}", TriangleArea(3, 4));
        }
        static double TriangleArea(double a, double b, double c) //输入三边长
        {
            Console.WriteLine(" ----------1------- ");
            double s = (a + b + c) / 2;
            return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }
        static double TriangleArea(double a, double h) //输入边长及其高
        {
            Console.WriteLine("------2-----------");
            return a * h / 2;
        }
        static double TriangleArea(int a,int b, double theta) //输入两边边长及其夹角的幅度
        {
            Console.WriteLine("--------3---------");
            return a * b * Math.Sin(theta) / 2;

        }
    }
}

// ----------1-------
//Area1 is:6
//--------3---------
//Area2 is:5.59223451580336
//------2-----------
//Area3 is:6
//请按任意键继续. . .