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
        public Command OpenListPageCommand { get; }
        public Command OpenProfilePageCommand { get; }
        public ICommand OpenWebCommand { get; }
        public ICommand OpenAboutPage { get; }
        public Command OpenObjectCommand { get; }
        public FilmViewModel()
            : base("Filmy")
        {
            OpenListPageCommand = new Command(OnOpenListPage);
            OpenProfilePageCommand = new Command(OnOpenProfilePage);
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
        private async void OnOpenListPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(ListPage)}");
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
