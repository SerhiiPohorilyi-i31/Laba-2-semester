using Lab6_task21.Recipe;
using System.Windows.Forms;

namespace Lab6_task21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EnsureDatabaseCreated();

            RefreshUI();
        }
        private void EnsureDatabaseCreated()
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Database.EnsureCreated();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                var newRecipe = new RecipeModel
                {
                    Name = DishTextBox.Text,
                    Category = CategoryTextBox.Text,
                    Ingredients = IngredientsTextBox.Text,
                    Rating = int.Parse(RatingNumericUpDown.Value.ToString())
                };
                dbContext.Recipes.Add(newRecipe);
                dbContext.SaveChanges();

            }
            RefreshUI(); // Метод для оновлення всіх даних в UI
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem is RecipeModel selectedRecipe)
            {
                using (var dbContext = new AppDbContext())
                {
                    var recipe = dbContext.Recipes.Find(selectedRecipe.RecipeId);
                    recipe.Name = DishTextBox.Text;
                    recipe.Category = CategoryTextBox.Text;
                    recipe.Ingredients = IngredientsTextBox.Text;
                    recipe.Rating = int.Parse(RatingNumericUpDown.Value.ToString());
                    dbContext.SaveChanges();
                }

                RefreshUI();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem is RecipeModel selectedRecipe)
            {
                using (var dbContext = new AppDbContext())
                {
                    var recipe = dbContext.Recipes.Find(selectedRecipe.RecipeId);
                    dbContext.Recipes.Remove(recipe);
                    dbContext.SaveChanges();
                }

                RefreshUI();
            }
        }

        private void RefreshUI()
        {
            using (var dbContext = new AppDbContext())
            {
                var recipes = dbContext.Recipes.ToList();

                // Оновлення ListBox
                listBoxRecipes.DataSource = recipes;
                listBoxRecipes.DisplayMember = "Name";

                // Оновлення ListView
                listViewRecipes.Items.Clear();
                foreach (var recipe in recipes)
                {
                    var item = new ListViewItem(recipe.Name);
                    item.SubItems.Add(recipe.Category);
                    item.SubItems.Add(recipe.Ingredients);
                    item.SubItems.Add(recipe.Rating.ToString());
                    listViewRecipes.Items.Add(item);
                }

                // Оновлення DataGridView
                dataGridViewRecipes.DataSource = recipes;
            }
        }

        private void listViewRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRecipes.SelectedItems.Count > 0)
            {
                var selectedItem = listViewRecipes.SelectedItems[0];

                DishTextBox.Text = selectedItem.Text;
                CategoryTextBox.Text = selectedItem.SubItems[1].Text;
                IngredientsTextBox.Text = selectedItem.SubItems[2].Text;
                RatingNumericUpDown.Value = int.Parse(selectedItem.SubItems[3].Text);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void RatingNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
