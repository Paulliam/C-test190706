using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 9多态  9.4 例题-接口
 * 题目：创建一个接口IPortA
 *       1）派生一个子接口IPortB
 *       2）从子接口IPortB派生一个子类AA
 * 要点： 关键字operator
 * 时间：2019、06、21
 ***************************************************/
namespace EXAMPLE9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            AA a = new AA();
            a.DisplayA();
            a.DisplayB();
        }
    }
    public interface IPortA
    {
        void DisplayA();//接口类的任何方法，属性，事件索引器默认public型，且不可更改
    }
    public interface IPortB:IPortA
    {
        void DisplayB();//接口类的任何方法，属性，事件索引器默认public型，且不可更改
    }
    public class AA : IPortB, IPortA //多继承，有多个父类，或者写成这样也行：public class AA : IPortB
    { 
        //子类AA必须要实现父类接口中的所有方法】】】】
        public void DisplayA()
        {
            Console.WriteLine("IPortA");
        }
        public void DisplayB()
        {
            Console.WriteLine("IPortB");
        }
    }
}
//IPortA
//IPortB
//请按任意键继续. . .