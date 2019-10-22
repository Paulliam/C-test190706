using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPLE02_cout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------EXAMPL02_演示输入输出:"); //C#语言里处理的数据输入，输出都是字符串
            Console.WriteLine("请输入一个整数:");
            string s = Console.ReadLine();
            int x = Convert.ToInt32(s);
            Console.WriteLine("请再输入一个整数:");
            s = Console.ReadLine();
            int y = Convert.ToInt32(s);
            int z = x + y;
            /* 下一行的整形数据z将自动以字符串的形式输出到控制台 */
            Console.WriteLine("求和结果:");
            Console.WriteLine(z);//Console.Write 不换行；Console.WriteLine()要换行


            /* 在一行里输入多个数据 */
            Console.Write("-------------EXAMPL02_在一行里输入多个数,");
            Console.WriteLine("每个数用空格隔开:");
            string s2 = Console.ReadLine();
            string[] ss2 = s2.Split(' '); //Split(' ') 用空格切分字符串s2，得到的多个字符串存储到字符串数组ss2
            double[] a = new double[ss2.Length]; //ss2.Length 获取ss2中字符串个数
            double sum=0;
            for (int i = 0; i < ss2.Length; i++)
            {
                a[i] = Convert.ToDouble(ss2[i]); //把每个数字形式表现的字符串转换为双精度浮点数，并保存到数组a
                sum += a[i];
            }
            Console.WriteLine("以上各个数求和，值为:");
            Console.WriteLine(sum); //打印求和sum值

            /* 带格式输出 */
            Console.WriteLine("-------------EXAMPL02_带格式输出");
            Console.WriteLine("和是{0}，平均数是{1}",sum,sum/ss2.Length);
        }
    }
}

//-------------EXAMPL02_演示输入输出:
//请输入一个整数:
//12
//请再输入一个整数:
//23
//求和结果:
//35
//-------------EXAMPL02_在一行里输入多个数,每个数用空格隔开:
//2 5 12.2
//以上各个数求和，值为:
//19.2
//-------------EXAMPL02_带格式输出
//和是19.2，平均数是6.4
//请按任意键继续. . .