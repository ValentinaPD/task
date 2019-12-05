using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasker
{
    class NewTask:Form{
        private TextBox textbox = new TextBox();
        private TextBox captionTextbox = new TextBox();
        private Button ButtonOk = new Button();
        private Button ButtonCansel = new Button();
        public NewTask()
    {
            Instalize();
    }
        private void Instalize()
        {
            this.Controls.Add(captionTextbox);
            this.Controls.Add(textbox);
            this.Controls.Add(ButtonOk);
            this.Controls.Add(ButtonCansel);
        }
}
}
