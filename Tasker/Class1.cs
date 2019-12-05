using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasker
{
    class Taskers: TableLayoutPanel
    {
        private int ItemsCount = 0;
      
        public Taskers()
        {
            Taskers taslers = new Taskers();
            Controls.Add(taslers);
        }
        
        public Taskers(TaskPanel[] ts)
        {

            /*
             this.ColumnCount = 1;
             this.Dock = DockStyle.Fill;
             this.BackColor = Color.Azure;
             this.AutoScroll = true;
             foreach (TaskPanel t in ts)
             {
                 t.Dock = DockStyle.Fill;
                 this.Controls.Add(t);
             }
            this.Dock = DockStyle.Fill;
           */
            this.AutoScroll = true;
            this.AutoSize = false;
            this.ColumnCount = 3;
            ItemsCount = ts.Count();
           
            ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent,100/ this.ColumnCount));
            ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / this.ColumnCount));
            ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / this.ColumnCount));
            RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / 3));
            RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / 3));
            RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / 3));

            foreach (TaskPanel t in ts)
            {
                t.Dock = DockStyle.Fill;

                this.Controls.Add(t);
            }

        }
        public void ItemsAdd(TaskPanel ts)
        {
            
            this.Controls.Add(ts);
            ItemsCount++;
        }
        public void ItemsAdd(TaskPanel[] ts)
        {
            foreach (TaskPanel t in ts)
            {
                t.Dock = DockStyle.Fill;
                
                this.Controls.Add(t);
            }
            this.ItemsCount += ts.Count();
        }
        public void VueStylelines()
        {
            this.ColumnCount = 1;
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.Azure;
            this.AutoScroll = true;
           
        }
        public void VueStyletiles()
        {
            this.Dock = DockStyle.Fill;

            this.AutoScroll = true;
            this.AutoSize = false;
            this.ColumnCount = 3;
            ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / this.ColumnCount));
            ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / this.ColumnCount));
            ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / this.ColumnCount));
            RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / 3));
            RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / 3));
            RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / 3));


        }

    }
   

}



