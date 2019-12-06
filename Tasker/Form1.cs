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
            TaskPanel ts2 = new TaskPanel("22222", "cndsgggggggggggggggggggggggggggggggggggggggggggg");
            TaskPanel ts3 = new TaskPanel("2222222", "cndsgggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggfffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffggggggggg");
            TaskPanel ts4 = new TaskPanel("njddfdsfsdb", "cnds");
            TaskPanel ts5 = new TaskPanel("njdb", "cnds");
            TaskPanel ts6 = new TaskPanel("njdb", "cnds");
            TaskPanel ts7 = new TaskPanel("njdb", "cnds");
            TaskPanel ts8 = new TaskPanel("njdb", "cnds");
            TaskPanel ts9 = new TaskPanel("ппп", "иииии");
            TaskPanel ts10 = new TaskPanel("njdb", "cnds");
            TaskPanel ts22 = new TaskPanel("njfvfvfdvdb", "cnds");
            TaskPanel ts23 = new TaskPanel("njdvdvsvsb", "cnds");
            TaskPanel ts24 = new TaskPanel("njddfdsfsdb", "cnds");
            TaskPanel ts25 = new TaskPanel("njdb", "cnds");
            TaskPanel ts26 = new TaskPanel("njdb", "cnds");
            TaskPanel ts27 = new TaskPanel("njdb", "cnds");
            TaskPanel ts28 = new TaskPanel("njdb", "cnds");
            TaskPanel ts29 = new TaskPanel("ппп", "иииии");
            TaskPanel ts310 = new TaskPanel("njdb", "cnds");
            TaskPanel ts11 = new TaskPanel("gwhgbwrhgbr", "cnds");
            //ts4.StyleChanged();
           
            TaskPanel[] tt = new TaskPanel[]{ts,ts2,ts3, ts4, ts5, ts6, ts7,ts8,ts9,ts10, ts22, ts23, ts24, ts25, ts26, ts27, ts28, ts29, ts310 };
            
            Taskers task = new Taskers(tt);

            //task.ItemsAdd(tt);
            task.item.Add(ts2);
            task.item.Add(ts3);
            task.item.Add(ts4);
            //ts.Visible = false;
            Controls.Add(task);

            //task.Controls.Add(ts11);
            task.item.Delete(ts2);
           

            //MessageBox.Show(task.item.Count().ToString());    


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
