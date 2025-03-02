using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_task21._2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Розрахунок вартості замовлення морозива";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Скидання форми
            numericPortions.Text = "";
            txt_.Text = "";
            radioPlombir.Checked = false;
            radioVershkove.Checked = false;
            radioSorbet.Checked = false;
            radioFructoviyLid.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            // Зчитування кількості порцій
            int portions;
            if (!int.TryParse(numericPortions.Text, out portions) || portions <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну кількість порцій.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Визначення ціни обраного сорту морозива
            decimal pricePerPortion = 0m;
            if (radioPlombir.Checked)
            {
                pricePerPortion = 150m;
            }
            else if (radioVershkove.Checked)
            {
                pricePerPortion = 100m;
            }
            else if (radioSorbet.Checked)
            {
                pricePerPortion = 160m;
            }
            else if (radioFructoviyLid.Checked)
            {
                pricePerPortion = 70m;
            }

            // Розрахунок загальної вартості
            decimal totalAmount = pricePerPortion * portions;

            // Застосування знижки 5%, якщо кількість порцій перевищує 20
            if (portions > 20)
            {
                totalAmount *= 0.95m;
            }

            // Виведення загальної вартості замовлення
            txt_.Text = $"Загальна вартість: {totalAmount:C2}";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
