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
 * 题目：1）选中不同的驱动器磁盘，分别其中的文件夹，及各个文件
 * 要点：1）comboBox下拉控件的使用、列表框控件的使用
 *       2）文件目录、文件名获取方法
 * 时间：2019、07、06
 ***************************************************/
namespace EXAMPLE15_4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] dirs;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  //以下拉列表框中的驱动器路径名作为GetDirectories()方法检索目录的入参            
            try
            {
                dirs = Directory.GetDirectories(comboBox1.Text); //获取comboBox1.Text指定目录下的所有子目录
                listBox1.Items.Clear();//清空目录显示列表框listBox1中的所有显示项            
                foreach (var n in dirs)
                {
                    listBox1.Items.Add(n);//将各个子目录名添加进目录显示列表框
                    //listBox1.Items.Add(Path.GetFileNameWithoutExtension(n));//Path.Getxx()方法,可获取指定目录相关信息
                }
                listBox2.Items.Clear();//清空文件显示列表框listBox2中的所有显示项
                foreach (var n in Directory.GetFiles(comboBox1.Text))
                {
                    listBox2.Items.Add(n);//将各个子目录名添加进文件显示列表框
                    //listBox2.Items.Add(Path.GetFileName(n));
                }
            }
            catch (IOException excep)//当下拉框选中空磁盘的时候，会有一个奇怪的异常产生
            {
                listBox1.Items.Add("");//在列表框底部先空白一行列表，
                listBox1.Items.Add("IOException'name is: " + excep.GetType().Name); //紧接着，着这里打印异常消息提示
                listBox1.Items.Add("IOException'message is: " + excep.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {//加载form事件发生时
            //将逻辑驱动器加载到comboBox1下拉框中
            foreach (var logicDriver in Directory.GetLogicalDrives())//GetLogicalDrives()检索逻辑各个驱动器
            {
                comboBox1.Items.Add(logicDriver);//将每个逻辑驱动器的名字添加到列表下拉框中
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {//双击列表中的某一列表项时，事件发生            
            if (listBox1.SelectedIndex == -1)//如果双击选中列表项为空时，该值为-1
            { return; }
            var currentDir = dirs[listBox1.SelectedIndex];
            dirs = Directory.GetDirectories(currentDir);
            if (dirs.GetUpperBound(0) == -1)//GetUpperBound(0)获取数组第0维的元素个数，这里是获取子目录是否为空
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox1.Items.Add("您双击选中的文件夹目录下的子目录为空！");
                return; 
            }
            listBox1.Items.Clear();//清空目录显示列表框listBox1中的所有显示项 
            foreach (var n in dirs)//【【【数组dirs为空时，不报错，且不执行遍历
            {
                //listBox1.Items.Add(n);//将各个子目录名添加进目录显示列表框
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(n));//Path.Getxx()方法,可获取指定目录相关信息
            }
            listBox2.Items.Clear();//清空文件显示列表框listBox2中的所有显示项
            foreach (var n in Directory.GetFiles(currentDir))
            {
                //listBox2.Items.Add(n);//将各个子目录名添加进文件显示列表框
                listBox2.Items.Add(Path.GetFileName(n));
            }
        }
    }
}
