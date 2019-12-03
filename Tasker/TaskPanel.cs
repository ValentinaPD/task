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
        //void TaskPanel_mousemove(object sender, EventArgs e)
        //{
        //    this.BackColor = Color.Orange;
        //}
     
        public TaskPanel(string caption,string text)
        {
           // this.MouseHover += new EventHandler(TaskPanel_mousemove);
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
