using System;
using System.Windows.Forms;
using System.Drawing;

namespace EightPanelApplication.FontStyleTest
{
    public class FontTest : Form
    {
        private Label[] labels = new Label[3];
        private TableLayoutPanel tableLayoutPanel;

        public FontTest()
        {
            this.Text = "Font Settings";
            this.Width = 250;
            this.Height = 200;

            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 3;

            Font[] fonts =
            {
                new Font("Arial", 12, FontStyle.Bold),
                new Font("Times New Roman", 14, FontStyle.Bold),
                new Font("Courier New", 16, FontStyle.Bold),
            };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = "Font Test";
                labels[i].Width = 200;
                labels[i].Font = fonts[i];

                labels[i].Parent = tableLayoutPanel;
            }

            tableLayoutPanel.Parent = this;
        }
    }
}
