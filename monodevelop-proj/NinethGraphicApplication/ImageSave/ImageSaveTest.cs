using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace NinethGraphicApplication.ImageSave
{
    public class ImageSaveTest : Form
    {
        private Bitmap originalBitmap, convertedBitmap;
        private int i;

        public ImageSaveTest()
        {
            this.Text = "Image Save Test";
            this.Width = 400;
            this.Height = 300;

            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Project Top: " + projectRoot);

            string imagePath = Path.Combine(projectRoot, "../../Resources", "sword.jpg");

            originalBitmap = new Bitmap(imagePath);
            convertedBitmap = new Bitmap(imagePath);

            i = 0;

            this.Click += new EventHandler(FlipClickHandler);
            this.Paint += new PaintEventHandler(FlipPaintHandler);
        }

        public void convert ()
        {
            for (int x = 0; x < originalBitmap.Width; x++)
            {
                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    Color color = originalBitmap.GetPixel(x, y);
                    int rgb = color.ToArgb();

                    int a = (rgb >> 24) & 0xFF;
                    int r = (rgb >> 16) & 0xFF;
                    int g = (rgb >> 8) & 0xFF;
                    int b = (rgb >> 0) & 0xFF;

                    switch (i)
                    {
                        case 1:
                            r >>= 2;
                            break;
                        case 2:
                            g >>= 2;
                            break;
                        case 3:
                            b >>= 2;
                            break;
                    }

                    rgb = (a << 24) | (r << 16) | (g << 8) | (b << 0);
                    color = Color.FromArgb(rgb);

                    convertedBitmap.SetPixel(x, y, color);
                }
            }
        }

        public void FlipPaintHandler(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(convertedBitmap, 0, 0, 400, 300);
        }


        public void FlipClickHandler(object sender, EventArgs e)
        {
            i++;
            if (i >= 4) { i = 0; }

            convert();
            this.Invalidate();
        }

    }
}
