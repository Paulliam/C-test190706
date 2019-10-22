using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPLE01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass hello = new MyClass();
            hello.SayHello();
            //while(true);
        }
    }

    class MyClass
    {
        private int x;      //字段
        public void SayHello()  //方法
        {
            Console.WriteLine("HelloWorld");
        }
    }
}

//HelloWorld
//请按任意键继续. . .