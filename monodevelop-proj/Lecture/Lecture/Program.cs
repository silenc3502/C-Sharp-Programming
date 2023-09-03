using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Reflection;
using System;

using Lecture.domain.car;

namespace Lecture
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("프로젝트 최상위 위치: " + projectRoot);

            string imagePath = Path.Combine(projectRoot, "../../Resources", "cpu.bmp");
            Console.WriteLine("이미지 위치: " + imagePath);

            Form form;
            form = new Form();
            form.Text = "이거시 C# 비다";

            PictureBox pictureBox = new PictureBox();

            Car car = new Car(imagePath);
            car.Move();
            car.Move();

            pictureBox.Image = car.getImage();
            pictureBox.Size = new Size(64, 64);
            pictureBox.Top = car.getTop;
            pictureBox.Left = car.getLeft;
            pictureBox.Parent = form;

            Application.Run(form);
        }
    }
}
