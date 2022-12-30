using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public partial class SubPage1 : ContentPage
{
    private SubPage1ViewModel ViewModel => BindingContext as SubPage1ViewModel;

    public SubPage1(SubPage1ViewModel viewModel)
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