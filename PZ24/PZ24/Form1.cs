﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PZ24
{
    public partial class Form1 : Form
    {
        public class MyEA : EventArgs
        {
            public char ch;
            public int hgt;
        }
        class MyEH
        {
            public event EventHandler<MyEA> Ez;
            public void OnEz(MyEA c) { }
        }
        public static bool flag = false;
        char[] symb = { 'R', 'G', 'B', 'Y', 'X' };
        int[] height = { 150, 200, 250, 300 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void ChangeBackColor(object sender, EventArgs e)
        {
            switch (choose)
            {
                case 'R':
                    if (flag) { this.BackColor = Color.Red; }
                    this.Height = height[0];
                    this.Width = 350 + height[0];
                    break;
                case 'G':
                    if (flag) { this.BackColor = Color.Green; }
                    this.Height = height[1];
                    this.Width = 350 + height[1];
                    break;
                case 'B':
                    if (flag) { this.BackColor = Color.Blue; }
                    this.Height = height[2];
                    this.Width = 350 + height[2];
                    break;
                case 'Y':
                    if (flag) { this.BackColor = Color.Yellow; }
                    this.Height = height[3];
                    this.Width = 350 + height[3];
                    break;
                case 'X':
                    if (flag) { this.BackColor = SystemColors.Control; }
                    this.Height = height[0];
                    this.Width = 350 + height[0];
                    break;
            }
        }
        public Char choose;
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choose = symb[comboBox1.SelectedIndex];
            ChangeBackColor(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

}