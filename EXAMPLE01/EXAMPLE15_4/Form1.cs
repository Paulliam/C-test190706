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
/***************************************************
 * 章节： 14文件  15.4 例题-文件
 * 题目：1）文件StreamWriter，StreamReader
 * 要点：1）
 *          
 * 时间：2019、07、05
 ***************************************************/
namespace EXAMPLE15_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            string fileName;
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = "TEXT|*.txt";
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = sfDialog.FileName;
                StreamWriter stWriter = new StreamWriter(fileName);
                stWriter.Write(textBox1.Text);
                stWriter.WriteLine();
                stWriter.Close();
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "文本文件|*.txt";
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader stReader = new StreamReader(ofDialog.FileName);//指定读取文件流的文件来源
                textBox1.Text = stReader.ReadToEnd();
                stReader.Close();
            }
        }
    }
}
