﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString());
            
            TaskPanel ts=new TaskPanel("njdb","cnds");
            TaskPanel ts2 = new TaskPanel("njdb", "cnds");
            TaskPanel ts3 = new TaskPanel("njdb", "cnds");
            TaskPanel ts4 = new TaskPanel("njdb", "cnds");
            TaskPanel ts5 = new TaskPanel("njdb", "cnds");
            TaskPanel ts6 = new TaskPanel("njdb", "cnds");
            TaskPanel ts7 = new TaskPanel("njdb", "cnds");
            TaskPanel ts8 = new TaskPanel("njdb", "cnds");
            TaskPanel ts9 = new TaskPanel("njdb", "cnds");
            TaskPanel ts10 = new TaskPanel("njdb", "cnds");
            TaskPanel ts11 = new TaskPanel("njdb", "cnds");
            ts.BackColor = Color.Aqua;
            ts2.BackColor = Color.Red;
            ts3.BackColor = Color.Green;
            TaskPanel[] tt = new TaskPanel[]{ts,ts2,ts3, ts4, ts5, ts6, ts7};
            Taskers task = new Taskers(tt);
            Controls.Add(task);
            
        }
    }
}
