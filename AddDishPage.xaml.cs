using Microsoft.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Lab10_task21.DataBase;


namespace Lab10_task21
{
    
    public sealed partial class AddDishPage : Page
    {
        public AddDishPage()
        {
            this.InitializeComponent();
            ViewModel = App.ViewModel;
        }


        public MainViewModelRest ViewModel { get; }


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
             ViewModel.SaveNewDish();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewModel.ClearNewDish();
        }
    }
}
