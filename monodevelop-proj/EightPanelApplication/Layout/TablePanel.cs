using System;
using System.Windows.Forms;

namespace EightPanelApplication.Layout
{
    public class TablePanel : Form
    {
        private Button[] buttons = new Button[6];
        private TableLayoutPanel tableLayoutPanel;

        public TablePanel()
        {
            this.Text = "Table Sample";
            this.Width = 300;
            this.Height = 200;

            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 2;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = Convert.ToString(i);
                buttons[i].Parent = tableLayoutPanel;
            }

            tableLayoutPanel.Parent = this;
        }
    }
}
