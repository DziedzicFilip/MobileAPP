using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using SeenIT.Views;
namespace SeenIT.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            OpenAboutPage = new Command(async () => await Shell.Current.GoToAsync($"//{nameof(AboutPage)}"));
        }

        public ICommand OpenWebCommand { get; }
        public ICommand OpenAboutPage { get; }
    }
}