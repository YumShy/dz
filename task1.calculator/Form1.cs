using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1.calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a = 0, b = 0, c = 0;

        char znak = '+';


        private void button_Click(object sender, EventArgs e) // вывод введеного числа 
        {
            textBox_result.Text += (sender as Button).Text;
        }

      

        private void button2_Click(object sender, EventArgs e) //ввод 1 числа
        {
            a = Convert.ToDouble(textBox_result.Text);
            znak = (sender as Button).Text[0];
            textBox_result.Clear();
        }

      
        private void button1_Click(object sender, EventArgs e) // ввод второго числа и запоминание действия
        {
          
            b = Convert.ToDouble(textBox_result.Text);
            switch (znak)
            {
                case '+': c = a + b;
                    break;

                case '-':
                    c = a - b;
                    break;

                case '*':
                    c = a * b;
                    break;

                case '/':
                    c = a / b;
                    break;
            }

            textBox_result.Text = c.ToString(); // вывод результата
        }

      

        private void button3_Click(object sender, EventArgs e) // очистка 
        {
            textBox_result.Clear();

        } 

        private void button4_Click(object sender, EventArgs e) //замена знака
        {
            if (textBox_result.Text != "")
            {
                if (textBox_result.Text[0] == '-')
                {
                    textBox_result.Text = textBox_result.Text.Remove(0, 1);
                }
                else textBox_result.Text = '-' + textBox_result.Text;
            }
        } 

        private void button5_Click(object sender, EventArgs e) //удаление цыфры
        {
            if (textBox_result.Text != "")
            {
               
                    textBox_result.Text = textBox_result.Text.Remove(textBox_result.Text.Length-1,1);
            
            }
        }

    }
}
