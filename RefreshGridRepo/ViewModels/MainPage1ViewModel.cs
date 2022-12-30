using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshGridRepo.ViewModels
{
    public partial class MainPage1ViewModel : BaseViewModel
    {
        public MainPage1ViewModel()
        {

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
