using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMPLE12_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baseMoney = Convert.ToDouble(textBoxBase.Text);
            var year = Convert.ToInt32(textBoxYear.Text);
            var interest = Convert.ToDecimal(textBoxInterest.Text);
            textBoxSum.Text=
                (baseMoney * 
                Math.Pow(Convert.ToDouble(1 + interest), year))//返回(1+interest)的year次幂
                .ToString();//将最终结果转换为字符串
        }
    }
}
