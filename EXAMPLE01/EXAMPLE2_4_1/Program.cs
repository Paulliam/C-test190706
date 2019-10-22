using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPLE2_4_1
{
    class Program
    {
        struct Student
        {
            public int age;
            public string name;
        }
        enum DayOfTime
        {
            Morning,
            Noon,
            Afternoon
        }
        static void Main(string[] args)
        {
            Student s1;
            s1.age = 18;
            Student[] ss = new Student[100];
            DayOfTime d1;
            d1 = DayOfTime.Morning;
        }

        /* 3.1 面向对象编程：get/set访问器 */
        /*--------------
         * 访问修饰符 数据类型 属性名
         * {
         *   get{
         *     get访问代码块
         *   }
         *   set{
         *     set访问代码块
         *   }
         * }
         --------------*/
        //private string id = "0000";
        //public string ID
        //{
        //    get {
        //        return id;
        //    }
        //    set {
        //        id = value; 
        //    }
        //}

    }
}
