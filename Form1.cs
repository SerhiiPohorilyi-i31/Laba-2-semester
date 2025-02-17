using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_task21._2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Лаб. 1"; // заголовок форми
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Перевірка допустимості даних
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtBirthYear.Text) ||
                string.IsNullOrWhiteSpace(txtGroup.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка року народження
            if (!int.TryParse(txtBirthYear.Text, out int birthYear) || birthYear < 1993 || birthYear > DateTime.Now.Year)
            {
                MessageBox.Show("Будь ласка, введіть коректний рік народження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Виведення даних
            txtOutput.Text = $"Ім’я: {txtFirstName.Text}\r\n" +
                             $"Прізвище: {txtLastName.Text}\r\n" +
                             $"Рік народження: {txtBirthYear.Text}\r\n" +
                             $"Група: {txtGroup.Text}\r\n" +
                             $"Курс: {txtCourse.Text}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
