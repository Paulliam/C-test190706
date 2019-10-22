using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 11泛型和委托  11.5 例题-多播委托
 * 题目：
 *       1）
 * 要点： 
 *       1）委托对象可以使用"+"运算符进行合并
 *       2）"-"运算符可用于从合并委托中移除组件委托
 *       3）只有相同类型的委托可被合并
 *       4）调用多播委托时，方法将按照添加顺序依次调用
 * 时间：2019、06、25
 ***************************************************/
namespace EXAMPLE11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw d1 = new Draw() { Stuid = 1, PenColor = ConsoleColor.Yellow };//【【【【对属性赋初值
            Draw d2 = new Draw() { Stuid = 2, PenColor = ConsoleColor.Red };
            Draw d3 = new Draw() { Stuid = 3, PenColor = ConsoleColor.Green };
            Console.WriteLine("对象调用方法形式---->");
            d1.DrawPicture();
            d2.DrawPicture();
            d3.DrawPicture();
            Console.WriteLine("单播委托形式---->");
            Action action1 = new Action(d1.DrawPicture);
            Action action2 = new Action(d2.DrawPicture);
            Action action3 = new Action(d3.DrawPicture);
            action1(); action2(); action3();//调用单播委托
            Console.WriteLine("多播委托形式---->");
            action1 += action2;//相同类型的委托合并到委托action1
            action1 += action3;
            action1();//调用多播委托
            Console.WriteLine("------");
            action1 -= action2;
            action1();//调用多播委托
        }
    }
    class Draw
    {
        public int Stuid { get; set; }
        public ConsoleColor PenColor { get; set; }
        public void DrawPicture()
        {
            Console.ForegroundColor = PenColor;
            Console.WriteLine("Stuid{0} draw a cat",Stuid);
        }
    }
}
//对象调用方法形式---->
//Stuid1 draw a cat
//Stuid2 draw a cat
//Stuid3 draw a cat
//单播委托形式---->
//Stuid1 draw a cat
//Stuid2 draw a cat
//Stuid3 draw a cat
//多播委托形式---->
//Stuid1 draw a cat
//Stuid2 draw a cat
//Stuid3 draw a cat
//------
//Stuid1 draw a cat
//Stuid3 draw a cat
//请按任意键继续. . .