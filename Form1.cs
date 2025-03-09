using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_task21._3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Заповнення СheckedListBox1
            checkedListBox1.Items.AddRange(new object[]
            {
                "Живі субтитри",
                "Меттєвий переклад",
                "Ненадовго виділяти вибраний текст",
                "Додати функції для спеціальних можливостей",
                "VoiceOver"
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveSetting_Click_1(object sender, EventArgs e)
        {
            // Отримання вибраних елементів
            StringBuilder selectedSettings = new StringBuilder();
            foreach (object item in checkedListBox1.CheckedItems)
            {
                selectedSettings.AppendLine(item.ToString());
            }

            // Виведення вибраних налаштувань у TextBox
            textBoxOutput.Text = selectedSettings.ToString();
        }

        private void buttonDefaultSettings_Click_1(object sender, EventArgs e)
        {
            // Зняття виділення з усіх елементів у CheckedListBox
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            // Очищення TextBoxOutput
            textBoxOutput.Text = "Налаштування скинуті до стандартних.";
        }
    }
}
