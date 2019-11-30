using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Tasker
{
    class TaskPanel:Panel
    {
        private string caption;
        private string text;
        private int height;
        private int width;
        
        public TaskPanel(string caption,string text,int height,int width)
        {
            this.text = text;
            this.caption = caption;
            this.height = height;
            this.width = width;
            Label captionlabel = new Label();
            Label textlabel = new Label();
            textlabel.Top = 20;
            captionlabel.Text = caption;
            textlabel.Text = text;
            Controls.Add(captionlabel);
            Controls.Add(textlabel);
        }      

    }
}
