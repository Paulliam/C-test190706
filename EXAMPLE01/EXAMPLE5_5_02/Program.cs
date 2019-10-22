﻿using System;

//随机填充一维数组：
//产生100个1-99之间的随机整数，填充数组；
//数组类型是整数，大小为100
//最后输入一个整数，如果该数字在此数组中，则输出该元素位置

namespace EXAMPLE5_5_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i]=r.Next(1,100); //可返回1到100的之间的随机数(next方法返回整数)，包括1，但不包括100
                //Console.Write("{0}\t",a[i]);
            }
            int j = 0;
            foreach (int i in a)  //foreach，它可以说是一种增强型的for循环
            {

                Console.Write("{0,2}:{1,2}\t", j++,i);  //【这里，比较特别，i表示数组元素a[i]】
            }
            Console.WriteLine("请输入一个整数:");
            int m = Convert.ToInt32(Console.ReadLine());            
            for ( j = 0; j < a.Length; j++)
            {
                if (m == a[j])
                {
                    Console.WriteLine("该整数在随机数中的位置是:{0}",j);
                    break;
                }
            }                
            if(j==a.Length)
                Console.WriteLine("该整数在随机数中未找到！");
        }
    }
}


// 0:52    1: 6    2:23    3:95    4:92    5:40    6:41    7:94    8:34    9:76
//10:43   11:16   12:70   13:47   14:54   15:81   16: 5   17:70   18:79   19:33
//20:66   21:56   22:39   23: 9   24:85   25:50   26:73   27: 9   28:61   29:24
//30:82   31:39   32:47   33:27   34:41   35:38   36:19   37:27   38:84   39:41
//40:27   41:82   42:99   43:60   44:30   45:25   46: 2   47:99   48:40   49:16
//50:26   51:14   52:39   53:92   54: 5   55:96   56:66   57:14   58:11   59:43
//60:67   61:33   62:33   63:10   64:94   65: 4   66:69   67:44   68: 7   69:17
//70:62   71:77   72:85   73:39   74: 6   75:84   76:56   77:78   78:79   79:61
//80:49   81:73   82:68   83:45   84:98   85:68   86: 1   87:54   88:23   89:45
//90:71   91: 6   92:17   93:42   94:74   95:94   96:49   97:89   98:66   99:26
//请输入一个整数:
//27
//该整数在随机数中的位置是:33
//请按任意键继续. . .