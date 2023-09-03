using System.Drawing;
using System;

namespace C_Sharp_Programming
{
    class Car
    {
        public Image image;
        public int top;
        public int left;

        public Car(string imagePath)
        {
            try
            {
                image = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("이미지를 불러올 수 없습니다: " + ex.ToString());
            }
            top = 0;
            left = 0;
        }

        public void Move()
        {
            top = top + 10;
            left = left + 10;
        }
    }
}