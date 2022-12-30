using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public partial class MainPage4 : ContentPage
{
    private MainPage4ViewModel ViewModel => BindingContext as MainPage4ViewModel;

    public MainPage4(MainPage4ViewModel viewModel)
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