using System.Drawing;
using System;

namespace Lecture.domain.car
{
    public class Car
    {
        private Image image;
        private int top;
        private int left;

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

        public Image getImage()
        {
            return image;
        }
        public int getTop
        {
            get
            {
                return top;
            }
        }

        public int getLeft
        {
            get
            {
                return left;
            }
        }
    }
}
