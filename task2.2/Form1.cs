using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.timer1.Interval += 1000;
            this.timer1.Tick += tick;
            this.timer1.Enabled = true;
            this.button1.MouseMove += Button1_MouseMove;

            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {  
            this.textBox2.Text = e.X.ToString();
            this.textBox3.Text = e.Y.ToString();
            int  speed = 10, al = 100,bet=50;

            if (e.X > button1.Location.X -al && e.X < button1.Location.X && e.Y > button1.Location.Y - bet && e.Y < button1.Location.Y)
            {
                button1.Location = new Point(button1.Location.X + speed, button1.Location.Y + speed);
            }
            if (e.X > button1.Location.X - al && e.X < button1.Location.X && e.Y > button1.Location.Y && e.Y < button1.Location.Y + bet)
            {
                button1.Location = new Point(button1.Location.X + speed, button1.Location.Y);
            }
            if (e.X < button1.Location.X + al && e.X > button1.Location.X && e.Y > button1.Location.Y && e.Y < button1.Location.Y + bet)
            {
                button1.Location = new Point(button1.Location.X - speed, button1.Location.Y);
            }
            if (e.Y > button1.Location.Y - bet && e.Y < button1.Location.Y && e.X > button1.Location.X && e.X < button1.Location.X + al)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + speed);
            }
            if (e.Y < button1.Location.Y + bet && e.Y > button1.Location.Y && e.X > button1.Location.X && e.X < button1.Location.X + al)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y - speed);
            }

            if (button1.Location.Y> this.ClientRectangle.Height  )
            {
                button1.Location = new Point(button1.Location.X, 300);
            }

            if (button1.Location.Y < 0)
            {
                button1.Location = new Point(button1.Location.X, 100);
            }

            if (button1.Location.X < 0)
            {
                button1.Location = new Point( 100, button1.Location.Y);
            }

            if (button1.Location.X> this.ClientRectangle.Width)
            {
                button1.Location = new Point(400, button1.Location.Y);
            }


        }
        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.textBox2.Text = e.X.ToString();
            this.textBox3.Text = e.Y.ToString();
        }

        private void tick(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.button1.Height -= 1;
            this.button1.Width -= 2;

            if(button1.Height==0 && button1.Width ==0)
            {
                button1.Dispose();

                timer2.Enabled = true;
            }

            
        }
        private void button1_clik (object sender, EventArgs e)
        {
            if (this.timer1.Enabled)
            {
                this.timer1.Stop();
            }
            else
            {
                this.timer1.Start();
            }

        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (this.Text == "кнопка удалена")
            {
                this.Text = "ты проиграл";
            }
            else
            {
                this.Text = "кнопка удалена";
            }

        }
    }
}
