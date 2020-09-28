using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        public int Times { get; set; }
        public double Leng { get; set; }
        public double Per1 { get; set; }
        public double Per2 { get; set; }
        public double Th1 { get; set; }
        public double Th2 { get; set; }
        public Pen DrawPen { get; set; }

        public void drawLine(double x0, double y0, double x1, double y1,Pen pen)
        {
            graphics.DrawLine(pen,(int)x0,(int)y0,(int)x1,(int)y1);
        }
        
        public void DrawCayleyTree(int n,double x0,double y0,double leng,double per1,double per2,double th,Pen pen)
        {
            if (n == 0) return;

            double x1 = x0 + leng * per1 * Math.Sin(th);
            double y1 = y0 - leng * per1 * Math.Cos(th);
            double x2 = x0 + leng * per2 * Math.Sin(th);
            double y2 = y0 - leng * per2 * Math.Cos(th);

            if(per1>per2)
            {
                drawLine(x0, y0, x1, y1,pen);
            }
            else
            {
                drawLine(x0, y0, x2, y2, pen);
            }

            DrawCayleyTree(n - 1, x1, y1, leng * per1, per1, per2, th+Th1*Math.PI/180, pen);
            DrawCayleyTree(n - 1, x2, y2, leng * per2, per1, per2, th-Th2*Math.PI/180, pen);
        }


        private void btnDraw_Click_1(object sender, EventArgs e)
        {
            
            if(graphics==null)
                graphics = this.CreateGraphics();
            graphics.Clear(Control.DefaultBackColor);

            DrawCayleyTree(Times, 200, 300, Leng, Per1, Per2, 0, DrawPen);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pen[] pens = { Pens.Red, Pens.Blue, Pens.Green };
            txtTimes.DataBindings.Add("Text", this, "Times");
            txtLeng.DataBindings.Add("Text", this, "Leng");
            txtPer1.DataBindings.Add("Text", this, "Per1");
            txtPer2.DataBindings.Add("Text", this, "Per2");
            txtTh1.DataBindings.Add("Text", this, "Th1");
            txtTh2.DataBindings.Add("Text", this, "Th2");
            DrawPen = new Pen(Color.Red);
            cbboxPen.DataSource = pens;
            cbboxPen.DisplayMember = "Color";
            cbboxPen.DataBindings.Add("SelectedItem", this, "DrawPen");
        }
    }
}
