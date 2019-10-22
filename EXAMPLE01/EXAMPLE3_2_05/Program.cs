using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPLE3_2_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero heroone = new Hero();
            heroone.AddLife();
            heroone.Life = 90;    //属性调用set
            int k = heroone.Life; //属性调用get
        }
    }

    class Hero
    {
        private string name; //等效为string name; 修饰符缺省值为private
        private int life = 50;

        public int Life  //属性定义 get/set访问器
        {
            get //如果没有该过程，表示属性只可写
            {
                return life;  //读
            }
            set //如果没有该过程，表示属性只可读
            {
                //life = value; //写
                if (value < 0) //set过程也可加入数据合法判断代码
                    life = 0;
                else if (value > 100)
                    life = 100;
                else
                    life = value;
            }
        }

        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age { get;set;} //自生成，命名属性，自实现属性

        public void AddLife()
        {
            life++;
        }

        public Hero()  //构造函数
        {
            life = 0;
            name = "";
        }
        ~Hero()  //析构函数
        { 
        }
    }
}
