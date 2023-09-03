using System.Windows.Forms;
using System.Drawing;


namespace C_Sharp_Programming
{
    class SecondApplicationForm
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

            PictureBox picture = new PictureBox();
            try
            {
                picture.Image = Image.FromFile("cpu.bmp");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"이미지를 로드하는 동안 오류가 발생했습니다: {ex.Message}");
            }
            
            picture.Size = new Size(64, 64);
            // picture.Location = new Point(32, 32);

            picture.Top = (form.ClientSize.Height - picture.Height) / 2;
            picture.Left = (form.ClientSize.Width - picture.Width) / 2;

            picture.Parent = form;

            Application.Run(form);
        }
    }
}