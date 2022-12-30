using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public partial class MainPage3 : ContentPage
{
    private MainPage3ViewModel ViewModel => BindingContext as MainPage3ViewModel;

    public MainPage3(MainPage3ViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }

    /// <inheritdoc />
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await ViewModel.InitializeAsync(this);
    }

    /// <inheritdoc />
    protected override async void OnDisappearing()
    {
        base.OnDisappearing();
        await ViewModel.DisappearingAsync(this);
    }
}