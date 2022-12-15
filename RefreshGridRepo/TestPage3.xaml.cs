using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public partial class TestPage3 : ContentPage
{
    private TestViewModel ViewModel => BindingContext as TestViewModel;

    public TestPage3(TestViewModel viewModel)
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