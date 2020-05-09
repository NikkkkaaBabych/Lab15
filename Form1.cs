using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab15
{
    public partial class Form1 : Form
    {
        public double f(double x)
        {
            double k = 55;
            double y;
            try
            {
                y = Math.Pow(Math.Tan(k * x), 2) + Math.Log(k - x) - Math.Pow(k * x, 0.5);
            }
            catch
            {
                y = 0;
            }
            return y;
        }
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            double xmin, xmax, dx, x;
            xmin = Convert.ToDouble(textBoxXmin.Text);
            xmax = Convert.ToDouble(textBoxXmax.Text);
            dx = Convert.ToDouble(textBoxdx.Text);
            for (x = xmin; x < xmax; x += dx)
            {
                listBox1.Items.Add("for x = " + x + "  result z = " + f(x));
            }

        }
    }
}