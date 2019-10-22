using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 5数组  5.8例题-发牌与洗牌
 * 要点： 1）随机数类Random的生成方法Next
 *        2）类：牌
 * 题目： 生成一副牌，并打乱后发牌        
 ***************************************************/
namespace EXAMPLE5_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cd1=new Card();
            Console.WriteLine("打乱牌序前：");
            cd1.deal(); //发牌
            cd1.Shuffle(); //洗牌
            Console.WriteLine("打乱牌序后：");
            cd1.deal();
        }
    }
    struct CNode  //单张牌的属性
    {
        public char suit;   //花色 //默认为private访问权限
        public string face; //大小
    }
    enum CardNum  //一副牌的属性  //类似于C的宏定义
    { 
        CARDNUMER=52, //一共52张
        SUITNUMBER=4, //共4种花色
        FACENUMBER=13 //每种花色13张牌
    }
    class Card
    {
        //定义扑克牌的数组
        private CNode[] deck;
        public Card() //构造一副牌
        {
            deck = new CNode[(int)CardNum.CARDNUMER]; //枚举类型在C#中使用比较特别
            //Heart,Diamod,Club,Spade
            char[] suit = { (char)3, (char)4, (char)5, (char)6 };//分别表示牌的四种花色-红桃、方块、梅花、黑桃
            string[] face = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", };
            for (int i = 0; i < (int)CardNum.CARDNUMER; i++)
            {
                deck[i].face = face[i % (int)CardNum.FACENUMBER];
                deck[i].suit = suit[i / (int)CardNum.FACENUMBER];
            }
        }
        public void deal() //发牌
        {
            Console.Write("================");
            Console.Write("52张牌的发牌次序");
            Console.WriteLine("================");
            Console.WriteLine("        甲\t        乙\t        丙\t        丁\t");
            for(int i=0;i<(int)CardNum.CARDNUMER;i++)  //枚举类型值需要强制类型转换，枚举类型使用类似于类对字段的调用
            {
                Console.Write("第{0,2}张：{1}{2}\t", i + 1, deck[i].suit, deck[i].face);
                //if (i % 4 == 0) //将在打印4个元素前换行
                if ((i+1) % 4 == 0) //将在打印4个元素后换行
                    Console.WriteLine();
            }
        }
        public void Shuffle() //洗牌：方法是将一副顺序牌通过52次随机抽取，
        {                     //然后，将某一次的按序牌与随机指定牌进行交换
            int j;
            CNode temp;
            Random r = new Random();
            for(int i=0;i<(int)CardNum.CARDNUMER;i++)
            {
                j = r.Next((int)CardNum.CARDNUMER);
                temp = deck[i];
                deck[i] =deck[j];
                deck[j] = temp;
            }
        }
    }
}

/* 下面的打印结果中，牌的花色在控制台界面可以正常显示 */
//打乱牌序前：
//================52张牌的发牌次序================
//        甲              乙              丙              丁
//第 1张：A      第 2张：2      第 3张：3      第 4张：4
//第 5张：5      第 6张：6      第 7张：7      第 8张：8
//第 9张：9      第10张：10     第11张：J      第12张：Q
//第13张：K      第14张：A      第15张：2      第16张：3
//第17张：4      第18张：5      第19张：6      第20张：7
//第21张：8      第22张：9      第23张：10     第24张：J
//第25张：Q      第26张：K      第27张：A      第28张：2
//第29张：3      第30张：4      第31张：5      第32张：6
//第33张：7      第34张：8      第35张：9      第36张：10
//第37张：J      第38张：Q      第39张：K      第40张：A
//第41张：2      第42张：3      第43张：4      第44张：5
//第45张：6      第46张：7      第47张：8      第48张：9
//第49张：10     第50张：J      第51张：Q      第52张：K
//打乱牌序后：
//================52张牌的发牌次序================
//        甲              乙              丙              丁
//第 1张：3      第 2张：2      第 3张：2      第 4张：A
//第 5张：7      第 6张：J      第 7张：6      第 8张：8
//第 9张：K      第10张：7      第11张：8      第12张：5
//第13张：K      第14张：10     第15张：9      第16张：A
//第17张：4      第18张：4      第19张：5      第20张：10
//第21张：Q      第22张：K      第23张：6      第24张：J
//第25张：5      第26张：3      第27张：4      第28张：8
//第29张：3      第30张：3      第31张：8      第32张：9
//第33张：A      第34张：J      第35张：6      第36张：7
//第37张：10     第38张：9      第39张：2      第40张：9
//第41张：7      第42张：6      第43张：10     第44张：Q
//第45张：4      第46张：2      第47张：K      第48张：Q
//第49张：5      第50张：J      第51张：A      第52张：Q
//请按任意键继续. . .