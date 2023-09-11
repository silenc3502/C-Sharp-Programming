using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace NinethGraphicApplication.BasicResize
{
    public class ResizeTest : Form
    {
        private Image image;
        private RadioButton smallButton, basicButton, bigButton;
        private GroupBox groupBox;
        private int i;

        public ResizeTest()
        {
            this.Text = "Resize Test";
            this.Width = 300;
            this.Height = 300;

            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Project Top: " + projectRoot);

            string imagePath = Path.Combine(projectRoot, "../../Resources", "cpu.bmp");

            image = Image.FromFile(imagePath);

            smallButton = new RadioButton();
            basicButton = new RadioButton();
            bigButton = new RadioButton();

            smallButton.Text = "small";
            basicButton.Text = "basic";
            bigButton.Text = "big";

            smallButton.Dock = DockStyle.Bottom;
            basicButton.Dock = DockStyle.Bottom;
            bigButton.Dock = DockStyle.Bottom;

            basicButton.Checked = true;

            groupBox = new GroupBox();
            groupBox.Text = "Kinds";
            groupBox.Dock = DockStyle.Bottom;

            smallButton.Parent = groupBox;
            basicButton.Parent = groupBox;
            bigButton.Parent = groupBox;
            groupBox.Parent = this;

            smallButton.Click += new EventHandler(RadioButtonClickHandler);
            basicButton.Click += new EventHandler(RadioButtonClickHandler);
            bigButton.Click += new EventHandler(RadioButtonClickHandler);
            this.Paint += new PaintEventHandler(FlipPaintHandler);
        }

        public void FlipPaintHandler(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (i == 1)
            {
                graphics.DrawImage(image, 0, 0, image.Width / 2, image.Height / 2);
            }
            else if (i == 2)
            {
                graphics.DrawImage(image, 0, 0);
            }
            else if (i == 3)
            {
                graphics.DrawImage(image, 0, 0, image.Width * 2, image.Height * 2);
            }
        }


        public void RadioButtonClickHandler(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton == smallButton)
            {
                i = 1;
            }
            else if (radioButton == basicButton)
            {
                i = 2;
            }
            else if (radioButton == bigButton)
            {
                i = 3;
            }

            this.Invalidate();
        }

    }
}
