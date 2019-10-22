using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 11泛型和委托  11.4 例题-内置委托类型
 * 题目：
 *       1）通过一个方法自动识别调用哪个具体的方法
 * 要点： 
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
namespace EXAMPLE11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting g = new Greeting();
            g.SayHello();
            g.SayHelloToSomeone("Lily");

            Console.WriteLine("-------内置委托类型Action-------------");
            Action a1 = new Action(g.SayHello);//无返回值，无参类型的委托
            a1();
            Action<string> a2 = new Action<string>(g.SayHelloToSomeone);//无返回值，有参类型的委托
            a2("Cheng");

            Console.WriteLine("-------内置委托类型Func-------------");
            Caculate c = new Caculate();
            Func<int, int, int> func1 = new Func<int, int, int>(c.Add);
            Console.WriteLine("内置委托Func--Add:{0}",func1(10, 5));            
            Func<int, int, int> func2 = new Func<int, int, int>(c.Sub);
            Console.WriteLine("内置委托Func--Sub:{0}", func2(10, 5)); 
        }
    }
    class Greeting
    {
        public void SayHello()
        {
            Console.WriteLine("hello everyone!");
        }
        public void SayHelloToSomeone(string name)
        {
            Console.WriteLine("hello, "+name);
        }
    }
    class Caculate
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
//hello everyone!
//hello, Lily
//-------内置委托类型Action-------------
//hello everyone!
//hello, Cheng
//-------内置委托类型Func-------------
//内置委托Func--Add:15
//内置委托Func--Sub:5
//请按任意键继续. . .