using System;
using System.Windows.Forms;

namespace EightPanelApplication.NewModal
{
    public class NewModalForm : Form
    {
        Label label = new Label();
        Button button = new Button();

        public NewModalForm()
        {
            this.Text = "New Modal";
            this.Width = 250;
            this.Height = 200;

            label.Text = "Thanks";
            label.Dock = DockStyle.Top;

            button.Text = "OK";
            button.DialogResult = DialogResult.OK;
            button.Dock = DockStyle.Bottom;

            label.Parent = this;
            button.Parent = this;
        }
    }
}
