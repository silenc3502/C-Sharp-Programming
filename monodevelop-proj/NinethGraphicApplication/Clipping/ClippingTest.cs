using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NinethGraphicApplication.Clipping
{
    public class ClippingTest : Form
    {
        private Image image;

        public ClippingTest()
        {
            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Project Top: " + projectRoot);

            string imagePath = Path.Combine(projectRoot, "../../Resources", "sword.jpg");

            image = Image.FromFile(imagePath);

            this.Text = "Clipping Test";
            this.ClientSize = new Size(400, 300);
            this.BackColor = Color.Black;

            this.Paint += new PaintEventHandler(FlipPaintHandler);
        }

        public void FlipPaintHandler(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddEllipse(new Rectangle(0, 0, 400, 300));
            Region region = new Region(graphicsPath);
            graphics.Clip = region;

            graphics.DrawImage(image, 0, 0, 400, 300);
        }

    }
}
