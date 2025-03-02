using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_task21._3
{
    public partial class Form1 : Form
    {
        // Визначення констант для цін
        private const decimal PlombirPrice = 150m;
        private const decimal VershkovePrice = 100m;
        private const decimal SorbetPrice = 160m;
        private const decimal FructoviyLidPrice = 70m;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Розрахунок вартості замовлення морозива";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Скидання форми
            numericPortions.Value = 0;
            txt_.Text = "";
            chkPlombir.Checked = false;
            chkVershkove.Checked = false;
            chkSorbet.Checked = false;
            chkFructoviyLid.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Зчитування кількості порцій
            int portions = (int)numericPortions.Value;
            if (portions <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну кількість порцій.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Розрахунок кількості порцій для кожного сорту
            int portionsPlombir = chkPlombir.Checked ? portions : 0;
            int portionsVershkove = chkVershkove.Checked ? portions : 0;
            int portionsSorbet = chkSorbet.Checked ? portions : 0;
            int portionsFructoviyLid = chkFructoviyLid.Checked ? portions : 0;

            // Загальна кількість порцій
            int totalPortions = portionsPlombir + portionsVershkove + portionsSorbet + portionsFructoviyLid;

            if (totalPortions <= 0)
            {
                MessageBox.Show("Будь ласка, виберіть хоча б один сорт морозива.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Розрахунок загальної вартості
            decimal totalAmount = (portionsPlombir * PlombirPrice) +
                                  (portionsVershkove * VershkovePrice) +
                                  (portionsSorbet * SorbetPrice) +
                                  (portionsFructoviyLid * FructoviyLidPrice);

            // Застосування знижки 5%, якщо кількість порцій перевищує 20
            if (totalPortions > 20)
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