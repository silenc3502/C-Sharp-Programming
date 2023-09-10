using System;
using System.Windows.Forms;
using EightPanelApplication.Layout;
using EightPanelApplication.FontStyleTest;
using EightPanelApplication.ButtonStyleTest;
using EightPanelApplication.CheckBoxStyleTest;
using EightPanelApplication.RadioButtonStyleTest;

namespace EightPanelApplication
{
    class MainClass : Form
    {
        private Button[] buttons = new Button[6];
        private FlowLayoutPanel flowLayoutPanel;

        public static void Main(string[] args)
        {
            // Application.Run(new MainClass());
            // Application.Run(new TablePanel());
            // Application.Run(new TablePanelWithLabel());
            // Application.Run(new FontTest());
            // Application.Run(new ButtonTest());
            // Application.Run(new CheckboxTest());
            Application.Run(new RadioButtonTest());
        }

        public MainClass()
        {
            this.Text = "Panel Sample";
            this.Width = 600;
            this.Height = 100;

            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = Convert.ToString(i);
                buttons[i].Parent = flowLayoutPanel;
            }

            flowLayoutPanel.Parent = this;
        }
    }
}
