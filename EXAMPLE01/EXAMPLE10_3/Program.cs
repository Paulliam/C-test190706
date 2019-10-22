using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 10异常  10.2 例题-抛出异常
 * 题目：
 *       1）
 * 要点： 
 *       1）自定义异常
 * 时间：2019、06、25
 ***************************************************/
namespace EXAMPLE10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FFF f = new FFF();
                //f.Age = -2; //将抛出异常
                f.Age = 2; //不会抛出异常
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally //这里面的语句无论异常是否发生，都将被执行
            {
                Console.WriteLine("Finally code segment");
            }
        }
    }
    public class FFF
    {
        private int age;
        public int Age {
            get { return age; }
            set {
                if (value >= 0)
                    age = value;
                else 
                {
                    age = 0;
                    throw (new MyException());//throw,抛出异常--人为触发异常
                    //throw (new MyException("构造函数赋初值出错！"));//调用不同的异常的构造函数
                }
            }
        }
    }
    public class MyException : Exception
    {
        //不带参自定义异常
        public MyException() : base("Age should be over zero!") { }
        //带一个字符串参数
        public MyException(string message) : base(message) { }
        //带一个字符串参数和一个exception参数，指明该异常是由另一个异常触发
        public MyException(string message, Exception excep) : base(message, excep) { }
    }
}
/* 执行代码为 f.Age = -2; //将抛出异常 */
//Age should be over zero!
//Finally code segment
//请按任意键继续. . .
/* 执行代码为 f.Age = 2; //不会抛出异常 */
//Finally code segment
//请按任意键继续. . .