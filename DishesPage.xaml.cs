using Windows.UI.Xaml;
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
using Lab10_task21.DataBase;


namespace Lab10_task21
{
    public sealed partial class DishesPage : Page
    {
        public DishesPage()
        {
            this.InitializeComponent();
            ViewModel = App.ViewModel;
        }


        public MainViewModelRest ViewModel { get; }
        public object Id { get; }
    }

}
