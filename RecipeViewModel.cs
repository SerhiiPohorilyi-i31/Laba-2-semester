using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


public class RecipeViewModel : ObservableObject
{
    public ObservableCollection<Recipe> Recipes { get; set; } = new ObservableCollection<Recipe>();

    private string _назваСтрави;
    public string НазваСтрави
    {
        get => _назваСтрави;
        set => SetProperty(ref _назваСтрави, value);
    }

    private string _категорія;
    public string Категорія
    {
        get => _категорія;
        set => SetProperty(ref _категорія, value);
    }

    private string _інгредієнти;
    public string Інгредієнти
    {
        get => _інгредієнти;
        set => SetProperty(ref _інгредієнти, value);
    }

    private int _рейтинг;
    public int Рейтинг
    {
        get => _рейтинг;
        set => SetProperty(ref _рейтинг, value);
    }

    public IRelayCommand AddRecipeCommand { get; }

    public RecipeViewModel()
    {
        AddRecipeCommand = new RelayCommand(AddRecipe);
    }

    private void AddRecipe()
    {
        Recipes.Add(new Recipe
        {
            Name = НазваСтрави,
            Category = Категорія,
            Ingredients = Інгредієнти,
            Rating = Рейтинг
        });

        // Очистка текстових полів після додавання
        НазваСтрави = string.Empty;
        Категорія = string.Empty;
        Інгредієнти = string.Empty;
        Рейтинг = 0;
    }
}
