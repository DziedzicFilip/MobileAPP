using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using SeenIT.Views;
namespace SeenIT.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command OpenListPageCommand { get; }
        public Command OpenProfilePageCommand { get; }
        public ICommand OpenWebCommand { get; }
        public ICommand OpenAboutPage { get; }

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            OpenAboutPage = new Command(async () => await Shell.Current.GoToAsync($"//{nameof(AboutPage)}"));
            OpenListPageCommand = new Command(OnOpenListPage);
            OpenProfilePageCommand = new Command(OnOpenProfilePage);
        }
        private async void OnOpenListPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(ListPage)}");
        }

        private async void OnOpenProfilePage()
        {
            await Shell.Current.GoToAsync($"//{nameof(ProfilePage)}");
        }

    }
}