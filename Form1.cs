using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab1_task21._1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { 1, 3, 6, 12 }); //Доступні терміни
            comboBox1.SelectedIndex = 0; // Значення за замовчукванням
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal amount))
            {
                int term = (int)comboBox1.SelectedItem;
                decimal rate = GetInterestRate(term);
                decimal profit = amount * (rate / 100);
                button2.Text = $"Прибуток: {profit:C2}";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректну суму.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetInterestRate(int term)
        {
            decimal rate;

            switch (term)
            {
                case 1:
                    rate = 3.0m;  // 3% для 1 місяця
                    break;
                case 3:
                    rate = 4.5m;  // 4.5% для 3 місяців
                    break;
                case 6:
                    rate = 6.0m;  // 6% для 6 місяців
                    break;
                case 12:
                    rate = 7.5m; // 7.5% для 12 місяців
                    break;
                default:
                    rate = 0m;
                    break;
            }

            return rate;
        }

    }
}
