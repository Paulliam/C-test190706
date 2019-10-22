using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 6方法  6.5例题-方法的参数传递
 * 要点： 1）
 *        2）
 * 题目： 参数是值类型的值传递和引用传递;
 *        参数是引用类型的值传递和引用传递
 * 时间：2019、06、13
 ***************************************************/
namespace EXAMPLE6_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 99;
            Console.WriteLine("------参数是值类型的值传递--------");
            Swap(a, b);
            Console.WriteLine("a={0},b={1}",a,b);
            Console.WriteLine("------参数是值类型的引用传递--------");
            Swap2(ref a, ref b); //注意引用传递的语法格式
            Console.WriteLine("a={0},b={1}", a, b);

            Console.WriteLine("------参数是引用类型的值传递--------");
            int[] arry = { 1, 2, 3 };
            Addone(arry); //值传递
            foreach (int i in arry)
                Console.WriteLine(i);
            Console.WriteLine("--------------");
            Addone1(arry); //值传递
            foreach (int i in arry)
                Console.WriteLine(i);
            Console.WriteLine("------参数是引用类型的引用传递--------");
            int[] arry2 = { 1, 2, 3 };
            Addone2(ref arry2); //引用传递
            foreach (int i in arry2)
                Console.WriteLine(i);
        }
        static void Swap(int a, int b) //值传递
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Swap2(ref int a,ref int b)//引用传递
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Addone(int[] a) //传递的时候，内存标记是一个拷贝到a的过程，形参是实参的一个拷贝副本，但都指向同一段内存空间
        {            
            for (int i = 0; i < a.Length; i++)  //改变形参指向内存空间的值，即是改变实参指向内存空间的值
            {
                a[i]++;
            }
            //foreach (int k in a)
            //    a[k]++; //用法错误
        }
        static void Addone1(int[] a) //传递的时候，内存标记是一个拷贝到a的过程，形参是实参的一个拷贝副本
        {
            a = new int[4] { 12, 13, 14, 15 }; //由于形参a重新指向另一段内存空间，那么后面的操作（改变形参指向空间的值），
            for (int i = 0; i < a.Length; i++)  //并不会影响实参指向空间的结果
            {
                a[i]++;
            }           
        }
        static void Addone2(ref int[] a) //传递的时候，内存标记是一个引用到a的过程
        {
            a = new int[4] { 12, 13, 14, 15 }; //由于参数是引用类型的引用传递，故这里的操作将该改变调用者实参数组名指向的内存位置
            for (int i = 0; i < a.Length; i++)
            {
                a[i]++;
            }
        }
    }
}

//------参数是值类型的值传递--------
//a=10,b=99
//------参数是值类型的引用传递--------
//a=99,b=10
//------参数是引用类型的值传递--------
//2
//3
//4
//--------------
//2
//3
//4
//------参数是引用类型的引用传递--------
//13
//14
//15
//16
//请按任意键继续. . .