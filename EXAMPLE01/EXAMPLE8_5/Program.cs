using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************
 * 章节： 8继承  8.5 例题-包裹投递
 * 要点：快递行业投递包裹，一般按照不同紧急程度收取不同费用
 *       比如，三日达，次日达，当日达
 *       1）创建一个继承层次来表示不同类型的包裹，将package类
 *       作为基类，将ThreeDayPackage类和OvernightPackage类作为
 *       他的派生类。基类Package包含发件人和收件人的姓名，地址，
 *       及包裹重量(单位：克)，以及投递包裹费用(单位：克/元)，
 *       这些变量为protected
 *       2）Package类包含必要的构件函数CalculateCost()，用于计
 *       算包裹的基本费用，公式：基本费用=重量*投递标准费用单价；
 *       3）ThreeDayPackage和OvernightPackage在标准基本费用基础
 *       上，增加加急费用（重量*额外费用单价）
 * 题目： 
 *        
 * 时间：2019、06、19
 ***************************************************/	
namespace EXAMPLE8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeDayPackage tp = new ThreeDayPackage("Sender", "Receiver", "中国深圳宝安区", 1500m, 0.2m, 0.3m);//decimal的数据类型一定要带后缀m,显示指明
            Console.WriteLine("tp's cost is: {0}", tp.CalculateCost());

        }
    }
    public class Package
    {
        protected string SendName { get; set; }
        protected string RecvName { get; set; }
        protected string AddrName { get; set; }
        protected decimal Weight;
        protected decimal Fee;

        protected decimal weight
        {
            get {
                return Weight;
            }
            set {
                Weight = value < 0 ? 0 : value;
            }
        }
        protected decimal fee
        {
            get
            {
                return Fee;
            }
            set
            {
                Fee = value < 0 ? 0 : value;
            }
        }
        public Package(string sn, string rn, string adr, decimal w, decimal f)
        {
            SendName = sn;
            RecvName = rn;
            AddrName = adr;
            fee = f;
            weight = w;
        }
        protected decimal CalculateCost()
        {
            return fee * weight;
        }
    }
    public class ThreeDayPackage : Package
    {
        protected decimal ExFee;
        protected decimal exfee
        {
            get
            {
                return ExFee;
            }
            set
            {
                ExFee = value < 0 ? 0 : value;
            }
        }
        public ThreeDayPackage(string sn, string rn, string adr, decimal w, decimal f,decimal exf):base(sn,rn,adr,w,f)
        {
            exfee = exf;
        }
        public decimal CalculateCost() //子类的方法名可以和父类的方法命名相同,该命名将在此隐藏父类的方法
        {
            return exfee * weight + base.CalculateCost(); //此处要显示指明调用父类的方法CalculateCost()，而不是自己的
        }
    }
}

//tp's cost is: 750.0
//请按任意键继续. . .