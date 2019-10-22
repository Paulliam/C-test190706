using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMPLE12_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.MouseWheel += panel1_MouseWheel;
        }
        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            textBox1.Text += "E:Delta=" + e.Delta.ToString() + "  ";
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)//鼠标三个键按下事件
        {
            if (e.Button == MouseButtons.Left)//判断是否为鼠标左键按下
            {
                textBox1.Clear();//清除文本框中的显示数据
                textBox1.Text = "MouseLocation X:" + e.X.ToString() +
                    "  MouseLocation Y:" + e.Y.ToString();//打印鼠标按下处对于panel1区域的横纵坐标            
                textBox1.Text += "  MouseButtons: LEFT;";
            }            
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text += "  MouseHover;";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//【【【【需要将From->杂项->KeyPreview属性设置为True,该事件才能正常提示相关文本消息
            textBox1.Text +=
                "  Alt: " + (e.Alt ? "Yes" : "NO") + //判断ALT键是否已经被按下
                "  Control: " + (e.Control ? "Yes" : "NO") +
                "  Shift: " + (e.Shift ? "Yes" : "NO") + ";";
            textBox1.Text += "  KeyDown:" + e.KeyCode.ToString() + ";"; //打印键值
            if (Keys.M == e.KeyCode)//Keys枚举类型，此处判断按下按键是否为枚举类中的M键
            {
                textBox1.Text += "  M key was pressed!";
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)//该事件不能检测"F1到F12"等
        {         //也不能检测Alt,Control,Shift,Cpaslock等等按键
            //【【【【需要将From->杂项->KeyPreview属性设置为True,该事件才能正常提示相关文本消息
            textBox1.Text += "  KeyPress:" + e.KeyChar + ";";
        }
    }
}
