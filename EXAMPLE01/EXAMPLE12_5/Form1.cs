using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMPLE12_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text != string.Empty)//如果输入框不为空，点击添加按钮时
            {    //要将数据添加到列表框
                listBox1.Items.Add(textBoxInput.Text);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//列表框中选中的项发生变化时，该事件产生
        {
            if (listBox1.SelectedIndex >= 0 && 
                listBox1.SelectedIndex < listBox1.Items.Count)//只有在鼠标选中某一项时，才操作，没选中是，值为-1
                 //textBoxInput.Text = Convert.ToString(listBox1.Items[listBox1.SelectedIndex]);//转换为字符串方法一
                 textBoxInput.Text = (listBox1.Items[listBox1.SelectedIndex]).ToString();     //转换为字符串方法二
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>=0 &&
               listBox1.SelectedIndex<listBox1.Items.Count)//只有在鼠标选中某一项时，才操作，没选中是，值为-1
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);//点击删除按钮，删除列表中的某项
        }
    }
}
