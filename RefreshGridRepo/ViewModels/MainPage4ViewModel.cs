using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace RefreshGridRepo.ViewModels
{
    public partial class MainPage4ViewModel : BaseViewModel
    {
        public MainPage4ViewModel()
        {

        }

        [RelayCommand]
        public async Task ShowSubPage1()
        {
            await Shell.Current.GoToAsync($"{nameof(SubPage1)}", true);
        }

        private async Task LoadAsync()
        {
            await Task.Delay(5000);
        }

        public override async Task InitializeAsync(object sender)
        {
            await base.InitializeAsync(sender);
            await LoadAsync();
        }
    }
}
