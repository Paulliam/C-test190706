using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMPLE12_2_copy
{
    public partial class FormTextShow : Form //partial表示下面的代码只是Form类的部分代码
    {
        public FormTextShow()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)//TextChanged事件触发时执行程序(又名“消息处理程序”)
        {
            textBoxOutput.Text = textBoxInput.Text;//用户自主代码段--此处将输入文本框中的字符串拷贝到输出文本框
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
