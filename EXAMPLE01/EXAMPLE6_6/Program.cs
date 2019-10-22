using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 6方法  6.6 out参数
 * 要点： 1）
 *        2）
 * 题目： 返回两个数的和与差
 *        
 * 时间：2019、06、13
 ***************************************************/
namespace EXAMPLE6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int x2 = 5;
            int x3 = 0;
            int x4 = 0;
            Console.WriteLine("------通过引用ref返回结果--------");
            AddSub1(x1,x2,ref x3,ref x4);
            Console.WriteLine("和为{0}，差为{1}",x3,x4);
            Console.WriteLine("------通过引用out返回结果--------");
            AddSub2(x1, x2, out x3, out x4);
            Console.WriteLine("和为{0}，差为{1}", x3, x4);
        }
        static void AddSub1(int x1, int x2, ref int x3, ref int x4)
        {
            x3 = x1 + x2;
            x4 = x1 - x2;
        }
        static void AddSub2(int x1, int x2, out int x3, out int x4)
        {
            x3 = x1 + x2;
            x4 = x1 - x2;
        }
    }
}

//------通过引用ref返回结果--------
//和为8，差为-2
//------通过引用out返回结果--------
//和为8，差为-2
//请按任意键继续. . .