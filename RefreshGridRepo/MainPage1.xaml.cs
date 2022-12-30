using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public partial class MainPage1 : ContentPage
{
    private MainPage1ViewModel ViewModel => BindingContext as MainPage1ViewModel;

    public MainPage1(MainPage1ViewModel viewModel)
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