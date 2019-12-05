using System;
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
          
             
        TaskPanel ts=new TaskPanel("njdb","cnds");
            TaskPanel ts2 = new TaskPanel("njdb", "cnds");
            TaskPanel ts3 = new TaskPanel("njdb", "cnds");
            TaskPanel ts4 = new TaskPanel("njdb", "cnds");
            TaskPanel ts5 = new TaskPanel("njdb", "cnds");
            TaskPanel ts6 = new TaskPanel("njdb", "cnds");
            TaskPanel ts7 = new TaskPanel("njdb", "cnds");
            TaskPanel ts8 = new TaskPanel("njdb", "cnds");
            TaskPanel ts9 = new TaskPanel("ппп", "иииии");
            TaskPanel ts10 = new TaskPanel("njdb", "cnds");
            TaskPanel ts11 = new TaskPanel("gwhgbwrhgbr", "cnds");
            //ts4.StyleChanged();
           
            TaskPanel[] tt = new TaskPanel[]{ts,ts2,ts3, ts4, ts5, ts6, ts7,ts8,ts9,ts10};
            
            Taskers task = new Taskers(tt);
            
            task.ItemsAdd(tt);
            task.VueStyletiles();
           
            Controls.Add(task);
            task.Controls.Add(ts11);
                        
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
