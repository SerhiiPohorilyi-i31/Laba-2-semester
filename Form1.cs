using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_task21._1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Форма реєстрації"; // заголовок форми

            // Налаштування NumericUpDown контролів
            numYear.Minimum = 1900;
            numYear.Maximum = 2007;
            numMonth.Minimum = 1;
            numMonth.Maximum = 12;
            numDay.Minimum = 1;
            numDay.Maximum = 31;

            // Встановлення текстів для RadioButton контролів
            radioMale.Text = "Чоловік";
            radioFemale.Text = "Жінка";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
           

           
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Перевірка допустимості даних
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtGroup.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка року народження
            int year = (int)numYear.Value;
            int month = (int)numMonth.Value;
            int day = (int)numDay.Value;

            // Визначення статі
            string gender = radioMale.Checked ? "Чоловік" : "Жінка";

            // Виведення даних
            txtOutput.Text = $"Ім’я: {txtFirstName.Text}\r\n" +
                             $"Прізвище: {txtLastName.Text}\r\n" +
                             $"Дата народження: {day}/{month}/{year}\r\n" +
                             $"Стать: {gender}\r\n" +
                             $"Група: {txtGroup.Text}\r\n" +
                             $"Курс: {txtCourse.Text}";
        }
    }
    }
