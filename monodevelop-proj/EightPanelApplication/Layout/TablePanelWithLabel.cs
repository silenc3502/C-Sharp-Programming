using System;
using System.Windows.Forms;
using System.Drawing;

namespace EightPanelApplication.Layout
{
    public class TablePanelWithLabel : Form
    {
        private Label[] labels = new Label[3];
        private TableLayoutPanel tableLayoutPanel;

        public TablePanelWithLabel()
        {
            this.Text = "TableLayout with Label";
            this.Width = 250;
            this.Height = 300;

            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 3;

            Color foreColors = Color.Black;
            Color[] backColors = { Color.White, Color.Gray, Color.White };
            ContentAlignment[] textAligns = { ContentAlignment.TopLeft, ContentAlignment.MiddleCenter, ContentAlignment.BottomRight };
            BorderStyle[] borderStyles = { BorderStyle.None, BorderStyle.FixedSingle, BorderStyle.Fixed3D };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = "No." + i;
                labels[i].ForeColor = foreColors;
                labels[i].BackColor = backColors[i];
                labels[i].TextAlign = textAligns[i];
                labels[i].BorderStyle = borderStyles[i];
            }

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Parent = tableLayoutPanel;
            }

            tableLayoutPanel.Parent = this;
        }
    }
}
