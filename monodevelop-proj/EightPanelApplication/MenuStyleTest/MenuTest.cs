using System;
using System.Windows.Forms;

namespace EightPanelApplication.MenuStyleTest
{
    public class MenuTest : Form
    {
        private Label label;
        private MenuStrip menuStrip;
        private ToolStripMenuItem[] menuItems = new ToolStripMenuItem[10];

        public MenuTest()
        {
            const int MAX = 10;
            this.Text = "Menu Test";
            this.Width = 250;
            this.Height = 200;

            label = new Label();
            label.Text = "Welcome";
            label.Dock = DockStyle.Bottom;

            string[] toolStripMenuArr =
            {
                "car", "airplane", "truck",
                "taxi", "sports car", "rocket",
                "bike", "hellicopter", "missile", "One more"
            };

            menuStrip = new MenuStrip();
            for (int i = 0; i < MAX; i++)
            {
                menuItems[i] = new ToolStripMenuItem(toolStripMenuArr[i]);
            }

            menuItems[0].DropDownItems.Add(menuItems[4]);
            menuItems[0].DropDownItems.Add(menuItems[5]);

            menuItems[1].DropDownItems.Add(menuItems[2]);
            menuItems[1].DropDownItems.Add(new ToolStripSeparator());
            menuItems[1].DropDownItems.Add(menuItems[3]);
            menuItems[2].DropDownItems.Add(menuItems[6]);
            menuItems[2].DropDownItems.Add(menuItems[7]);
            menuItems[3].DropDownItems.Add(menuItems[8]);
            menuItems[3].DropDownItems.Add(menuItems[9]);

            menuStrip.Items.Add(menuItems[0]);
            menuStrip.Items.Add(menuItems[1]);

            this.MainMenuStrip = menuStrip;

            menuStrip.Parent = this;
            label.Parent = this;

            for (int i = 4; i < menuItems.Length; i++)
            {
                menuItems[i].Click += new EventHandler(MenuItemClickHandler);
            }
        }

        public void MenuItemClickHandler(Object sender, EventArgs eventArgs)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            label.Text = menuItem.Text + " selected!";
        }
    }
}
