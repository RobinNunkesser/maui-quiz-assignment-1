using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace QuizAssignment1
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel viewModel = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
