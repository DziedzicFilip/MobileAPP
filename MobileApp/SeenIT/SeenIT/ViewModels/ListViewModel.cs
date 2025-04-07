using SeenIT.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SeenIT.ViewModels
{
    public class ListViewModel : BaseViewModel
    {
        public Command ProfileCommand { get; }
        public Command ListCommand { get; }
        public Command HomeCommand { get; }
        public ListViewModel()
        {
            ProfileCommand = new Command(OnProfileClicked);
            ListCommand = new Command(OnListClicked);
            HomeCommand = new Command(OnHomeClicked);
        }
        public async void OnProfileClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(ProfilePage)}");
        }
        public async void OnListClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(ListPage)}");
        }
        public async void OnHomeClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }



    }
}
