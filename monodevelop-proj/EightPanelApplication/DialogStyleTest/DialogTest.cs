using System;
using System.Windows.Forms;

namespace EightPanelApplication.DialogStyleTest
{
    public class DialogTest : Form
    {
        private Label label;
        private Button button;

        public DialogTest()
        {
            this.Text = "Dialog Test";
            this.Width = 250;
            this.Height = 200;

            label = new Label();
            label.Text = "Welcome";
            label.Dock = DockStyle.Top;

            button = new Button();
            button.Text = "Buy";
            button.Dock = DockStyle.Bottom;

            label.Parent = this;
            button.Parent = this;

            button.Click += new EventHandler(ButtonClickHandler2);
        }

        public void ButtonClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for buying", "Buy");
        }

        public void ButtonClickHandler2(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want buy it ?", "OK",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Thanks for buying", "Buy",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
