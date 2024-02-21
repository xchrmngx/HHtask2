using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }
        private void Triangle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // возврат на предыдущую форму
            form1.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) // запрет на ввод любых символов кроме цифр
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox3.Text);
            int c = Convert.ToInt32(textBox4.Text);
            int h = Convert.ToInt32(textBox5.Text);
            if (a > b || a > c || b > a || b > c || c > a || c > b) // проверка на неравнобедренность треугольника 
            {
                label2.Text = "Площадь неравнобедренного треугольника";
            }
            else if (a == b || a == c || b == a || b == c || c == a || c == b) // проверка на равнобедренность треугольника
            {
                label2.Text = "Площадь равнобедренного треугольника";
            }
            double s = (a * h) / 2; // подсчет площади
            textBox2.Text = s.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
