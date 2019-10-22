using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/***************************************************
 * 章节： 14窗体，对话框和菜单  14.3 例题-菜单
 * 题目：1）制作一个菜单栏
 * 要点：1）
 *          
 * 时间：2019、07、05
 ***************************************************/
namespace EXAMPLE14_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 拷贝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void 编辑ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {//编辑框正在下拉事件触发时
            if (textBox1.SelectedText == string.Empty)//【【判定被选中的文本是否为空
            {
                剪切ToolStripMenuItem.Enabled = false;//剪切菜单变灰禁能
            }
            else
            {
                剪切ToolStripMenuItem.Enabled = true;//剪切菜单变亮使能
            }
        }

        /* 以下三项上下文菜单需要让textBox1关联contexMenStrip1,方法是:
         * textBox1->属性->行为->contexMenStrip->选中contexMenStrip1
         */
        private void a拷贝ToolStripMenuItem_Click(object sender, EventArgs e)
        {//右键上下文菜单中的拷贝项
            textBox1.Copy();
        }

        private void b剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {//右键上下文菜单中的剪切项
            textBox1.Cut();
        }

        private void c粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {//右键上下文菜单中的粘贴项
            textBox1.Paste();
        }
    }
}
