﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ms = 0;
        int s1 = 0;
        int h = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            ms++;
            textBox3.Text = Convert.ToString(ms);
            while (ms == 60)
            {
                ms = 0;
                s1++;

            }

            textBox2.Text = Convert.ToString(s1);


            while (s1 == 60)
            {
                s1 = 0;
                h++;

                textBox1.Text = Convert.ToString(h);
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {

                MessageBox.Show("Stopwatch is running!!!!!!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else
            {
                ms = 0;
                s1 = 0;
                h = 0;
                textBox1.Text = Convert.ToString(ms);
                textBox2.Text = Convert.ToString(ms);
                textBox3.Text = Convert.ToString(ms);
            }
        }

       
       
       
        }

       
    }

