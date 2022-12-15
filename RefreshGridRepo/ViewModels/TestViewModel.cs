using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RefreshGridRepo.ViewModels
{
    public partial class TestViewModel : ObservableObject
    {
        public TestViewModel()
        {

        }

        [ObservableProperty]
        private ObservableCollection<TestEntity> _list;

        [ObservableProperty]
        private bool _isRefreshing;

        #region Commands

        [RelayCommand]
        public void Refresh()
        {
            IsRefreshing = true;

            List = GetList(10).ToObservableCollection();

            IsRefreshing = false;
        }

        #endregion

        private void LoadData()
        {
            List = GetList(10).ToObservableCollection();
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

        private List<TestEntity> GetList(int max)
        {
            var list = new List<TestEntity>();

            for (int i = 1; i < max; i++)
            {
                list.Add(new TestEntity()
                {
                    Id = Guid.NewGuid().ToString("X"),
                    Title = $"Title {i}",
                    Description = $"Description {i}... Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut...",
                    Image = "dotnet_bot"
                });
            }

            return list;
        }

        #endregion
    }

    public class TestEntity
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
