using Xamarin.Forms;

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
