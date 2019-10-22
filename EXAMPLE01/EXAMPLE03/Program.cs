using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPLE03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 变量的申明 */
            Console.WriteLine("-------------EXAMPL03_变量的申明");
            int x;
            int y = 90;   //定义变量，且赋初值
            float a, b, c; //定义多个变量
            const double PI = 3.1415926; //定义一个符号常量
            a = 90.8F; //90.8默认为双精度浮点数，赋值给a时，需要转换,或者指明其数据类型，后缀'F'，表示浮点数float
            decimal employeeSalary = 0.0m; //精确十进制类型，有28个有效位 1.0 × 10−28 至 7.9 × 1028，28 位精度

            //赋值
            a = 89.0f;
            b = 45.7F;
            c = 8f;
            float d = a + b + c;
            c = y / 20; //求整 90/20结果为4
            Console.WriteLine("y/20 = {0}", c);
            bool k = a > b; //如果a大于b，k的值为true
            Console.WriteLine("k = {0}", k); //打印结果 k = True

            //以上申明的变量(值变量)都在栈空间，而下面的num也在栈空间，不过num是一个引用变量
            int[] num = new int[100];  //这里申请的100个数据元素所在的空间不是栈内存，而是托管内存
            int[] cc;         //先定义一个引用变量，但为分配空间
            cc = new int[40]; //然后分配空间


        }
    }
}

//-------------EXAMPL03_变量的申明
//y/20 = 4
//k = True
//请按任意键继续. . .