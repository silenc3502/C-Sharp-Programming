using System;
using System.Windows.Forms;

namespace EightPanelApplication.ButtonStyleTest
{
    public class ButtonTest : Form
    {
        private Label label;
        private Button button;

        public ButtonTest()
        {
            this.Text = "Button Test";
            this.Width = 250;
            this.Height = 100;

            label = new Label();
            label.Text = "Gogosing";
            label.Dock = DockStyle.Top;

            button = new Button();
            button.Text = "Buy";
            button.Dock = DockStyle.Bottom;

            button.Click += new EventHandler(ButtonClickHandler);

            label.Parent = this;
            button.Parent = this;
        }

        public void ButtonClickHandler(Object sender, EventArgs eventArgs)
        {
            label.Text = "Thanks for buying";
            button.Enabled = false;
        }
    }
}
