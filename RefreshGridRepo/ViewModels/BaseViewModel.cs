using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RefreshGridRepo.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {

        }

        #region Commands

        [RelayCommand]
        public async Task ShowMain1()
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage1)}", true);
        }

        [RelayCommand]
        public async Task ShowMain2()
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage2)}", true);
        }

        [RelayCommand]
        public async Task ShowMain3()
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage3)}", true);
        }

        [RelayCommand]
        public async Task ShowMain4()
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage4)}", true);
        }

        #endregion

        #region Initialisierung


        public virtual async Task InitializeAsync(object sender)
        {
            await Task.Delay(2000);
        }


        public virtual Task DisappearingAsync(object sender)
        {
            return Task.FromResult(false);
        }

        #endregion
    }
}
