using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasker
{
    class NewTask:Form{
        private RichTextBox textbox = new RichTextBox();
        private TextBox captionTextbox = new TextBox();
        private Button ButtonOk = new Button();
        private Button ButtonCansel = new Button();
        private Panel CaptionPanel = new Panel();
        private Panel TextPanel = new Panel();
        private Label CaptionLabel = new Label();
        private Panel FooterPanel = new Panel();
        public NewTask()
    {
            Instalize();
    }
        private void Instalize()
        {
            CaptionPanel.Dock = DockStyle.Top;
            CaptionPanel.Height = this.Height / 5 ;
            CaptionLabel.Text = "Заголовок";
            captionTextbox.Anchor = AnchorStyles.Left;
            CaptionLabel.Dock = DockStyle.Left;
            captionTextbox.Dock = DockStyle.Right;
            CaptionPanel.Controls.Add(CaptionLabel);
            CaptionPanel.Controls.Add(captionTextbox);
            TextPanel.Dock = DockStyle.Fill;
            textbox.Dock = DockStyle.Fill;
            TextPanel.Controls.Add(textbox);
            this.Controls.Add(CaptionPanel);
            this.Controls.Add(TextPanel);
            
            FooterPanel.AutoSize =false;
            FooterPanel.Height = this.Height / 10;
            ButtonCansel.Dock = DockStyle.Right;
            ButtonOk.Dock = DockStyle.Left;            
            FooterPanel.Controls.Add(ButtonOk);
            FooterPanel.Controls.Add(ButtonCansel);
            FooterPanel.Dock = DockStyle.Bottom;
            Controls.Add(FooterPanel);
        }
}
}
