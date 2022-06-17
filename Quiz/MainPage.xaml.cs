namespace Quiz;

public partial class MainPage : ContentPage
{
    private readonly MainViewModel viewModel = new MainViewModel();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
