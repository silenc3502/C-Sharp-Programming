using System;
using System.Windows.Forms;

namespace EightPanelApplication.ListBoxStyleTest
{
    public class ListBoxTest : Form
    {
        private Label label;
        private ListBox listBox;

        public ListBoxTest()
        {
            string[] str =
            {
                "car", "airplane", "truck",
                "taxi", "sports car", "rocket",
                "bike", "hellicopter", "missile"
            };

            this.Text = "ListBox Test";
            this.Width = 250;
            this.Height = 200;

            label = new Label();
            label.Text = "Welcome";
            label.Dock = DockStyle.Top;

            listBox = new ListBox();

            for (int i = 0; i < str.Length; i++)
            {
                listBox.Items.Add(str[i]);
            }
            listBox.Top = label.Bottom;

            label.Parent = this;
            listBox.Parent = this;

            listBox.SelectedIndexChanged += new EventHandler(ListBoxSelectedIndexChangedHandler);
        }

        void ListBoxSelectedIndexChangedHandler(object sender, EventArgs eventArgs)
        {
            ListBox listBoxObject = (ListBox)sender;

            label.Text = listBoxObject.Text + " selected!";
        }

    }
}
