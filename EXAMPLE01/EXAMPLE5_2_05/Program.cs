using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//例子：二维数组
//使用二维数组，完成一个3*4的矩阵加法，这两个矩阵分别是：
//1 2 3 4
//5 6 7 8
//9 10 11 12
//和
//1 4 7 11 
//2 5 8 12
//3 6 9 13
namespace EXAMPLE5_2_05
{
    class Program
    {
        static void Main(string[] args)
        {
            const int M = 3;
            const int N = 4;
            int[,] a = new int[M, N] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };//二维数组定义方法1
            int[,] b = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };//二维数组定义方法2
            int[,] c = new int[M, N];
            Console.WriteLine("矩阵a如下：");
            for (int i = 0; i < M; i++)
            {
                for(int j=0;j<N;j++)
                {
                    Console.Write("{0,4}", a[i, j]); //"{0,4}"表示第0个输出量显示位宽为4
                }
                Console.WriteLine();
            }
            Console.WriteLine("矩阵b如下：");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,4}", b[i, j]); //"{0,4}"表示第0个输出量显示位宽为4
                }
                Console.WriteLine();   //换行操作
            }
            Console.WriteLine("矩阵求和,结果如下：");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write("{0,4}", c[i, j]);
                }
                Console.WriteLine();   //换行操作
            }
        }
    }
}

//矩阵a如下：
//   1   2   3   4
//   5   6   7   8
//   9  10  11  12
//矩阵b如下：
//   1   2   3   4
//   5   6   7   8
//   9  10  11  12
//矩阵求和,结果如下：
//   2   4   6   8
//  10  12  14  16
//  18  20  22  24
//请按任意键继续. . .