using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab7_task21
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            using (var DbContext = new AppDbContext())
            {
                DbContext.Database.EnsureCreated();
            }

            RefreshUI();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Додати_Click(object sender, RoutedEventArgs e)
        {
            using (var DbContext = new AppDbContext())
            {
                int рейтинг;
                if (!int.TryParse(Рейтинг.Text, out рейтинг))
                {
                    ContentDialog dialog = new ContentDialog()
                    {
                        Title = "Помилка",
                        Content = "Рейтинг має бути цілим числом.",
                        CloseButtonText = "OK"
                    };
                    _ = dialog.ShowAsync();
                    return;
                }

                var newDish = new Dish
                {
                    Name = Назва_страви.Text,
                    Category = Категорія.Text,
                    Ingredients = Інгредієнти.Text,
                    Rating = рейтинг
                };

                DbContext.Dishes.Add(newDish);
                DbContext.SaveChanges();
            }

            RefreshUI();
        }


        private void Редагувати_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewDishes.SelectedItem is Dish selectedDish)
            {
                using (var DbContext = new AppDbContext())
                {
                    var dish = DbContext.Dishes.Find(selectedDish.DishId);
                    if (dish != null)
                    {
                        dish.Name = Назва_страви.Text;
                        dish.Category = Категорія.Text;
                        dish.Ingredients = Інгредієнти.Text;
                        dish.Rating = int.Parse(Рейтинг.Text);
                        DbContext.SaveChanges();
                    }
                }

                RefreshUI();
            }
        }

        private void Видалити_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewDishes.SelectedItem is Dish selectedDish)
            {
                using (var DbContext = new AppDbContext())
                {
                    var dish = DbContext.Dishes.Find(selectedDish.DishId);
                    if (dish != null)
                    {
                        DbContext.Dishes.Remove(dish);
                        DbContext.SaveChanges();
                    }
                }

                RefreshUI();
            }
        }

        private void Очистити_Click(object sender, RoutedEventArgs e)
        {
            // Очищення всіх текстових полів
            Назва_страви.Text = string.Empty;
            Категорія.Text = string.Empty;
            Інгредієнти.Text = string.Empty;
            Рейтинг.Text = string.Empty;

            // Зняття вибору в ListView
            ListViewDishes.SelectedItem = null;
        }


        private void RefreshUI()
        {
            using (var DbContext = new AppDbContext())
            {
                ListViewDishes.ItemsSource = DbContext.Dishes.ToList();
            }
        }

        private void ListViewDishes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListViewDishes.SelectedItem is Dish selectedDish)
            {
                Назва_страви.Text = selectedDish.Name;
                Категорія.Text = selectedDish.Category;
                Інгредієнти.Text = selectedDish.Ingredients;
                Рейтинг.Text = selectedDish.Rating.ToString();
            }
        }
       
    }
}
