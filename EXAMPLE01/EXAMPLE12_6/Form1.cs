using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMPLE12_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//加载form框时图片显示区pictureBox1做一个初始化显示
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;//PictureBoxSizeMode.Zoom;Zoom为一图片显示方式，居中，缩放等等
            //pictureBox1.ImageLocation = @"C:\Users\Administrator.USER-20140101DA\Desktop\test\EXAMPLE01\EXAMPLE12_6\图片\TabControl(控件)1.png";
            pictureBox1.Image = Properties.Resources.TabControl_控件_1;
        }
        bool FlgClick = false;
        private void buttonGo_Click(object sender, EventArgs e)//点击“开始显示图片”按钮触发事件-开始计时
        {
            FlgClick = FlgClick == true ? false : true;
            if (FlgClick == false)
                timer1.Enabled = false;//关闭定时器
            else
                timer1.Enabled = true;
        }
        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)//定时事件TICK产生
        {
            //更新进度条显示，并切换图片显示
            var incr=Convert.ToInt32(numericUpDown.Value);//获取数字调节控件当前值
            if (incr + progressBar.Value <= progressBar.Maximum)//以incr为步长调节进度条显示位置
                progressBar.Value += incr;//progressBar.Value的上限progressBar.Maximum是可取得
            else
            {
                FlgClick = false; timer1.Enabled = false;//关闭定时器
                progressBar.Value = 0; //进度条清零
                //index = 0;//复位，显示第0张图片
            }

            index = (index + 1) % 5;
            if (0 == incr)
                index = 0;
            switch (index)
            {
                case 0:
                    //【【【【加载本地资源--加载图片的绝对路径
                    //pictureBox1.ImageLocation = 
                    //@"C:\Users\Administrator.USER-20140101DA\Desktop\test\EXAMPLE01\EXAMPLE12_6\图片\TabControl(控件)1.png";
                    //【【【【加载项目资源--设置方法：解决方案资源管理器->项目->右键点击->属性->资源->图像->添加资源
                    pictureBox1.Image = Properties.Resources.TabControl_控件_1;
                    break;
                case 1:
                    //pictureBox1.ImageLocation =
                    //@"C:\Users\Administrator.USER-20140101DA\Desktop\test\EXAMPLE01\EXAMPLE12_6\图片\TabControl(控件)2.png";
                    pictureBox1.Image = Properties.Resources.TabControl_控件_2;
                    break;
                case 2:
                    //pictureBox1.ImageLocation =
                    //@"C:\Users\Administrator.USER-20140101DA\Desktop\test\EXAMPLE01\EXAMPLE12_6\图片\TreeView(控件)9.png";
                    pictureBox1.Image = Properties.Resources.TreeView_控件_9;
                    break;
                case 3:
                    //pictureBox1.ImageLocation =
                    //@"C:\Users\Administrator.USER-20140101DA\Desktop\test\EXAMPLE01\EXAMPLE12_6\图片\TreeView(控件)10.png";
                    pictureBox1.Image = Properties.Resources.TreeView_控件_10;
                    break;
                case 4:
                    //pictureBox1.ImageLocation =
                    //@"C:\Users\Administrator.USER-20140101DA\Desktop\test\EXAMPLE01\EXAMPLE12_6\图片\TreeView(控件)2.png";
                    pictureBox1.Image = Properties.Resources.TreeView_控件_2;
                    break;
            }
        }
    }
}
