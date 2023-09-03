using System.Windows.Forms;
using System.Drawing;
using System;

namespace C_Sharp_Programming
{
    class ThirdArrayApplication
    {
        public static void Main(string[] args)
        {
            Form form;
            form = new Form();
            form.Text = "이거시 C# 비다";

            Label label = new Label();
            label.Width = 150;
            label.Text = "C# 레이블인데 짤리냐 ?";
            label.Parent = form;

            PictureBox[] pictureBoxArray = new PictureBox[5];

            for (int i = 0; i < pictureBoxArray.Length; i++)
            {
                pictureBoxArray[i] = new PictureBox();
                try
                {
                    pictureBoxArray[i].Image = Image.FromFile("cpu.bmp");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"이미지를 로드하는 동안 오류가 발생했습니다: {ex.Message}");
                }
                
                pictureBoxArray[i].Size = new Size(64, 64);
                pictureBoxArray[i].Top = 32 + (i % 3) * pictureBoxArray[i].Height;
                pictureBoxArray[i].Left = (i / 3) * pictureBoxArray[i].Height;
                pictureBoxArray[i].Parent = form;
            }

            Application.Run(form);
        }
    }
}