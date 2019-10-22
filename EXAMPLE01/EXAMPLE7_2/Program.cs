using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 7构造析构  7.2 构造析构
 * 要点：
 *       1）构造函数
 *       2）构造函数的重载-(实现不同方式地对象初始化)
 *       3) 
 * 题目： 设计一个Time类，存储时分秒，并以字符串的形式输出
 * 时间：2019、06、14
 ***************************************************/
namespace EXAMPLE7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t3 = new Time();
            t3.show(1);
            Time t0 = new Time(12);
            t0.show(2);
            Time t1 = new Time(12,24,56);
            t1.show(3);
            Time t2 = new Time(12, s:24);
            t2.show(4);
            t2.Hour = 11;
            t2.show(5);
        }
        public class Time
        {
            private int hour;
            private int min;
            private int sec;

            ~Time()//析构函数，跟C++有所不同，C#中，析构函数不带修饰符
            {
                Console.WriteLine("执行析构函数destructor");
            }
            public Time()
            {
                Console.Write("default constructor--");
                hour = min = sec = 0;
            }
            public Time(int h,int m=33,int s=45 )
            {
                Console.Write("With parameters constructor--");
                this.hour = h >= 0 && h < 24 ? h : 0;
                this.min  = m >= 0 && m < 60 ? m : 0;
                this.sec  = s >= 0 && s < 60 ? s : 0;
            }
            public int Hour
            {
                get { return hour; }
                set { hour = value >= 0 && value < 24 ? value : 0; }                                    
            }
            public void show(int line)
            {
                Console.WriteLine("time{0} is {1:D2}:{2:D2}:{3:D2}", line,hour, min, sec); //{0:D2} D 十进制string.Format("{0:D3}", 2) 输出002
            }
        }
    }
}

//default constructor--time1 is 00:00:00
//With parameters constructor--time2 is 12:33:45
//With parameters constructor--time3 is 12:24:56
//With parameters constructor--time4 is 12:33:24
//time5 is 11:33:24
//执行析构函数destructor
//执行析构函数destructor
//执行析构函数destructor
//执行析构函数destructor
//请按任意键继续. . .