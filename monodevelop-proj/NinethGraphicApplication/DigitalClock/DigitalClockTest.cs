using System;
using System.Windows.Forms;
using System.Drawing;

namespace NinethGraphicApplication.DigitalClock
{
    public class DigitalClockTest : Form
    {
        private Label label;

        public DigitalClockTest()
        {
            this.Text = "Digial Clock Test";
            this.Width = 250;
            this.Height = 100;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Start();

            label = new Label();
            label.Font = new Font("Courier", 20, FontStyle.Regular);
            label.Dock = DockStyle.Fill;

            label.Parent = this;

            timer.Tick += new EventHandler(TimerTickHandler);
        }

        public void TimerTickHandler(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            label.Text = dateTime.ToLongTimeString();
        }

    }
}
