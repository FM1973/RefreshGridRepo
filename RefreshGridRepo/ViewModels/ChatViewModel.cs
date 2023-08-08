using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefreshGridRepo.Domain;
using RefreshGridRepo.Interfaces;
using CommunityToolkit.Mvvm.Messaging;
using RefreshGridRepo.Helper;
using CommunityToolkit.Mvvm.Input;

namespace RefreshGridRepo.ViewModels
{
    public partial class ChatViewModel : ObservableObject
    {
        private readonly IChatService _chatService;
        private int _total;
        private int _skip = 0;
        private int _take = 20;


        public ChatViewModel(IChatService chatService)
        {
            _chatService = chatService;
            IsLoading = false;
        }

        [ObservableProperty] 
        private ObservableCollection<Message> _messages;

        [ObservableProperty]
        private bool _isLoading;

        #region Commands

        [RelayCommand]
        public async Task CheckLoadMore(object value)
        {
            if (IsLoading)
                return;

            if (value is ItemsViewScrolledEventArgs args)
            {
                System.Diagnostics.Debug.WriteLine($"First: {args.FirstVisibleItemIndex} | Last: {args.LastVisibleItemIndex} | Cencter: {args.CenterItemIndex} | VDelta: {args.VerticalDelta} | VOffset {args.VerticalOffset}");

                if (args.VerticalDelta >= 0)
                    return;

                if (args.VerticalDelta < 0 && args.FirstVisibleItemIndex == 0)
                {
                    if (Messages.Count < _total)
                    {
                        await LoadMore();
                    }
                }
            }
        }

        #endregion

        private async Task LoadMore()
        {
            if (Messages != null && Messages.Count < _total && !IsLoading)
            {
                try
                {
                    IsLoading = true;

                    System.Diagnostics.Debug.WriteLine($"Loading....");

                    var currentMessage = Messages.FirstOrDefault(); //Will be used later if IOS

                    var result = await _chatService.GetMessagesAsync(_take, _skip);
                    var messages = result.Item2.OrderByDescending(c => c.UpdatedAt);

                    foreach (var message in messages)
                    {
                        Messages.Insert(0,message);
                    }
                    
                    _total = result.Item1;
                    _skip = _skip + _take;

                    //IOS Scrolls to the first item when inserting new items. Therefore we need to scroll to the last visible item before inserting new items
                    if (currentMessage != null && DeviceInfo.Platform == DevicePlatform.iOS)
                    {
                        await Task.Delay(250);
                        var index = Messages.IndexOf(currentMessage);
                        WeakReferenceMessenger.Default.Send(new ChatScrollToMessage(new MessagesToInfo(-1, index, true, false)));
                    }

                    IsLoading = false;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
                finally
                {
                    IsLoading = false;
                }
            }
        }

        private async Task LoadDataAsync()
        {
            IsLoading = true;

            var result = await _chatService.GetMessagesAsync(_take, _skip);
            var messages = result.Item2.OrderBy(c => c.UpdatedAt);
            Messages = new ObservableCollection<Message>(messages);

            _total = result.Item1;
            _skip = _skip + _take;

            if (Messages != null && Messages.Any())
            {
                var lastMessage = Messages.Last();
                var index = Messages.IndexOf(lastMessage);
                WeakReferenceMessenger.Default.Send(new ChatScrollToMessage(new MessagesToInfo(-1, index, false, false)));
            }

            IsLoading = false;
        }

        public async Task InitializeAsync(object sender)
        {
            await Task.Delay(1);
            await LoadDataAsync();
        }

        public Task DisappearingAsync(object sender)
        {
            return Task.FromResult(false);
        }
    }
}
