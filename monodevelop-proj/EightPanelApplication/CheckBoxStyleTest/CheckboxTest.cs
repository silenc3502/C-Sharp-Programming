using System;
using System.Windows.Forms;

namespace EightPanelApplication.CheckBoxStyleTest
{
    public class CheckboxTest : Form
    {
        private Label label;
        private CheckBox dropBoost, expBoost;
        private FlowLayoutPanel flowLayoutPanel;

        public CheckboxTest()
        {
            this.Text = "Checkbox Test";
            this.Width = 250;
            this.Height = 200;

            label = new Label();
            label.Text = "Checkbox";
            label.Dock = DockStyle.Top;

            dropBoost = new CheckBox();
            expBoost = new CheckBox();

            dropBoost.Text = "drop rate up";
            expBoost.Text = "exp rate up";

            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Bottom;

            dropBoost.Parent = flowLayoutPanel;
            expBoost.Parent = flowLayoutPanel;

            label.Parent = this;
            flowLayoutPanel.Parent = this;

            dropBoost.CheckedChanged += new EventHandler(CheckBoxCheckedChanged);
            expBoost.CheckedChanged += new EventHandler(CheckBoxCheckedChanged);
        }

        public void CheckBoxCheckedChanged(object sender, EventArgs eventArgs)
        {
            CheckBox checkbox = (CheckBox)sender;

            if(checkbox.Checked == true)
            {
                label.Text = checkbox.Text + " selected";
            }
            else if (checkbox.Checked == false)
            {
                label.Text = checkbox.Text + " deselected";
            }
        }
    }
}
