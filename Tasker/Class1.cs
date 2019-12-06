using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasker
{
    class Taskers : Panel
    {
        public Item item;

        private int RowsCount
        {
            set
            {
                if (value > 0 && value < 6)
                {
                    this.RowsCount = value;
                }
            }
            get
            {
                return RowsCount;
            }
        }
        public Taskers()
        {
            Instalize();
        }
        public Taskers(TaskPanel ts)
        {
            Instalize();
            item.Add(ts);
        }

        public Taskers(TaskPanel[] ts)
        {
            Instalize();
            this.item = new Item(this);
            foreach (TaskPanel t in ts)
            {
                item.Add(t);
            }
        }
        private void Instalize()
        {
            this.Dock = DockStyle.Fill;
            this.item = new Item(this);
            this.BackColor = Color.Azure;
            this.AutoScroll = true;
        }
        
       
    }
    class Item
    {
        private Taskers parent;
        private  int count = 0;

        public int Count()
        {
            return this.count;
        }
        public  Item(Taskers parent)
        { 
            this.parent = parent;
        }
      
        public void Add(TaskPanel tp)
        {
            this.parent.Controls.Add(tp);
            count++;
        }
        public void Delete(TaskPanel tp)
        {
            this.parent.Controls.Remove(tp);
        }
    }
    class VueStyle
    {
        private int ColumnCount = 0;

        public void Tiles()
        {

        }
        public void Lines()
        {

        }
    }


}


