using SeenIT.Models;
using SeenIT.Services;
using SeenIT.Views;
using SeenIT.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SeenIT.ServiceReference;
using System.Windows.Input;
using SeenIT.Views.FilmViews;

namespace SeenIT.ViewModels.FilmVM
{
    public class FilmViewModel : AItemListViewModel<FilmForView>
    {
        public Command ProfileCommand { get; }
        public Command ListCommand { get; }
        public Command HomeCommand { get; }
        public ICommand OpenWebCommand { get; }
        public Command OpenObjectCommand { get; }
        public FilmViewModel()
            : base("Filmy")
        {
            ProfileCommand = new Command(OnProfileClicked);
            ListCommand = new Command(OnListClicked);
            HomeCommand = new Command(OnHomeClicked);
            OpenObjectCommand = new Command(OpenObjectPage);
        }
        public override async Task GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewFilmPage));
        }
        public override async Task GoToDetailsPage(FilmForView item)
        {
            await Shell.Current.GoToAsync($"{nameof(FilmDetailPage)}?{nameof(FilmDetailViewModel.ItemId)}={item.Id}");
        }
        public async void OnProfileClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(ProfilePage)}");
        }
        public async void OnListClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(FilmPage)}");
        }
        public async void OnHomeClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
        private async void OpenObjectPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(ObjectPage)}");
        }
    }
}
