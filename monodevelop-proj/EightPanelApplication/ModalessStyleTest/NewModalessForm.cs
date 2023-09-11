using System;
using System.Windows.Forms;

namespace EightPanelApplication.ModalessStyleTest
{
    public class NewModalessForm : Form
    {
        private Label label = new Label();
        private Button button = new Button();

        public NewModalessForm()
        {
            this.Text = "New Modal";
            this.Width = 250;
            this.Height = 200;

            label.Text = "Start New";
            label.Dock = DockStyle.Top;

            button.Text = "OK";
            button.Dock = DockStyle.Bottom;

            label.Parent = this;
            button.Parent = this;

            button.Click += new EventHandler(ButtonClickHandler);
        }

        public void ButtonClickHandler(object sender, EventArgs eventArgs)
        {
            this.Close();
        }

    }
}
