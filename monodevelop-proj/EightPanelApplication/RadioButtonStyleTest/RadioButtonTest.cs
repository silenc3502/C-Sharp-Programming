using System;
using System.Windows.Forms;

namespace EightPanelApplication.RadioButtonStyleTest
{
    public class RadioButtonTest : Form
    {
        private Label label;
        private RadioButton warriorButton, wizardButton;
        private GroupBox jobGroupBox;

        public RadioButtonTest()
        {
            this.Text = "RadioButton Test";
            this.Width = 300;
            this.Height = 200;

            label = new Label();
            label.Text = "Welcome!";
            label.Dock = DockStyle.Top;

            warriorButton = new RadioButton();
            wizardButton = new RadioButton();

            warriorButton.Text = "Warrior";
            wizardButton.Text = "Wizard";
            warriorButton.Checked = true;

            warriorButton.Dock = DockStyle.Left;
            wizardButton.Dock = DockStyle.Right;

            jobGroupBox = new GroupBox();
            jobGroupBox.Text = "Job";
            jobGroupBox.Dock = DockStyle.Bottom;

            warriorButton.Parent = jobGroupBox;
            wizardButton.Parent = jobGroupBox;

            label.Parent = this;
            jobGroupBox.Parent = this;

            warriorButton.Click += new EventHandler(RadioButtonClick);
            wizardButton.Click += new EventHandler(RadioButtonClick);
        }

        public void RadioButtonClick(Object sender, EventArgs eventArgs)
        {
            RadioButton radioButton = (RadioButton)sender;
            label.Text = radioButton.Text + " selected";
        }
    }
}
