using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace NinethGraphicApplication.BasicRotation
{
    public class RotationTest : Form
    {
        private Image image;

        public RotationTest()
        {
            this.Text = "Image Rotation Test";
            this.Width = 250;
            this.Height = 200;

            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Project Top: " + projectRoot);

            string imagePath = Path.Combine(projectRoot, "../../Resources", "cpu.bmp");

            image = Image.FromFile(imagePath);

            this.Click += new EventHandler(FlipClickHandler);
            this.Paint += new PaintEventHandler(FlipPaintHandler);
        }

        public void FlipPaintHandler(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(image, 0, 0);
        }


        public void FlipClickHandler(object sender, EventArgs e)
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.Invalidate();
        }

    }
}
