using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 9多态  9.3 例题-多态--宠物
 * 题目：创建一个继承层次，体现出多态的使用意义。
 *       1）创建一个父类-宠物类Pet，包含字段Name,Age,
 *          包含方法Speak()，体现宠物的叫声模样
 *       2）创建一个子类-Cat,继承来自父类的虚方法virtual Speak，
 *          或者抽象方法abstract Speak
 * 要点： 关键字virtual override abstract
 * 时间：2019、06、20
 ***************************************************/
namespace EXAMPLE9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pet p = new Pet("pet:",12);
            //Speak(p);
            Cat c = new Cat("cat:",10);
            Speak(c);
            Console.WriteLine("----------");
            Dog d = new Dog("dog:",5);
            Speak(d);
        }
        static void Speak(Pet p)
        {
            Console.WriteLine(p);//Pet类型的p将被系统通过ToString()
            //自动转换为string类型数据，而ToString已经被我重写，
            //且返回Pet下的Name字段
            p.Speak(); //打印宠物叫声
            if (p is Pet)   //该语法可识别类的类别
            {
                Console.WriteLine("This is pet!");//Cat属于Pet，所以，该行将被打印
            }
            if (p is Cat) //该语法可识别类的类别
            {
                Console.WriteLine("This is cat!");
            }
            else if (p is Dog)
            {
                Console.WriteLine("This is dog!");
            }
        }
    }
    public abstract class Pet //abstract抽象类
    {
        public string Name { get; private set; }//set属性为私有访问
        public int Age { get; private set; }
        public Pet(string n, int a)
        {
            Name = n;
            Age = a;
        }

        //public virtual void Speak()
        //{
        //    Console.WriteLine("Speak:xxxxx"); ;
        //}
        public abstract void Speak(); //abstract抽象方法必须存在于抽象类，无需写方法体
                                      //【【【【【【【【【【【【【【
        public override string ToString() //重写ToString方法
        {            
            return Name;
        }
    }
    public sealed class Cat : Pet //密封修饰符sealed，指明Cat类不允许再向下派生
    {
        public Cat(string n,int a):base(n,a)
        { }
        public override void Speak()  //【【【【【【【【【【【【【【
        {
            Console.WriteLine("MIAO MIAO...");
        }
             
    }
    public class Dog : Pet
    {
        public Dog(string n, int a) : base(n, a)
        { }
        public override void Speak()  //【【【【【【【【【【【【【【
        {
            Console.WriteLine("WANG WANG...");
        }

    }
}
//cat:
//MIAO MIAO...
//This is pet!
//This is cat!
//----------
//dog:
//WANG WANG...
//This is pet!
//This is dog!
//请按任意键继续. . .

/******以下是用virtual范例**********
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///***
// * 章节： 9多态  9.3 例题-多态--宠物
// * 题目：创建一个继承层次，体现出多态的使用意义。
// *       1）创建一个父类-宠物类Pet，包含字段Name,Age,
// *          包含方法Speak()，体现宠物的叫声模样
// *       2）创建一个子类-
// *       3）创建一个子类-
// * 要点： 关键字virtual override
// * 时间：2019、06、20
// ***
namespace EXAMPLE9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet p = new Pet("pet:",12);
            Speak(p);
            Cat c = new Cat("cat:",10);
            Speak(c);
        }
        static void Speak(Pet p)
        {
            Console.WriteLine(p);//Pet类型的p将被系统通过ToString()
            //自动转换为string类型数据，而ToString已经被我重写，
            //且返回Pet下的Name字段
            p.Speak();
        }
    }
    public class Pet
    {
        public string Name { get; private set; }//set属性为私有访问
        public int Age { get; private set; }
        public Pet(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public virtual void Speak() //【【【【【【【【【【【【【【
        {
            Console.WriteLine("Speak:xxxxx"); ;
        }
        
        public override string ToString() //重写ToString方法
        {            
            return Name;
        }
    }
    public class Cat : Pet
    {
        public Cat(string n,int a):base(n,a)
        { }
        public override void Speak()  //【【【【【【【【【【【【【【
        {
            Console.WriteLine("MIAO MIAO...");
        }
             
    }
}

//pet:
//Speak:xxxxx
//cat:
//MIAO MIAO...
//请按任意键继续. . .
 *****************/