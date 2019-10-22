using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 11泛型和委托  11.3 例题-委托的定义
 * 题目：
 *       1）通过一个方法自动识别调用哪个具体的方法
 * 要点： 1）委托：一个方法作为另一个方法的参数,类似于C++的函数指针
 *        定义：它定义了方法的类型，使得一个方法可以当做另一个方法的参数进行传递
 *        2）内置委托类型
 *        2.1）
 *          Action是无返回值的泛型委托
 *          Action<int,string>表示有传入参数int,string，但无返回值的委托
 *          Action最多允许16个参数，都没有返回值
 *        2.2）
 *          Func是有返回值的泛型委托
 *          Func<int>表示无参，返回值为int的委托
 *          Func<object,string,int>表示入参是object,string，返回值为int的委托
 *          Func<T1,T2,int>表示入参是T1,T2(泛型)，返回值为int的委托
 *          Func最多允许16个参数，且必须有返回值
 * 时间：2019、06、24
 ***************************************************/
namespace EXAMPLE11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("Mikiy", EnglishGreeting);//方法名EnglishGreeting作为函数参数
            SayHello("林依晨", ChineseGreeting);
            Console.WriteLine("---------------------");
            //Console.ReadKey();//等待获取任何一个按键按下

            Type t = typeof(GreetingDelegate);//t.IsClass可检查一个东东是不是类class
            Console.WriteLine(t.IsClass ? "GreetingDelegate是一个类" : "GreetingDelegate不是一个类");
            Console.WriteLine("---------------------");

            Console.WriteLine("--------实例化委托-------------");
            GreetingDelegate gd = new GreetingDelegate(ChineseGreeting);//实例化委托
            gd("王麻子");
        }
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("您好, " + name);
        }
        private static void SayHello(string name, GreetingDelegate GreetPeople)
        {//此方法接受一个GreetingDelegate类型的方法作为参数
            GreetPeople(name);
        }

        //定义委托，它定义了可以代表的方法的类型//该委托(GreetingDelegate)可以
        //被用于引用任何一个有单一string参数，并返回void的方法
        public delegate void GreetingDelegate(string name);
    }
}
//Hello, Mikiy
//您好, 林依晨
//---------------------
//GreetingDelegate是一个类
//---------------------
//--------实例化委托-------------
//您好, 王麻子
//请按任意键继续. . .