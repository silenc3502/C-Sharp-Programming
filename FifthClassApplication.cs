using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Reflection;
using System;

namespace C_Sharp_Programming
{
    class FifthClassApplication
    {
        public static void Main(string[] args)
        {
            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("프로젝트 최상위 위치: " + projectRoot);

            string imagePath = Path.Combine(projectRoot, "Resources", "cpu.bmp");
            Console.WriteLine("이미지 위치: " + imagePath);

            Form form;
            form = new Form();
            form.Text = "이거시 C# 비다";

            PictureBox pictureBox = new PictureBox();

            Car car = new Car(imagePath);
            car.Move();
            car.Move();

            pictureBox.Image = car.image;
            pictureBox.Top = car.top;
            pictureBox.Left = car.left;
            pictureBox.Parent = form;

            Application.Run(form);
        }
    }
}