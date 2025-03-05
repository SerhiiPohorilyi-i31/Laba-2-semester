using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_task21._1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Заповнення списку
            comboBox1.Items.AddRange(new object[]
            {
                "50 Cent - Candy Shop",
                "Eminem - Lose Yourself",
                "Future - Mask Off",
                "Tyga - Ibiza",
                "Riff Raff - Tip Toe",
                "YBE - Underdog",
                "Snoop Dogg - Still D.R.E.",
                "Ludacris - Act A Fool",
                "Lil Baby - Band4Band",
                "Lil Uzi Vert - Do What I Want"
            });
            comboBox1.Sorted = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.Text;
            if (!string.IsNullOrEmpty(selectedItem) && !listBox1.Items.Contains(selectedItem))
            {
                listBox1.Items.Add(selectedItem);
            }
            else
            {
                MessageBox.Show("Нічого не вибрано або елемент вже існує в списку.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void btnClear_Click_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }




    }
    }
