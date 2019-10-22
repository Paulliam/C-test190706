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
    public partial class MyForm3 : Form
    {
        public MyForm3()
        {
            InitializeComponent();
        }
        public string MyName { get; set; }
        public int Age { get; set; }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
                MyName = textBoxName.Text;
            if (textBoxAge.Text != string.Empty) //【【【防止年龄值为空时，
                Age = Convert.ToInt32(textBoxAge.Text);//值转换执行将异常
            //Close();//【【【关闭MyForm3对话框窗体方法一 //该窗体为对话窗体，需要手动关闭或设置返回
            //【【【关闭MyForm3对话框窗体方法二:设置返回,将buttonOK属性->行为->DialogResult项值设置为OK
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
