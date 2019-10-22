using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 7构造析构  7.3 例题
 * 要点：
 *       1）构造函数
 *       2）
 *       3) 
 * 题目： 编写一个点类，描述平面上的2个点（double）;
 *        编写一个直线类，含有2个点，计算2点之间的距离
 * 时间：2019、06、14
 ***************************************************/
namespace EXAMPLE7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line();
            Console.WriteLine("line1 distance is:{0}",line1.Distance());
            Line line2 = new Line(1,5,2.1,8.8); //4各值，2个点的坐标
            Console.WriteLine("line2 distance is:{0:0.000}", line2.Distance());//string.Format("{0:000.000}", 12.2) 输出012.200
            
            Point p1 = new Point(1,5);
            Point p2 = new Point(2.1,8.8);
            Line line3 = new Line(p1,p2);
            Console.WriteLine("line3 distance is:{0:0.000}", line3.Distance());
        }
    }

    class Point
    {
        //private double x;
        //private double y;
        //public double X
        //{
        //    set { x = value; }
        //    get { return x; }
        //}
        public double X { set; get; }  /*当然上面的写法可以简化为“命名属性”的写法，采用这种方法，相当于后台系统有一个隐藏的变量x*/
        public double Y { set; get; }
        public Point()
        {
            X = Y = 0;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    class Line
    {
        public Point p1;
        public Point p2;
        public Line()  //构造初始化时，不带参构造函数，默认指定两点位置
        {
            p1 = new Point();
            p2 = new Point();
        }
        public Line(double x1, double y1, double x2, double y2)  //构造初始化时，直接定义2个点的坐标
        {
            p1 = new Point(x1,y1);
            p2 = new Point(x2, y2);
        }
        public Line(Point p1, Point p2)   //构造初始化时，直接传递已经定义的2个点
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public double Distance() //求2点间的距离
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y)); //Math.Sqrt()求开方
        }
    }
}

//line1 distance is:0
//line2 distance is:3.956
//line3 distance is:3.956
//请按任意键继续. . .