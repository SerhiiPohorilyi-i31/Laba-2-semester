namespace Lab6_task21
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DishTextBox = new TextBox();
            CategoryTextBox = new TextBox();
            IngredientsTextBox = new TextBox();
            RatingNumericUpDown = new NumericUpDown();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            listBoxRecipes = new ListBox();
            listViewRecipes = new ListView();
            dataGridViewRecipes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)RatingNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).BeginInit();
            SuspendLayout();
            // 
            // DishTextBox
            // 
            DishTextBox.Location = new Point(37, 43);
            DishTextBox.Margin = new Padding(6);
            DishTextBox.Name = "DishTextBox";
            DishTextBox.PlaceholderText = "Назва страви";
            DishTextBox.Size = new Size(368, 39);
            DishTextBox.TabIndex = 0;
            DishTextBox.Text = "в";
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(37, 107);
            CategoryTextBox.Margin = new Padding(6);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.PlaceholderText = "Категорія";
            CategoryTextBox.Size = new Size(368, 39);
            CategoryTextBox.TabIndex = 1;
            CategoryTextBox.Text = "вава";
            // 
            // IngredientsTextBox
            // 
            IngredientsTextBox.Location = new Point(37, 171);
            IngredientsTextBox.Margin = new Padding(6);
            IngredientsTextBox.Name = "IngredientsTextBox";
            IngredientsTextBox.PlaceholderText = "Інгредієнти";
            IngredientsTextBox.Size = new Size(368, 39);
            IngredientsTextBox.TabIndex = 2;
            IngredientsTextBox.Text = "ваава";
            // 
            // RatingNumericUpDown
            // 
            RatingNumericUpDown.Location = new Point(37, 235);
            RatingNumericUpDown.Margin = new Padding(6);
            RatingNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            RatingNumericUpDown.Name = "RatingNumericUpDown";
            RatingNumericUpDown.Size = new Size(371, 39);
            RatingNumericUpDown.TabIndex = 3;
            RatingNumericUpDown.ValueChanged += RatingNumericUpDown_ValueChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(446, 43);
            buttonAdd.Margin = new Padding(6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(186, 64);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Додати";
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(446, 128);
            buttonEdit.Margin = new Padding(6);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(186, 64);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Редагувати";
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(446, 213);
            buttonDelete.Margin = new Padding(6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(186, 64);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Видалити";
            buttonDelete.Click += buttonDelete_Click;
            // 
            // listBoxRecipes
            // 
            listBoxRecipes.Location = new Point(37, 320);
            listBoxRecipes.Margin = new Padding(6);
            listBoxRecipes.Name = "listBoxRecipes";
            listBoxRecipes.Size = new Size(368, 196);
            listBoxRecipes.TabIndex = 7;
            // 
            // listViewRecipes
            // 
            listViewRecipes.Location = new Point(446, 320);
            listViewRecipes.Margin = new Padding(6);
            listViewRecipes.Name = "listViewRecipes";
            listViewRecipes.Size = new Size(1099, 209);
            listViewRecipes.TabIndex = 8;
            listViewRecipes.UseCompatibleStateImageBehavior = false;
            listViewRecipes.View = View.Details;
            listViewRecipes.SelectedIndexChanged += listViewRecipes_SelectedIndexChanged;
            // 
            // dataGridViewRecipes
            // 
            dataGridViewRecipes.ColumnHeadersHeight = 46;
            dataGridViewRecipes.Location = new Point(37, 576);
            dataGridViewRecipes.Margin = new Padding(6);
            dataGridViewRecipes.Name = "dataGridViewRecipes";
            dataGridViewRecipes.RowHeadersWidth = 82;
            dataGridViewRecipes.Size = new Size(1508, 320);
            dataGridViewRecipes.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1999, 941);
            Controls.Add(DishTextBox);
            Controls.Add(CategoryTextBox);
            Controls.Add(IngredientsTextBox);
            Controls.Add(RatingNumericUpDown);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(listBoxRecipes);
            Controls.Add(listViewRecipes);
            Controls.Add(dataGridViewRecipes);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Recipe Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)RatingNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox DishTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox IngredientsTextBox;
        private System.Windows.Forms.NumericUpDown RatingNumericUpDown;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.ListView listViewRecipes;
        private System.Windows.Forms.DataGridView dataGridViewRecipes;
    }
}
