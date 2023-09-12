using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace NinethGraphicApplication.AnimationForm
{
    public class AnimationTest : Form
    {
        private Image image;
        private int i;

        public AnimationTest()
        {
            this.Text = "Animation Test";
            this.Width = 650;
            this.Height = 650;
            this.DoubleBuffered = true;

            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Project Top: " + projectRoot);

            string imagePath = Path.Combine(projectRoot, "../../Resources", "sword.jpg");
            image = Image.FromFile(imagePath);

            i = 0;

            Timer timer = new Timer();
            timer.Start();

            timer.Tick += new EventHandler(TimerTickHandler);
            this.Paint += new PaintEventHandler(FlipPaintHandler);
        }

        public void FlipPaintHandler(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(image, new Rectangle(0, 0, i, image.Height), 0, 0, i, image.Height, GraphicsUnit.Pixel);
        }


        public void TimerTickHandler(object sender, EventArgs e)
        {
            if (i > image.Width + 200)
            {
                i = 0;
            }
            else
            {
                i = i + 10;
            }

            this.Invalidate();
        }

    }
}
