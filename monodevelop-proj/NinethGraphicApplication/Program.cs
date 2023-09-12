using System;
using System.Windows.Forms;
using NinethGraphicApplication.BasicRotation;
using NinethGraphicApplication.BasicResize;
using NinethGraphicApplication.ImageSave;
using NinethGraphicApplication.Picking;
using NinethGraphicApplication.Clipping;
using NinethGraphicApplication.RandomPrint;
using NinethGraphicApplication.TimerForm;
using NinethGraphicApplication.AnimationForm;
using NinethGraphicApplication.DigitalClock;

namespace NinethGraphicApplication
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Application.Run(new RotationTest());
            // Application.Run(new ResizeTest());
            // Application.Run(new ImageSaveTest());
            // Application.Run(new ClickTest());
            // Application.Run(new ClippingTest());
            // Application.Run(new RandomPrintTest());
            // Application.Run(new TimerTest());
            // Application.Run(new AnimationTest());
            Application.Run(new DigitalClockTest());
        }
    }
}
