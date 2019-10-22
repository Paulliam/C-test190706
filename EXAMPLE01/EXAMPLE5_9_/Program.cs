using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 5数组  5.9例题-利用交错数组打印杨辉三角
 * 要点： 1）交错数组声明、定义
 *        2）
 * 题目： 
 * 时间：2019、06、12
 ***************************************************/
namespace EXAMPLE5_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            int[][] pascal = new int[N][]; //声明有N个元素的交错数组
            for(int i=0;i<N;i++)
            {
                pascal[i] = new int[i+1]; //设置各个元素的长度为
            }
            pascal[0][0] = 1;
            for (int i = 1; i < N; i++) //计算出杨辉三角各个值
            {
                pascal[i][0] = 1;
                pascal[i][i] = 1;
                for (int j = 1; j < i; j++)
                {
                    pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                }
            }
            for (int i = 0; i < N; i++) //打印杨辉三角
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("{0,5}",pascal[i][j]);
                Console.WriteLine();
            }
        }
    }
}

//    1
//    1    1
//    1    2    1
//    1    3    3    1
//    1    4    6    4    1
//    1    5   10   10    5    1
//    1    6   15   20   15    6    1
//    1    7   21   35   35   21    7    1
//    1    8   28   56   70   56   28    8    1
//    1    9   36   84  126  126   84   36    9    1
//请按任意键继续. . .
