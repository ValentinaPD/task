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
                 
        Label captionlabel = new Label();
        Label textlabel = new Label();
        Label datalb = new Label();
        private Panel ButtonPanel=new Panel();
        private Button EditTask=new Button();
        private Button DeleteTask = new Button();
        public TaskPanel(string caption,string text)
        {
            this.Padding = new Padding(10, 2, 0, 2);
            this.Margin = new Padding(10,10,0,10);
            this.SizeChanged += new EventHandler(TaskPanel_SizeChanged);
            this.caption = caption;
            this.text = text;                       
            this.Dock = DockStyle.Top;
            this.AutoSize = false;

            
            textlabel.AllowDrop = true;
            textlabel.AutoSize = false;
            textlabel.Width = this.Width;
            
            textlabel.Height = this.Height / 3;
           
            
            
            datalb.AutoSize = true;
            captionlabel.AutoSize = true;
            captionlabel.Text = caption;
            captionlabel.TextAlign = ContentAlignment.TopCenter;
            captionlabel.AutoSize = false;
            captionlabel.Height = this.Height / 3;
            captionlabel.Width = this.Width;
            textlabel.Text = text;
            
            
            datalb.Text = DateTime.Now.ToString();
           
            datalb.Dock = DockStyle.Bottom;
            captionlabel.Dock = DockStyle.Top;
            textlabel.Dock = DockStyle.Top;
            textlabel.AutoEllipsis = true;
            this.BorderStyle = BorderStyle.FixedSingle;
            
            
            datalb.Padding = new System.Windows.Forms.Padding(-5);

            ButtonPanel.Dock = DockStyle.Right;
            ButtonPanel.Width = this.Width / 10;
            ButtonPanel.Height = this.Height;
            //ButtonPanel.BackColor = Color.Red;

            EditTask.FlatStyle = FlatStyle.Popup;
            EditTask.Dock = DockStyle.Top;
            EditTask.Text = "Edit..";
            EditTask.Height = ButtonPanel.Height / 2;
            EditTask.Width = ButtonPanel.Width;

            DeleteTask.FlatStyle = FlatStyle.Popup;
            DeleteTask.Text = "Delete..";
            DeleteTask.Dock = DockStyle.Bottom;
            DeleteTask.Height = ButtonPanel.Height / 2;
            DeleteTask.Width = ButtonPanel.Width;

            this.Controls.Add(textlabel);
            this.Controls.Add(captionlabel);
            this.Controls.Add(datalb);
            ButtonPanel.Controls.Add(EditTask);
            ButtonPanel.Controls.Add(DeleteTask);
            this.Controls.Add(ButtonPanel);

           
        }
        
        void TaskPanel_SizeChanged(object sender, EventArgs e)
        {
            if(((((this.Width / 3) + this.Height)) / 30 )> 10 && ((((this.Width / 3) + this.Height)) / 30)<16)
                captionlabel.Font = new System.Drawing.Font("Times New Roman", (((this.Width / 2) + this.Height/4)) / 30,FontStyle.Bold);
            if (((((this.Width / 2) + this.Height / 4)) / 35)>8 && ((((this.Width / 2) + this.Height / 4)) / 35) < 14)
                textlabel.Font = new System.Drawing.Font("Times New Roman", (((this.Width / 2) + this.Height / 4)) / 35);
            if (((((this.Width / 2) + this.Height / 4)) / 45) > 6 && ((((this.Width / 2) + this.Height / 4)) / 45) < 12)
                datalb.Font = new System.Drawing.Font("Times New Roman", (((this.Width / 2) + this.Height / 4)) / 45);
            if (((((this.Width / 2) + this.Height / 4)) / 35) > 8 && ((((this.Width / 2) + this.Height / 4)) / 35) < 14)
                ButtonPanel.Font = new System.Drawing.Font("Times New Roman", (((this.Width / 2) + this.Height / 4)) / 35);
            if (ButtonPanel.Width>320)
            ButtonPanel.Width = this.Width / 10;
            else ButtonPanel.Width = this.Width / 5;
            
           
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
