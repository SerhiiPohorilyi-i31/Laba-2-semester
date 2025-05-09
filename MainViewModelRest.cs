using Lab10_task21.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections;

namespace Lab10_task21.DataBase
{
    public class MainViewModelRest : BindableBase
    {
        private readonly RestService _restService;

        public MainViewModelRest()
        {
            _restService = new RestService();
            ReloadDishes();
        }

        private async Task ReloadDishes()
        {
            var items = await _restService.GetDishAsync();
            var result = items;
            if (IsSorted)
            {
                if (IsByName)
                {
                    result = items.OrderBy(x => x.Name).ToList();
                }
                else if (IsByCategory)
                {
                    result = items.OrderBy(x => x.Category).ToList();
                }
            }
            else
            {
                result = items.OrderBy(x => x.Id).ToList();
            }

            Dishes.Clear();
            result.ForEach(x => Dishes.Add(x));
        }

        public ObservableCollection<Dish> Dishes { get; set; } = new ObservableCollection<Dish>();

        private bool _isSorted;
        public bool IsSorted
        {
            get => _isSorted;
            set
            {
                SetProperty(ref _isSorted, value);
                _ = ReloadDishes(); // запуск async void
            }
        }

        private bool _isByName = true;
        public bool IsByName
        {
            get => _isByName;
            set
            {
                SetProperty(ref _isByName, value);
                _ = ReloadDishes();
            }
        }

        private bool _isByCategory;
        public bool IsByCategory
        {
            get => _isByCategory;
            set
            {
                SetProperty(ref _isByCategory, value);
                _ = ReloadDishes();
            }
        }

        private string _newDishName;
        public string NewDishName
        {
            get => _newDishName;
            set => SetProperty(ref _newDishName, value);
        }

        private string _newDishCategory;
        public string NewDishCategory
        {
            get => _newDishCategory;
            set => SetProperty(ref _newDishCategory, value);
        }

        private string _newDishIngredient;
        public string NewDishIngredient
        {
            get => _newDishIngredient;
            set => SetProperty(ref _newDishIngredient, value);
        }

        private int _newDishRating;
        public int NewDishRating
        {
            get => _newDishRating;
            set => SetProperty(ref _newDishRating, value);
        }

        public async Task SaveNewDish()
        {
            await _restService.CreateDishAsync(new Dish
            {
                Name = NewDishName,
                Category = NewDishCategory,
                Ingredients = NewDishIngredient,
                Rating = NewDishRating
            });

            await ReloadDishes();
            ClearNewDish();
        }

        public void ClearNewDish()
        {
            NewDishName = "";
            NewDishCategory = "";
            NewDishIngredient = "";
            NewDishRating = 0;
        }
    }
}
