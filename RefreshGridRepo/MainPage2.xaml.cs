using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public partial class MainPage2 : ContentPage
{
    private MainPage2ViewModel ViewModel => BindingContext as MainPage2ViewModel;

    public MainPage2(MainPage2ViewModel viewModel)
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