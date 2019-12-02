using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasker
{
    class Taskers: Panel
    {
        public Taskers(TaskPanel[] ts)
        {
            this.Dock = DockStyle.Fill;
            foreach (TaskPanel t in ts)
            {
                this.Controls.Add(t);
            }
        }
    }
}
