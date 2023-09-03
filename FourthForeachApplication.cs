using System.Windows.Forms;
using System.Drawing;
using System;

namespace C_Sharp_Programming
{
    class FourthForeachApplication
    {
        public static void Main(string[] args)
        {
            Form form;
            form = new Form();
            form.Text = "이거시 C# 비다";

            Label label = new Label();
            label.Width = form.Width;
            label.Height = form.Height;
            

            string[] programmingLanguage = new string[3]{"C", "C++", "C#"};

            foreach (string element in programmingLanguage)
            {
                label.Text += element + "\n";
            }

            label.Parent = form;
            Application.Run(form);
        }
    }
}