using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 8继承  8.6 例题-银行账户
 * 题目：创建一个继承层次，让银行表示客户的银行账户。
 *       1）银行账户（父类Account）可以用其账户存款，取款
 *       2）存款账户（子类SavingAccount）可以获得利息(interest)；
 *          其构造函数接收账户结余和利率初值，并通过公用函数Calculate
 *          返回其利息值
 *       3）支票账户（子类CheckingAccount）则按事物收取手续费,
 *          其构造函数接收账户结余初始值和事物手续费，CheckingAccount
 *          类要重定义Credit和Debit，使得事物办理成功时，从账户中扣掉
 *          手续费
 * 要点： 重定义父类中的继承类的方法
 * 时间：2019、06、19
 ***************************************************/
namespace EXAMPLE8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sa = new SavingAccount(23f, 0.2f);
            Console.WriteLine("sa的本金：{0}", sa.Balance); //打印账户sa的存款金额
            sa.Credit(34);//存34元
            Console.WriteLine("sa的剩余金额：{0}", sa.Balance); //打印账户sa的存款金额
            Console.WriteLine("sa的利息：{0}", sa.CalculateInterest());

            CheckingAccount ca = new CheckingAccount(15.5f,0.3f);//手续费固定0.3元每笔取款操作
            Console.WriteLine("ca的本金：{0}", ca.Balance);
            ca.Debit(5f);
            Console.WriteLine("ca的剩余金额：{0}", ca.Balance);

        }
    }
    public class Account
    {
        private float balance;//初始结余-本金private修饰，继承后，派生类不可访问该字段
        public float Balance  //public修饰，继承后，派生类可通过属性访问该字段
        {
            get {
                return balance;
            }
        }
        public Account()
        {
            balance = 0;
        }
        public Account(float b)
        {
            balance = b > 0 ? b : 0;
        }
        public void Credit(float m) //存款
        {
            balance += m;
        }
        public Boolean Debit(float m) //取款
        {
            if (balance >= m)
            {
                balance -= m;
                return true;
            }
            else
                return false;
        }
    }
    public class SavingAccount : Account
    {
        private float interest; //存款利率
        public SavingAccount(float b,float i):base(b)
        {
            interest = i;
        }
        public float CalculateInterest()
        {
            return interest * Balance;//父类的balance字段是private型的，则
                            //要通过public型的属性Balance来访问字段balance
        }
    }
    public class CheckingAccount : Account
    {
        private float fee;
        public CheckingAccount(float b,float f):base(b)
        {
            fee = f;
        }
        public new void Debit(float m) //【【【【重定义父类中的继承来的方法】】】
        {  //注意区别于父类的public Boolean Debit(float m)
            if (base.Debit(m))
            {
                base.Debit(fee);//可能余额不足以扣除手续费，暂且忽略
            }
        }
    }
}

//sa的本金：23
//sa的剩余金额：57
//sa的利息：11.4
//ca的本金：15.5
//ca的剩余金额：10.2
//请按任意键继续. . .