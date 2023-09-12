using System;
using System.Windows.Forms;
using System.Drawing;

namespace NinethGraphicApplication.TimerForm
{
    class Ball
    {
        public Color color;
        public Point point;
    }

    public class TimerTest : Form
    {
        private Ball ball;
        private int dx, dy;

        public TimerTest()
        {
            this.Text = "Timer Test";
            this.ClientSize = new Size(250, 100);

            ball = new Ball();

            Point point = new Point(0, 0);
            Color color = Color.Blue;

            ball.point = point;
            ball.color = color;

            dx = 2;
            dy = 2;

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Start();

            this.Paint += new PaintEventHandler(FlipPaintHandler);
            timer.Tick += new EventHandler(TimerTickHandler);
        }

        public void TimerTickHandler(object sender, EventArgs e)
        {
            Point point = ball.point;

            if (point.X < 0 || point.X > this.ClientSize.Width - 10) dx = -dx;
            if (point.Y < 0 || point.Y > this.ClientSize.Height - 10) dy = -dy;

            point.X = point.X + dx;
            point.Y = point.Y + dy;

            ball.point = point;
            this.Invalidate();
        }


        public void FlipPaintHandler(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Point point = ball.point;
            Color color = ball.color;
            SolidBrush solidBrush = new SolidBrush(color);

            graphics.FillEllipse(solidBrush, point.X, point.Y, 10, 10);
        }

    }
}
