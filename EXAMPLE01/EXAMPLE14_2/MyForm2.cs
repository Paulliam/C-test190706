using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMPLE14_2
{
    public partial class MyForm2 : Form
    {
        public MyForm2()
        {
            InitializeComponent();
        }
        public string DetailText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
    }
}
