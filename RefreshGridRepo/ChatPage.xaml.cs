using CommunityToolkit.Mvvm.Messaging;
using RefreshGridRepo.Helper;
using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public partial class ChatPage : ContentPage
{
    private ChatViewModel ViewModel => BindingContext as ChatViewModel;

    public ChatPage(ChatViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }

    /// <inheritdoc />
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (WeakReferenceMessenger.Default.IsRegistered<ChatScrollToMessage>(this) == false)
            WeakReferenceMessenger.Default.Register<ChatScrollToMessage>(this, (recipient, scrollTomessage) =>
            {
                Dispatcher.Dispatch(() =>
                {
                    if (scrollTomessage.Value.ScrollToTop)
                        messages.ScrollTo(scrollTomessage.Value.MessageIndex, scrollTomessage.Value.GroupIndex, ScrollToPosition.Start, scrollTomessage.Value.Animate);
                    else
                        messages.ScrollTo(scrollTomessage.Value.MessageIndex, scrollTomessage.Value.GroupIndex, ScrollToPosition.End, scrollTomessage.Value.Animate);
                });
            });

        await ViewModel.InitializeAsync(this);
    }

    /// <inheritdoc />
    protected override async void OnDisappearing()
    {
        base.OnDisappearing();

        WeakReferenceMessenger.Default.Unregister<ChatScrollToMessage>(this);

        await ViewModel.DisappearingAsync(this);
    }
}