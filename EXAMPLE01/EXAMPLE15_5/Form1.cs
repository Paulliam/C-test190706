using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//【【【关于文件操作的方法类需要手动添加命名空间
using System.Runtime.Serialization.Formatters.Binary;//【【【BinaryFormatter序列化类的所在
/***************************************************
 * 章节： 14文件  15.5 例题-文档序列化
 * 题目：1）将一个对象以序列化的形式存储到磁盘；并以去序列化的方式从磁盘读出
 * 要点：1）序列化Serialize
 *       2）去序列化Deserialize
 * 时间：2019、07、06
 ***************************************************/
namespace EXAMPLE15_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            MyData mydata = new MyData();
            if (textBox1.Text != "") //字符串查空方法1
            {
                mydata.valInt = Convert.ToInt32(textBox1.Text);
            }
            else
                return;
            if (textBox2.Text != string.Empty) //字符串查空方法2
            {
                mydata.valDou = Convert.ToDouble(textBox2.Text);
            }
            else
                return;
            mydata.valStr = textBox3.Text;
            FileStream fs =new FileStream("D:\\新建文件夹\\mydata",FileMode.OpenOrCreate,FileAccess.Write);
            BinaryFormatter bf =new BinaryFormatter();
            bf.Serialize(fs,mydata);//将对象mydata序列化到给定流fs
            fs.Close();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            MyData mydata = new MyData();
            FileStream fs = new FileStream("D:\\新建文件夹\\mydata", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            mydata = (MyData)bf.Deserialize(fs);//将指定的流反序列化为对象图形,返回类型为Object,需强制转换为MyData
            textBox1.Text = mydata.valInt.ToString();
            textBox2.Text = mydata.valDou.ToString();
            textBox3.Text = mydata.valStr;
            fs.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;//文本框显示字符串清空方法1
            textBox2.Text = "";          //文本框显示字符串清空方法2
            textBox3.Clear();            //文本框显示字符串清空方法3
        }
    }

    [Serializable]  //指示下面的类MyData可以序列化
    public class MyData
    {
        public int valInt;
        public double valDou;
        public string valStr;
    }
}
