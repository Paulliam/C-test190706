using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 8继承  8.2 例题-龟兔赛跑
 * 要点：
 *       1）
 * 题目： 龟兔赛跑
 *        用随机数产生器建立模拟龟兔赛跑的程序
 *        对手从70个方格的第一格开始赛跑，每格表示赛道上的一个可能的位置，终点线在
 *        第70格处。程序每隔一秒钟打印显示各自位置，若选手跌到第一格以外，则移回第
 *        一格，各个选手位置的随机性满足一下情况：
 *   -------------------------------------------------------------------------------
 *   选手            运动类型    随机概率    运动情况
 *   -------------------------------------------------------------------------------
 *   乌龟(Tortoise)   快走       50%         向右3格
 *                    跌倒       20%         向左6格
 *                    慢走       30%         向右1格
 *   兔子(Hare)       睡觉       20%         不动
 *                    大跳       20%         向右9格
 *                    大跌       10%         向左12格
 *                    小跳       30%         向右1格
 *                    小跌       20%         向左2格
 * 时间：2019、06、17
 ***************************************************/
namespace EXAMPLE8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Run result = new Run();
            result.Runing();
        }
    }
    public class Tortoise
    {
        private int t=1;
        private Random r = new Random();

        public int GetPosition()
        {
            switch(r.Next(10))
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    t += 3;
                    break;
                case 5:
                case 6:
                    t = t - 6 > 0 ? t - 6 : 1;
                    break;
                case 7:
                case 8:
                case 9:
                    t++;
                    break;
                default:
                    break;
            }
            return t;
        }
    }
    public class Hare
    {
        private int t = 1;//初始化可以在构造函数中完成
        private Random r; //申请内存，初始化可以在构造函数中完成
        public Hare()
        {
            r = new Random();
        }

        public int GetPosition()
        {
            switch (r.Next(10))
            {
                case 0:
                case 1:
                    break;
                case 2:
                case 3:
                    t += 9;
                    break;
                case 4:
                    t = t - 12 > 0 ? t - 12 : 1;
                    break;
                case 5:
                case 6:                    
                case 7:
                    t++;
                    break;
                case 8:
                case 9:
                    t = t - 2 > 0 ? t - 2 : 1;
                    break;
                default:
                    break;
            }
            return t;
        }
    }
    public class Run
    {
        private Tortoise T = new Tortoise();
        private Hare H = new Hare();
        //private int tPos;           //这三者基本上，只供方法Runing()使用，所以，可以直接定义在方法中
        //private int hPos;           //这三者基本上，只供方法Runing()使用，所以，可以直接定义在方法中
        //char[] str = new char[70];  //这三者基本上，只供方法Runing()使用，所以，可以直接定义在方法中

        private void Dispaly(int tPos, int hPos) //只需要在Runing()方法内调用，故可将访问权设置为private
        {
            char[] str = new char[72];  //这三者基本上，只供方法runing()使用，所以，可以直接定义在方法中

            for (int i = 0; i < 70; i++)
                str[i] = ' ';
            if (tPos == hPos && tPos<70)
            {
                str[tPos - 1] = 'S'; //当前位置相同
                str[tPos - 0] = 'A'; //当前位置相同
                str[tPos + 1] = 'M'; //当前位置相同
                str[tPos + 2] = 'E'; //当前位置相同
            }
            else
            {
                if(tPos<=70)                    
                    str[tPos - 1] = 'T';
                if(hPos<=70)
                    str[hPos - 1] = 'H';
            }

            if (tPos >= 70 && hPos >= 70)
                str[69] = 'O';//同时越过终点
            else if (tPos >= 70)
                str[69] = 'T';//乌龟越过终点
            else if (hPos >= 70)
                str[69] = 'H';//兔子越过终点
            else
                str[69] = '|';//显示终点位置

            Console.WriteLine(new string(str));//字符数组转字符串
        }
        public void Runing()
        {
            //int tpos;           //这三者基本上，只供方法runing()使用，所以，可以直接定义在方法中
            //int hpos;           //这三者基本上，只供方法runing()使用，所以，可以直接定义在方法中            

            Console.WriteLine("龟兔赛跑开始：");
            int tPos = T.GetPosition(); //这三者基本上，只供方法runing()使用，所以，可以直接定义在方法中
            int hPos=H.GetPosition();
            Dispaly(tPos, hPos);
            while (tPos<70 && hPos<70)
            {   
                tPos = T.GetPosition();
                hPos = H.GetPosition();
                Dispaly(tPos, hPos);
                System.Threading.Thread.Sleep(1000); //休眠暂停1000ms
            }
            if (tPos >= 70 && hPos >= 70)
                Console.WriteLine("竞赛平局");//同时越过终点
            else if (tPos >= 70)
                Console.WriteLine("乌龟获胜");//乌龟越过终点
            else if (hPos >= 70)
                Console.WriteLine("兔子获胜");//兔子越过终点
        }
    }
}

//龟兔赛跑开始：
//H  T                                                                 |

//H     T                                                              |

//         SAME                                                        |

//H           T                                                        |

//         H     T                                                     |

//         TH                                                          |

//          H T                                                        |

//      T    H                                                         |

//         T H                                                         |

//            T       H                                                |

//             T    H                                                  |

//              T    H                                                 |

//        T           H                                                |

//         T        H                                                  |

//   T               H                                                 |

//    T            H                                                   |

//       T         H                                                   |

//          T      H                                                   |

//    T             H                                                  |

//      HT                                                             |

// T     H                                                             |

//T       H                                                            |

//   T             H                                                   |

//    T          H                                                     |

//T               H                                                    |

// T            H                                                      |

//  T         H                                                        |

//     T               H                                               |

//        T                     H                                      |

//           T                  H                                      |

//              T                        H                             |

//        T                               H                            |

//           T                                     H                   |

//            T                                  H                     |

//      T                                         H                    |

//T                                                H                   |

//   T                                                      H          |

//      T                                                            H |

//T                                                                   H|

//   T                                                                 H

//兔子获胜
//请按任意键继续. . .