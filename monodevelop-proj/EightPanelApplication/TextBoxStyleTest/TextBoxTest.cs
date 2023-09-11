using System;
using System.Windows.Forms;

namespace EightPanelApplication.TextBoxStyleTest
{
    public class TextBoxTest : Form
    {
        private Label label;
        private TextBox textBox;

        public TextBoxTest()
        {
            this.Text = "TextBox Test";
            this.Width = 250;
            this.Height = 200;

            label = new Label();
            label.Text = "Welcome!";
            label.Dock = DockStyle.Top;

            textBox = new TextBox();
            textBox.Dock = DockStyle.Bottom;

            label.Parent = this;
            textBox.Parent = this;

            textBox.KeyDown += new KeyEventHandler(TextBoxKeyDownHandler);
        }

        void TextBoxKeyDownHandler(object sender, KeyEventArgs keyEventArgs)
        {
            TextBox textBoxObject = (TextBox)sender;

            if (keyEventArgs.KeyCode == Keys.Enter)
            {
                label.Text = textBoxObject.Text + " selected!";
            }
        }

    }
}
