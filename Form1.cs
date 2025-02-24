using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_task21._1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            btnOrder.Click += btnOrder_Click;
            btnReset.Click += btnReset_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numericDarkBeer.Value = 0;
            numericLightBeer.Value = 0;
            numericChips.Value = 0;
            numericFish.Value = 0;
            txtTotal.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            decimal darkBeerPrice = 110;
            decimal lightBeerPrice = 100;
            decimal chipsPrice = 50;
            decimal fishPrice = 60;

            // Отримання кількості
            int darkBeerQty = (int)numericDarkBeer.Value;
            int lightBeerQty = (int)numericLightBeer.Value;
            int chipsQty = (int)numericChips.Value;
            int fishQty = (int)numericFish.Value;

            // Розрахунок загальної вартості
            decimal total = (darkBeerQty * darkBeerPrice) +
                            (lightBeerQty * lightBeerPrice) +
                            (chipsQty * chipsPrice) +
                            (fishQty * fishPrice);
            if (total > 300)
            {
                total *= 0.85m;
            }

            txtTotal.Text = $"{total:F2} UAH";
        }
    }
}
