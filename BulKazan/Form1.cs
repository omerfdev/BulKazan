using Microsoft.VisualBasic.ApplicationServices;

namespace BulKazan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int UserCount = 0;
        int ComputerCount = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonRabbitProcess();
            btnOne.Click += Click;
            btnTwo.Click += Click;
            btnThree.Click += Click;
        }

        private void ButtonRabbitProcess()
        {

            Random rnd = new Random();
            int x = rnd.Next(255);
            btnOne.BackColor = Color.FromArgb(0, 0, x);
            btnTwo.BackColor = Color.FromArgb(0, x, 0);
            btnThree.BackColor = Color.FromArgb(x, 0, 0);
            int y = rnd.Next(0, 2);
            if (y == 0)
            {
                btnOne.Tag = @"C:\Users\omerf\source\repos\BulKazan\BulKazan\Image\rabbitRed.png";
                btnTwo.Tag = @"C:\Users\omerf\source\repos\BulKazan\BulKazan\Image\rabbit.png";
                btnThree.Tag = @"C:\Users\omerf\source\repos\BulKazan\BulKazan\Image\rabbit.png";
            }
            else if (y == 1)
            {
                btnOne.Tag = @"C:\Users\omerf\source\repos\BulKazan\BulKazan\Image\rabbit.png";
                btnTwo.Tag = @"C:\Users\omerf\source\repos\BulKazan\BulKazan\Image\rabbitRed.png";
                btnThree.Tag = @"C:\Users\omerf\source\repos\BulKazan\BulKazan\Image\rabbit.png";
            }
            else
            {
                btnOne.Tag = @"C:\Users\omerf\source\repos\BulKazan\BulKazan\Image\rabbit.png";
                btnTwo.Tag = @"C:\Users\omerf\source\repos\BulKazan\BulKazan\Image\rabbit.png";
                btnThree.Tag = @"C:\Users\omerf\source\repos\BulKazan\BulKazan\Image\rabbitRed.png";
            }

        }

        void ButtonImageReset()
        {

            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;

                    btn.BackgroundImage = null;
                }
            }
        }
        void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ButtonImageReset();
            if (btn.Tag == @"C:\Users\omerf\source\repos\BulKazan\BulKazan\Image\rabbitRed.png")
            {
                btn.BackgroundImage = Image.FromFile(btn.Tag.ToString());
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                UserCount++;
                lblUserCount.Text = UserCount.ToString();

                if (UserCount == 5)
                {
                    MessageBox.Show("User win", "Tekrar Oynamak İster Misiniz?", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }

            }
            else
            {
                btn.BackgroundImage = Image.FromFile(btn.Tag.ToString());
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                Task.Delay(1000).Wait();
                ComputerCount++; lblComputerCount.Text = ComputerCount.ToString(); if (ComputerCount == 5)
                {
                    MessageBox.Show("Computer Win", "Tekrar Oynamak İster Misiniz?", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }


            ButtonRabbitProcess();
        }
    }
}