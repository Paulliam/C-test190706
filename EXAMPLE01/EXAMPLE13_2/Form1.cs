using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMPLE13_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random r = new Random();
            Graphics g = e.Graphics;
            Pen redPen = new Pen(Color.LightBlue, 2);//定义一个画笔，颜色LightBlue，线宽2
            g.DrawLine(redPen, 0, 0, 300, 500);
            for (int i = 0; i < 5; i++)
            {
                var x1 = r.Next(this.Width);
                var x2 = r.Next(this.Width);
                var y1 = r.Next(this.Width);
                var y2 = r.Next(this.Width);
                var colorR = r.Next(256);
                var colorG = r.Next(256);
                var colorB = r.Next(256);
                Pen myPen = new Pen(Color.FromArgb(colorR, colorG, colorB));//myPen三原色随机组合
                g.DrawLine(redPen, x1, y1, x2, y2);
                g.DrawLine(myPen, x1, y2, x2, y1);
            }            
        }
    }
}
