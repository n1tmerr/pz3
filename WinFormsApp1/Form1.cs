using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double sum1;
        double sum2;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Сумма равна {sum2}");
        }
        public void button5_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(comboBox5.SelectedItem) * 1;
            double b = Convert.ToDouble(comboBox6.SelectedItem) * 2;
            double c = Convert.ToDouble(comboBox7.SelectedItem) * 5;
            double d = Convert.ToDouble(comboBox8.SelectedItem) * 10;
            double e1 = Convert.ToDouble(comboBox9.SelectedItem) * 50;
            double f = Convert.ToDouble(comboBox10.SelectedItem) * 100;
            double i = Convert.ToDouble(comboBox13.SelectedItem) * 500;
            double g = Convert.ToDouble(comboBox11.SelectedItem) * 1000;
            double h = Convert.ToDouble(comboBox12.SelectedItem) * 5000;
            sum1 = a + b + c + d + e1 + f + g + h+i;
            MessageBox.Show($"Сумма равна {sum1}");
        }
        public void button6_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(comboBox5.SelectedItem) * 1;
            double b = Convert.ToDouble(comboBox6.SelectedItem) * 2;
            double c = Convert.ToDouble(comboBox7.SelectedItem) * 5;
            double d = Convert.ToDouble(comboBox8.SelectedItem) * 10;
            double e1 = Convert.ToDouble(comboBox9.SelectedItem) * 50;
            double f = Convert.ToDouble(comboBox10.SelectedItem) * 100;
            double i = Convert.ToDouble(comboBox13.SelectedItem) * 500;
            double g = Convert.ToDouble(comboBox11.SelectedItem) * 1000;
            double h = Convert.ToDouble(comboBox12.SelectedItem) * 5000;
            sum2 = a + b + c + d + e1 + f + g + h+i;
            MessageBox.Show($"Сумма равна {sum2}");
        }
        public void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(comboBox5.SelectedItem) * 1;
            double b = Convert.ToDouble(comboBox6.SelectedItem) * 2;
            double c = Convert.ToDouble(comboBox7.SelectedItem) * 5;
            double d = Convert.ToDouble(comboBox8.SelectedItem) * 10;
            double e1 = Convert.ToDouble(comboBox9.SelectedItem) * 50;
            double f = Convert.ToDouble(comboBox10.SelectedItem) * 100;
            double i = Convert.ToDouble(comboBox13.SelectedItem) * 500;
            double g = Convert.ToDouble(comboBox11.SelectedItem) * 1000;
            double h = Convert.ToDouble(comboBox12.SelectedItem) * 5000;
            sum1 = a + b + c + d + e1 + f + g + h+i;
            sum2 = a + b + c + d + e1 + f + g + h+i;
            MessageBox.Show($"В результате сложения двух сумм получилось {sum1 + sum2}");   
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(comboBox5.SelectedItem) * 1;
            double b = Convert.ToDouble(comboBox6.SelectedItem) * 2;
            double c = Convert.ToDouble(comboBox7.SelectedItem) * 5;
            double d = Convert.ToDouble(comboBox8.SelectedItem) * 10;
            double e1 = Convert.ToDouble(comboBox9.SelectedItem) * 50;
            double f = Convert.ToDouble(comboBox10.SelectedItem) * 100;
            double i = Convert.ToDouble(comboBox13.SelectedItem) * 500;
            double g = Convert.ToDouble(comboBox11.SelectedItem) * 1000;
            double h = Convert.ToDouble(comboBox12.SelectedItem) * 5000;
            sum1 = a + b + c + d + e1 + f + g + h+i;
            sum2 = a + b + c + d + e1 + f + g + h+ i;
            MessageBox.Show($"Разность двух сумм = {sum1-sum2}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(comboBox5.SelectedItem) * 1;
            double b = Convert.ToDouble(comboBox6.SelectedItem) * 2;
            double c = Convert.ToDouble(comboBox7.SelectedItem) * 5;
            double d = Convert.ToDouble(comboBox8.SelectedItem) * 10;
            double e1 = Convert.ToDouble(comboBox9.SelectedItem) * 50;
            double f = Convert.ToDouble(comboBox10.SelectedItem) * 100;
            double i = Convert.ToDouble(comboBox13.SelectedItem) * 500;
            double g = Convert.ToDouble(comboBox11.SelectedItem) * 1000;
            double h = Convert.ToDouble(comboBox12.SelectedItem) * 5000;
            sum1 = a + b + c + d + e1 + f + g + h+i;
            sum2 = a + b + c + d + e1 + f + g + h+i;
            MessageBox.Show($"Произведение сумм рублей = {sum1 * sum2}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(comboBox5.SelectedItem) * 1;
            double b = Convert.ToDouble(comboBox6.SelectedItem) * 2;
            double c = Convert.ToDouble(comboBox7.SelectedItem) * 5;
            double d = Convert.ToDouble(comboBox8.SelectedItem) * 10;
            double e1 = Convert.ToDouble(comboBox9.SelectedItem) * 50;
            double f = Convert.ToDouble(comboBox10.SelectedItem) * 100;
            double i = Convert.ToDouble(comboBox13.SelectedItem) * 500;
            double g = Convert.ToDouble(comboBox11.SelectedItem) * 1000;
            double h = Convert.ToDouble(comboBox12.SelectedItem) * 5000;
            sum1 = a + b + c + d + e1 + f + g + h+i;
            sum2 = a + b + c + d + e1 + f + g + h+i;
            double chastnoe = sum1 / sum2;
            MessageBox.Show($"Частное сумм рублей = {chastnoe}");
        }
    }
}
