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
                 
        void TaskPanel_SizeChanged(object sender, EventArgs e)
        {
            captionlabel.Font = new System.Drawing.Font("Times New Roman", (((this.Width/2)+this.Height)) / 24);
            textlabel.Font = new System.Drawing.Font("Times New Roman", (((this.Width / 2) + this.Height)) / 32);
            datalb.Font = new System.Drawing.Font("Times New Roman", (((this.Width / 2) + this.Height)) / 40);
        }
        Label captionlabel = new Label();
        Label textlabel = new Label();
        Label datalb = new Label();

        public TaskPanel(string caption,string text)
        {
            this.SizeChanged += new EventHandler(TaskPanel_SizeChanged);
            this.caption = caption;
            this.text = text;                       
            this.Dock = DockStyle.Top;
           

            
            textlabel.AllowDrop = true;
            textlabel.AutoSize = false;
            textlabel.Width = this.Width;
            
            textlabel.Height = this.Height / 2;
            //textlabel.BackColor = Color.Red;
            
            datalb.AutoSize = true;
            captionlabel.AutoSize = true;
            captionlabel.Text = caption;
            textlabel.Text = text;
            datalb.Text = DateTime.Now.ToString();
           
            datalb.Dock = DockStyle.Bottom;
            captionlabel.Dock = DockStyle.Top;
            textlabel.Dock = DockStyle.Top;
            
            datalb.Padding = new System.Windows.Forms.Padding(-5);

            
            this.Controls.Add(textlabel);
            this.Controls.Add(captionlabel);
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
