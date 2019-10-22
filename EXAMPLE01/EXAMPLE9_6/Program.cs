using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 9多态  9.6 例题-多继承-员工工资
 * 题目：
 *      1）固定工：每周工资一样，与工作事件长短无关，由SalariedEmployee类
 *      2）计时工：按时计酬，超过40小时，算加班工资，由HourlyEmployee类实现
 *      3）销售工：在底薪之上增加销售百分比。在本期内，公司准备对底薪
 *         雇佣工加薪10%，由CommissionEmployee类实现
 *      4）底薪+销售员工：BasePlusCommissionEmployee
 * 要点： 关键字 abstract override
 * 时间：2019、06、22
 ***************************************************/
namespace EXAMPLE9_6
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee se = new SalariedEmployee("Jack","1111",100);
            display(se);
            HourlyEmployee he = new HourlyEmployee("Rose", "2222", 5.3m, 50m);
            display(he);
            CommissionEmployee ce = new CommissionEmployee("Linda", "3333", 12035m, 0.1m);
            display(ce);
            BasePlusCommissionEmployee be = new BasePlusCommissionEmployee("Miki", "4444", 10243m, 0.1m,100);
            display(be);

            Console.WriteLine("----------------");
            Employee[] employ =new Employee[4];
            employ[0]=se; employ[1]=he; employ[2]=ce; employ[3]=be;
            foreach (var current in employ)//等效为foreach (Employee current in employ)
            {                
                if (current is BasePlusCommissionEmployee) //【【【【is语法(相等判断)可判断某个子类到底属于哪一种子类
                    Console.WriteLine("This is BasePlusCommissionEmployee--->");
                display(current);
            }
        }
        static public void display(Employee e)
        {
            Console.WriteLine(e);
        }
    }
    public abstract class Employee
    {
        public string Name { get; private set; }
        public string SSD { get; private set; }
        public Employee(string name, string ssd)
        {
            Name = name;
            SSD = ssd;
        }
        public override string ToString()
        {
            return string.Format("{0}'s ssd is:{1}", Name, SSD);
        }
        public abstract decimal Earning();//【【【【抽象方法，计算器员工工资-无须实现方法体
    }
    public class SalariedEmployee:Employee
    {
        private decimal weekSalary;
        public decimal WeekSalary
        {
            get {
                return weekSalary;
            }
            set {
                weekSalary = value >= 0 ? value : 0;
            }
        }
        public SalariedEmployee(string name, string ssd,decimal salara):base(name,ssd)
        {
            WeekSalary = salara;
        }
        public override decimal Earning()//【【【【抽象方法，在子类实现方法体
        {
            return WeekSalary;
        }
        public override string ToString()//重写子类SalariedEmployee的ToString方法
        {
            return string.Format("SalariedEmployee: {0}\n"
                +"salara is{1:C}", base.ToString(), Earning());//【【 C 或 c 货币格式输出
        }
    }
    public class HourlyEmployee : Employee
    {
        private decimal wage;//小时工资
        public decimal hour; //工作小时
        private decimal Wage
        {
            get{return wage;}
            set{wage = value >= 0 ? value : 0;}
        }
        private decimal Hour
        {
            get{return hour;}
            set{hour = value >= 0 ? value : 0;}
        }
        public HourlyEmployee(string name, string ssd, decimal wage, decimal hours)
            : base(name, ssd)
        {
            Wage = wage;
            Hour = hours;
        }
        public override decimal Earning()//【【【【抽象方法，在子类实现方法体
        {
            if (Hour <= 40)
                return Wage * Hour;
            else
                return (40 * Wage) + (Hour - 40) * (1.5m * Wage);
        }
        public override string ToString()//重写子类SalariedEmployee的ToString方法
        {
            return string.Format("HourlyEmployee: {0}\n"+      //和C语言不同，连续字符串换行，用“+”连接
                "wage is {1},work hours is {2},"+
                " salara is{3:C}", base.ToString(), Wage, Hour,Earning());//【【 C 或 c 货币格式输出
        }
    }
    public class CommissionEmployee : Employee
    {
        private decimal grossSale;//销售总额
        public decimal moneyRate; //提成百分比
        private decimal GrossSale
        {
            get { return grossSale; }
            set { grossSale = value >= 0 ? value : 0; }
        }
        private decimal MoneyRate
        {
            get { return moneyRate; }
            set { moneyRate = value >= 0 ? value : 0; }
        }
        public CommissionEmployee(string name, string ssd, decimal sale, decimal rate)
            : base(name, ssd)
        {
            GrossSale = sale;
            MoneyRate = rate;
        }
        public override decimal Earning()//【【【【抽象方法，在子类实现方法体
        {
            return GrossSale * MoneyRate;
        }
        public override string ToString()//重写子类SalariedEmployee的ToString方法
        {
            return string.Format("CommissionEmployee: {0}\n" +      //和C语言不同，连续字符串换行，用“+”连接
                "GrossSale is {1},MoneyRate is {2}," +
                " salara is{3:C}", base.ToString(), GrossSale, MoneyRate, Earning());//【【 C 或 c 货币格式输出
        }
    }
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;//底薪
        private decimal BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value >= 0 ? value : 0; }
        }
        public BasePlusCommissionEmployee(string name, string ssd, decimal sale, decimal rate, decimal salary)
            : base(name, ssd, sale,rate)
        {
            BaseSalary = salary;
        }
        public override decimal Earning()//【【【【抽象方法，在子类实现方法体
        {
            return base.Earning()+BaseSalary;//销售工资+底薪
        }
        public override string ToString()//重写子类SalariedEmployee的ToString方法
        {
            return string.Format("BasePlusCommissionEmployee: {0}\n" +      //和C语言不同，连续字符串换行，用“+”连接
                "BaseSalary is {1:c}, total salara is {2:C}", 
                base.ToString(),BaseSalary,Earning());//【【 C 或 c 货币格式输出
        }
    }    
}

//SalariedEmployee: Jack's ssd is:1111
//salara is￥100.00
//HourlyEmployee: Rose's ssd is:2222
//wage is 5.3,work hours is 50, salara is￥291.50
//CommissionEmployee: Linda's ssd is:3333
//GrossSale is 12035,MoneyRate is 0.1, salara is￥1,203.50
//BasePlusCommissionEmployee: CommissionEmployee: Miki's ssd is:4444
//GrossSale is 10243,MoneyRate is 0.1, salara is￥1,124.30
//BaseSalary is ￥100.00, total salara is ￥1,124.30
//----------------
//SalariedEmployee: Jack's ssd is:1111
//salara is￥100.00
//HourlyEmployee: Rose's ssd is:2222
//wage is 5.3,work hours is 50, salara is￥291.50
//CommissionEmployee: Linda's ssd is:3333
//GrossSale is 12035,MoneyRate is 0.1, salara is￥1,203.50
//This is BasePlusCommissionEmployee--->
//BasePlusCommissionEmployee: CommissionEmployee: Miki's ssd is:4444
//GrossSale is 10243,MoneyRate is 0.1, salara is￥1,124.30 //【【【神奇】】】父类的Earning方法打印出子类的计算结果
//BaseSalary is ￥100.00, total salara is ￥1,124.30 //子类Earning计算出总工资
//请按任意键继续. . .