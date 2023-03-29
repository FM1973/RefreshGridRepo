using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public partial class TestPage6 : ContentPage
{
    private TestPage6ViewModel ViewModel => BindingContext as TestPage6ViewModel;

    public TestPage6(TestPage6ViewModel viewModel)
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