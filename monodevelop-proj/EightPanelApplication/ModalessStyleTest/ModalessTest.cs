using System;
using System.Windows.Forms;

namespace EightPanelApplication.ModalessStyleTest
{
    public class ModalessTest : Form
    {
        private Label label;
        private Button button;

        public ModalessTest()
        {
            this.Text = "Modaless Test";
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

            button.Click += new EventHandler(ButtonClickHandler);
        }

        public void ButtonClickHandler(object sender, EventArgs eventArgs)
        {
            NewModalessForm modalessForm = new NewModalessForm();
            modalessForm.Show();
        }

    }
}
