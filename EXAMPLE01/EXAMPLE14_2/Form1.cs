using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMPLE14_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyForm2 myform2 = new MyForm2();
            if (radioButton1.Checked)//检测单选控件1是否被选中
            {
                myform2.DetailText = "详细的日期：\r\n" + 
                    "2019年7月4日 14：26 ";
            }
            if (radioButton2.Checked)//检测单选控件2是否被选中
            {
                myform2.DetailText = "详细的内容：\r\n" +
                "1、国务院常务会议3日召开，支持跨境电商等新业态发展；\r\n" +
                "2、国家移民管理局3日表示，海南将实施更加开放的免签入境政策；\r\n" +
                "3、工信部日前发布一季度电信服务质量通告显示。";
            }
            myform2.Show();//【【【Show()显示出第二个窗体myform2--只显示后直接返回
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyForm3 myform3 = new MyForm3();
            if (DialogResult.OK == myform3.ShowDialog()) //【【【ShowDialog()显示出第三个窗体myform3--该窗体为对话窗体，需要手动关闭或设置返回
            {//返回DialogResult.OK，表示窗体myform3退出时，是点击了确认按钮
                textBoxNAME.Text = myform3.MyName;
                textBoxAGE.Text = myform3.Age.ToString();
                //textBoxAGE.Text = Convert.ToString(myform3.Age); //或者写成这样转换
            }            
        }
    }
}
