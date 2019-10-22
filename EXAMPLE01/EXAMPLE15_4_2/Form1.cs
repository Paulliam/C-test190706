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
 * 题目：1）二进制文件操作BinaryWriter，BinaryReader
 * 要点：1）
 *          
 * 时间：2019、07、05
 ***************************************************/
namespace EXAMPLE15_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog saDialog = new SaveFileDialog();
            if (saDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saDialog.FileName,FileMode.Create,FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                var valInt = Convert.ToInt32(textBox1.Text);
                var valDouble = Convert.ToDouble(textBox2.Text);
                var valString = textBox3.Text;
                bw.Write(valInt);//写一个二进制数据
                bw.Write(valDouble);
                bw.Write(valString);//写二进制字符串
                bw.Close();
                fs.Close();
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();
            if(opDialog.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(opDialog.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBox4.Text = br.ReadInt32().ToString();
                textBox5.Text = br.ReadDouble().ToString();//以浮点数的形式读一个二进制数据
                textBox6.Text = br.ReadString().ToString();
                br.Close();
                fs.Close();
                //byte[] arr=new byte[100];
                //byte[] arr2 = new byte[100];
                //fs.Read(arr, 0, 50); //不管是哪种方式读取文件流，读取后，读取指针都向后移动了
                //br.Read(arr2, 0, 50);//不管是哪种方式读取文件流，读取后，读取指针都向后移动了
                //arr[0] = 0x66;
                //arr[1] = 0x67;
                //textBox3.Text = "0x"+(arr[1] / 16).ToString() + (arr[1] % 16).ToString();
            }
        }
    }
}
