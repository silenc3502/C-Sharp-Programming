using System;
using System.Windows.Forms;

namespace SeventhEventApplication
{
    class MainClass : Form
    {
        private Label label;
        private Button button;
        private Label label2;

        public static void Main(string[] args)
        {
            Application.Run(new MainClass());
        }

        public MainClass()
        {
            this.Text = "Event Sample";
            this.Width = 250;
            this.Height = 250;

            label = new Label();
            label.Text = "Event!";

            button = new Button();
            button.Text = "Click";
            button.Top = this.Top + label.Height;
            button.Width = label.Width;

            label2 = new Label();
            label2.Top = label.Bottom;
            label2.Text = "Current";

            button.Top = label2.Bottom;
            button.Parent = this;
            label.Parent = this;
            label2.Parent = this;

            this.KeyPreview = true;
            this.Click += new EventHandler(FormClick);
            button.Click += new EventHandler(ButtonClick);

            this.MouseEnter += new EventHandler(FormMouseEnter);
            this.MouseLeave += new EventHandler(FormMouseLeave);

            this.KeyDown += new KeyEventHandler(FormKeyDown);
        }

        public void FormClick(Object sender, EventArgs eventArgs)
        {
            label.Text = "Hello";
        }
        public void ButtonClick(Object sender, EventArgs eventArgs)
        {
            label.Text = "Clicked button";
        }
        public void FormMouseEnter(Object sender, EventArgs eventArgs)
        {
            label.Text = "Mouse Entered";
        }
        public void FormMouseLeave(Object sender, EventArgs eventArgs)
        {
            label.Text = "Mouse Leave";
        }
        public void FormKeyDown(Object sender, KeyEventArgs eventArgs)
        {
            
            String str;
            Console.Write("FormKeyDown()");

            if (eventArgs.KeyCode == Keys.A)
            {
                str = "a";
            }
            else if (eventArgs.KeyCode == Keys.B)
            {
                str = "b";
            }
            else if (eventArgs.KeyCode == Keys.C)
            {
                str = "c";
            }
            else if (eventArgs.KeyCode == Keys.D)
            {
                str = "d";
            }
            else
            {
                str = "other key";
            }
            label2.Text = str;
        }
    }
}