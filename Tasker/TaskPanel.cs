using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Tasker
{

    partial class TaskPanel : Panel
    {
        private string caption;
        private string text;
       // public event EventHandler SizeChanged;
            
        void TaskPanel_SizeChanged(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font("Times New Roman", (this.Width) / 16);
            //this.Height = this.Height + 10;
        }

        public TaskPanel(string caption,string text)
        {
            this.SizeChanged += new EventHandler(TaskPanel_SizeChanged);
            this.text = text;
            this.caption = caption;           
            this.Dock = DockStyle.Top;
            
            Label captionlabel = new Label();
            Label textlabel = new Label();
            Label datalb = new Label();
            
            captionlabel.Text = caption;
            textlabel.Text = text;
            datalb.Text = DateTime.Now.ToString();
            textlabel.Top = 20;
            datalb.Top= 70;
            

            
            this.Controls.Add(captionlabel);
            this.Controls.Add(textlabel);
            this.Controls.Add(datalb);
        }      

    }
}
/*
     struct PanelStyle
{
    Color PanelColor;
    public void F(TaskPanel tp, Color color)
    {
        tp.BackColor = color;
    }
}

    
        public void MyNewStyle()
        {
            this.BackColor = Color.Red;
        }
*/
