﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double dt = 0.01;
        const double g = 9.81;

        double x = 0;
        double y = 0;
        double t = 0;
        double y0;
        double v0;
        double a;

        private void startB_Click(object sender, EventArgs e)
        {
           
            y0 = (double)boxHight.Value;
            v0 = (double)boxSpeed.Value;
            a = (double)boxAngle.Value;
            x = 0;
            y = y0;
            t = 0;

            //Precise scaling по входным данным
            double h = y0+v0 * v0 * Math.Sin(a * Math.PI / 180) * Math.Sin(a * Math.PI / 180) / (2 * g);
            double tmax = (v0 * Math.Sin(a * Math.PI / 180) + Math.Sqrt(v0 * v0 * Math.Sin(a * Math.PI / 180) * Math.Sin(a * Math.PI / 180) + 2 * g * y0)) / g;
            double l = v0 * Math.Cos(a * Math.PI / 180) * tmax;
            chart1.ChartAreas[0].AxisX.Maximum = l;
            chart1.ChartAreas[0].AxisY.Maximum = h;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(x, y);

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            x = v0 * Math.Cos(a * Math.PI / 180) * t;
            y = y0 + v0 * Math.Sin(a * Math.PI / 180) * t - g * t * t / 2;
            labTime.Text = "Time =" + t;
            labX.Text = "X =" + x;
            labY.Text = "Y =" + y;
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0) timer1.Stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.Red;
                timer1.Stop();
            }
            else
            {
                checkBox1.BackColor = Color.LightGray;
                timer1.Start();
            } 
        }
    }
}
