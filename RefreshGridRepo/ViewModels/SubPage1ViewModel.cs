using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshGridRepo.ViewModels
{
    public partial class SubPage1ViewModel : BaseViewModel
    {
        public SubPage1ViewModel()
        {

        }

        [RelayCommand]
        public async Task ShowSubPage2()
        {
            await Shell.Current.GoToAsync($"{nameof(SubPage2)}", true);
        }
    }
}
