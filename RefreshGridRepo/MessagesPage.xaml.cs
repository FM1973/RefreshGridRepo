using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public partial class MessagesPage : ContentPage
{
    private MessagesViewModel ViewModel => BindingContext as MessagesViewModel;

    public MessagesPage(MessagesViewModel viewModel)
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