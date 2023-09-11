using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace NinethGraphicApplication.RandomPrint
{
    class Ball
    {
        public Color color;
        public Point point;
    }

    public class RandomPrintTest : Form
    {
        private List<Ball> ballList;

        public RandomPrintTest()
        {
            this.Text = "Random Print Test";
            this.Paint += new PaintEventHandler(FlipPaintHandler);

            ballList = new List<Ball>();
            Random random = new Random();

            for (int i = 0; i < 30; i++)
            {
                Ball ball = new Ball();

                int x = random.Next(this.Width);
                int y = random.Next(this.Height);

                int r = random.Next(256);
                int g = random.Next(256);
                int b = random.Next(256);

                Point point = new Point(x, y);
                Color color = Color.FromArgb(r, g, b);

                ball.point = point;
                ball.color = color;

                ballList.Add(ball);
            }
        }

        public void FlipPaintHandler(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            foreach (Ball ball in ballList)
            {
                Point point = ball.point;
                Color color = ball.color;
                SolidBrush solidBrush = new SolidBrush(color);

                graphics.FillEllipse(solidBrush, point.X, point.Y, 10, 10);
            }
        }

    }
}
