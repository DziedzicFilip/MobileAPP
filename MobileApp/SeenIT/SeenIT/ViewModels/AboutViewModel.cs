using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using SeenIT.Views;
using SeenIT.ViewModels.Abstract;
using SeenIT.Views.FilmViews;
using SeenIT.Views.SerialViews;
namespace SeenIT.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command OpenListPageCommand { get; }
        public Command OpenSerialPageCommand { get; }
        public Command OpenProfilePageCommand { get; }
        public ICommand OpenWebCommand { get; }
        public ICommand OpenAboutPage { get; }
        public Command OpenObjectCommand { get; }

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            OpenAboutPage = new Command(async () => await Shell.Current.GoToAsync($"//{nameof(AboutPage)}"));
            OpenListPageCommand = new Command(OnOpenListPage);
            OpenSerialPageCommand = new Command(OnOpenSerialPage);
            OpenProfilePageCommand = new Command(OnOpenProfilePage);
            OpenObjectCommand = new Command(OpenObjectPage);
        }
        private async void OnOpenListPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(FilmPage)}");
        }
        private async void OnOpenSerialPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(SerialPage)}");
        }

        private async void OnOpenProfilePage()
        {
            await Shell.Current.GoToAsync($"//{nameof(ProfilePage)}");
        }
        private async void OpenObjectPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(ObjectPage)}");
        }

    }
}