using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public partial class SubPage2 : ContentPage
{
    private SubPage2ViewModel ViewModel => BindingContext as SubPage2ViewModel;

    public SubPage2(SubPage2ViewModel viewModel)
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