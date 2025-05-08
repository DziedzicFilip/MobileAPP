using SeenIT.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SeenIT.ViewModels.Abstract;

namespace SeenIT.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        public Command SettingsCommand { get; }
        public SettingsViewModel()
        {
            SettingsCommand = new Command(OnSettingsClicked);
        }

        public async void OnSettingsClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(SettingPage)}");
        }
    }
}
