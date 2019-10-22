using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass hello = new Myclass();
            hello.SayHello();
            //hello.x = 90; //x 由于受private作用，访问受限
            while(true);
        }
    }

    class Myclass
    {
        private int x;
        public void SayHello()
        {
            Console.WriteLine("HelloWorld");
        }
    }
}
