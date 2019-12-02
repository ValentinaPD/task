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
        public Taskers(TaskPanel[] ts)
        {
            this.ColumnCount = 1;
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.Azure;
            this.AutoScroll = true;
            foreach (TaskPanel t in ts)
            {
                t.Dock = DockStyle.Fill;
                this.Controls.Add(t);
            }
        }
    }
}
