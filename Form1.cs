using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_task21._2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Форма реєстрації"; // заголовок форми

            //Налаштування NumericUpDown контролів
            numYear.Minimum = 1990;
            numYear.Maximum = 2007;
            numDay.Minimum = 1;
            numDay.Maximum = 31;

            // Встановлення текстів для RadioButton
            radioMale.Text = "Чоловік";
            radioFemale.Text = "Жінка";
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Заповнення ComboBox з місяцями
            comboBoxMonth.Items.AddRange(new object[]
            {
                "Січня", "Лютого", "Березня", "Квітня", "Травня", "Червня",
                "Липня", "Серпня", "Вересня", "Жовтня", "Листопада", "Грудня"
            });

            // Заповнення ComboBox з містами народження
            comboBoxCity.Items.AddRange(new object[]
            {
                "Київ", "Харків", "Одеса", "Дніпро", "Запоріжжя", "Львів",
                "Кривий Ріг", "Миколаїв", "Черкаси", "Житомир"
            });
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            // Перевірка допустимості даних
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtGroup.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text) ||
                comboBoxMonth.SelectedIndex == -1 ||
                comboBoxCity.SelectedIndex == -1)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка року, місяця та дня народження
            int year = (int)numYear.Value;
            string month = comboBoxMonth.SelectedItem.ToString();
            int day = (int)numDay.Value;
            string city = comboBoxCity.SelectedItem.ToString();

            // Визначення статі
            string gender = radioMale.Checked ? "Чоловік" : "Жінка";

            // Виведення даних
            txtOutput.Text = $"Ім’я: {txtFirstName.Text}\r\n" +
                             $"Прізвище: {txtLastName.Text}\r\n" +
                             $"Дата народження: {day} {month} {year}\r\n" +
                             $"Місто народження: {city}\r\n" +
                             $"Стать: {gender}\r\n" +
                             $"Група: {txtGroup.Text}\r\n" +
                             $"Курс: {txtCourse.Text}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
