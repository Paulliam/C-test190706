using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMPLE13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Point> listPoint = new List<Point>(300);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            listPoint.Add(p);//记录鼠标单击过的点
            Invalidate();
            Graphics g = CreateGraphics();
            SolidBrush blueBrush = new SolidBrush(Color.Blue);            
            g.FillEllipse(blueBrush, new Rectangle(e.X - 20, e.Y - 20, 40, 40));//画出该点
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = CreateGraphics();
            Graphics g = e.Graphics;
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Pen blackPen = new Pen(Color.Black, 2);
            for (int i = 0; i < listPoint.Count; i++)//窗口缩小重新打开时，重绘所有点
            {
                g.FillEllipse(blueBrush, new Rectangle(listPoint[i].X - 20, listPoint[i].Y - 20, 40, 40));
                if (i < listPoint.Count - 1)
                    g.DrawLine(blackPen, listPoint[i], listPoint[i + 1]);//连接两个点
            }                
        }
    }
}
