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
 * 章节： 14窗体，对话框和菜单  14.3 例题-对话框
 * 题目：1）通过一个按钮进入一个目录，选择打开/保存一个文件
 * 要点：1）文件夹打开对话框、文件夹保存对话框、
 *          文件夹浏览对话框、文件夹颜色对话框
 * 时间：2019、07、04
 ***************************************************/
namespace EXAMPLE14_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string openfilename;
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fsDialog = new OpenFileDialog();
            fsDialog.Filter = "文本文件|*.pdf;*.txt|微软文件|*.doc";//设置对话过滤显示出的文件类型，文本文件--*.pdf;*.txt
            if (fsDialog.ShowDialog() == DialogResult.OK)
            {
                openfilename = fsDialog.FileName;
                textBoxOpen.Text = openfilename;//将打开的文件路径名显示到文本框控件
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = "文本文件|*.pdf;*.c|EXCEL文件|*.xls";//设置文件保存类型
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSave.Text = sfDialog.FileName;//将保存的文件路径名显示到文本框控件
            }
        }

        private void buttonBrows_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxBrows.Text = fbDialog.SelectedPath;//SelectedPath：浏览选中的文件夹的路径名
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxColor.BackColor = colorDialog.Color;//将获取选中的颜色作为文本框的背景色
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBoxFont.Font = fd.Font;//将获取的字体类型设置为文本框的字体类型
                textBoxFont.Text = "这是您刚刚设置的字体类型，that's your choice!";
            }
        }
    }
}
