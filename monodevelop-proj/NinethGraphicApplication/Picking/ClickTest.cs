using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace NinethGraphicApplication.Picking
{
    public class ClickTest : Form
    {
        private List<Point> pointList;

        public ClickTest()
        {
            this.Text = "Click Test";

            pointList = new List<Point>();

            this.MouseDown += new MouseEventHandler(FlipMouseDownHandler);
            this.Paint += new PaintEventHandler(FlipPaintHandler);
        }

        public void FlipPaintHandler(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen dp = new Pen(Color.Black, 1);

            foreach(Point p in pointList)
            {
                graphics.DrawEllipse(dp, p.X, p.Y, 10, 10);
            }
        }


        public void FlipMouseDownHandler(object sender, MouseEventArgs e)
        {
            Point point = new Point();

            point.X = e.X;
            point.Y = e.Y;
            pointList.Add(point);

            this.Invalidate();
        }

    }
}
