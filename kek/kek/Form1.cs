using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kek
{
    public partial class Form1 : Form
    {
        string kek;
        Class2 a = new Class2();
        Class3 b = new Class3();
        int x;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a.VChislo = Convert.ToDouble(textBox1.Text);

                switch (kek)
                {
                    case "+":
                        textBox1.Text = Convert.ToString(a.Summa); /*сумма*/
                        a.PChislo = Convert.ToDouble(null); /*освобождение 1 числа из памяти*/
                        break;

                    case "-":
                        textBox1.Text = Convert.ToString(a.Vichetane); /*разность*/
                        a.PChislo = Convert.ToDouble(null); /*освобождение 1 числа из памяти*/
                        break;

                    case "*":
                        textBox1.Text = Convert.ToString(a.Ymnojenie); /*умножение*/
                        a.PChislo = Convert.ToDouble(null); /*освобождение 1 числа из памяти*/
                        break;

                    case "/":
                        textBox1.Text = Convert.ToString(a.Delenie); /*деление*/
                        a.PChislo = Convert.ToDouble(null); /*освобождение 1 числа из памяти*/
                        break;
                    case "S":
                        textBox1.Text = Convert.ToString(a.Stepen); /*возведение в степень*/
                        a.PChislo = Convert.ToDouble(null); /*освобождение 1 числа из памяти*/
                        break;
                    case "P":
                        textBox1.Text = Convert.ToString(a.Procent); /*Процент*/
                        a.PChislo = Convert.ToDouble(null); /*освобождение 1 числа из памяти*/
                        break;
                }
            }
            else
            {

                MessageBox.Show("введите число");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text; // передача кнопок в textbox
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                a.PChislo = Convert.ToDouble(textBox1.Text);
                kek = (sender as Button).Text;
                textBox1.Clear();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // событие для введения цифр с клавиатуры
        {
            Char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8 && num != 44) // обработка цифр с клавиатуры
                e.Handled = true; // событие обрабатывается или не обрабатывается вовсе            
        }
        private void CLEAR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBox1.Text))); // не ставьте два плиз, я не хотел
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log10(Convert.ToDouble(textBox1.Text))); // 
        }

        private void button20_Click(object sender, EventArgs e) // модуль
        {
            x = Convert.ToInt32(textBox1.Text);
            if (x < 0)
                x = x * -1;
            textBox1.Text = Convert.ToString(x);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            if (x > 0)
            {
                textBox1.Text = ('-' + textBox1.Text);
            }
            else
            {
                textBox1.Text = Convert.ToString(x * -1);
            }
        }
    }
}
