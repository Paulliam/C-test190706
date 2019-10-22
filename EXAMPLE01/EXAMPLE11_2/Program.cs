using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 11泛型和委托  11.2 例题-泛型示例
 * 题目：
 *       1）创建3个不同类型的数组，并分别打印各个数组元素
 * 要点： 泛型T
 * 时间：2019、06、24
 ***************************************************/
namespace EXAMPLE11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            double[] b = { 1.1, 2.2, 3.3 };
            char[] c = { 'a', 'b', 'c' };
            Display(a);//效果类似于Display(int[] arr)
            Display(b);//效果类似于Display(double[] arr)
            Display(c);//效果类似于Display(char[] arr)

            Stack<int> s = new Stack<int>(10);//通过泛型创建一个int型数组
            System.Collections.Stack s1 = new System.Collections.Stack(12);//非泛型的Stack，元素类型object
        }
        static void Display<T>(T[] arr) //泛型函数,实际上，根据不同类型参数
        {                             //自动编译为不同的代码
            foreach (T k in arr)
            {               
                Console.Write(k);
                Console.Write('\t');
            }
            Console.WriteLine();
        }
    }
    class Stack<Ttype> //定义一个泛型的类
    {
        private int top;        //栈顶
        private int bottom;     //栈底
        private Ttype[] element; //栈空间索引，泛型数组
        public Stack(int size)
        {
            element = new Ttype[size];//开辟泛型数组空间
        }
    }
}
//1       2       3
//1.1     2.2     3.3
//a       b       c
//请按任意键继续. . .
