using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Core.Extensions;
using RefreshGridRepo.Domain;
using CommunityToolkit.Mvvm.Input;

namespace RefreshGridRepo.ViewModels
{
    public partial class MessagesViewModel : ObservableObject
    {
        public MessagesViewModel()
        {

        }

        [ObservableProperty]
        private ObservableCollection<MessageGroup> _list;

        [ObservableProperty]
        private bool _isRefreshing;

        #region Commands

        [RelayCommand]
        public void Refresh()
        {
            IsRefreshing = true;

            List = GetMessageGroups(20);

            IsRefreshing = false;
        }

        #endregion

        private void LoadData()
        {
            List = GetMessageGroups(20);
        }

        #region Initialisierung


        public async Task InitializeAsync(object sender)
        {
            await Task.Delay(1);
            LoadData();
        }


        public Task DisappearingAsync(object sender)
        {
            return Task.FromResult(false);
        }

        #endregion

        #region private

        private List<Message> GetList(int max)
        {
            var list = new List<Message>();

            for (int i = 1; i < max; i++)
            {
                list.Add(new Message()
                {
                    Id = Guid.NewGuid().ToString("X"),
                    Content = $"Message {i}",
                    Direction = i % 2 == 0 ? MessageDirection.In : MessageDirection.Out,
                    UpdatedAt = DateTimeOffset.UtcNow.AddHours(i * 2)
                });
            }

            return list;
        }

        private ObservableCollection<MessageGroup> GetMessageGroups(int count)
        {
            var groups = new ObservableCollection<MessageGroup>();

            var messages = GetList(count);

            var messageGroups = messages.GroupBy(c => c.UpdatedAt.Value.Date);
            foreach (var messageGroup in messageGroups)
            {
                var group = new MessageGroup(messageGroup.Key.ToShortDateString(), messageGroup.Key, messageGroup.OrderByDescending(c => c.UpdatedAt).ToObservableCollection());
                groups.Add(group);
            }


            return groups.OrderByDescending(c => c.Date).ToObservableCollection();
        }

        #endregion
    }

    /// <summary>
    /// Hilfsklasse für das Gruppieren der Nachrichten
    /// </summary>
    public class MessageGroup : ObservableCollection<Message>
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public MessageGroup(string name, DateTime date, ObservableCollection<Message> messages) : base(messages)
        {
            Name = name;
            Date = date;
        }
    }
}
