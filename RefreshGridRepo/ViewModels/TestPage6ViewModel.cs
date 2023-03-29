using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshGridRepo.ViewModels
{
    public partial class TestPage6ViewModel : ObservableObject
    {
        public TestPage6ViewModel()
        {
        }

        [ObservableProperty]
        private string _testData;


        [RelayCommand]
        public async void Test()
        {
            await Application.Current.MainPage.DisplayPromptAsync("Alert", "Clicked", "Close");
        }

        private async Task LoadDataAsync()
        {
            await Task.Delay(1000);
            TestData = "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... " +
                       "Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... Bla bla bla... ";
        }

        #region Initialisierung

        public async Task InitializeAsync(object sender)
        {
            await Task.Delay(1);
            await LoadDataAsync();
        }


        public Task DisappearingAsync(object sender)
        {
            return Task.FromResult(false);
        }

        #endregion
    }
}
