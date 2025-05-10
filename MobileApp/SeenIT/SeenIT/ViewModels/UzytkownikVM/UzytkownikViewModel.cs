using SeenIT.ServiceReference;
using SeenIT.ViewModels.Abstract;
using SeenIT.ViewModels.FilmVM;
using SeenIT.Views;
using SeenIT.Views.FilmViews;
using SeenIT.Views.UzytkownikViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeenIT.ViewModels.UzytkownikVM
{
    public class UzytkownikViewModel : AItemListViewModel<UzytkownikForView>
    {
        public Command ProfileCommand { get; }
        public Command ListCommand { get; }
        public Command HomeCommand { get; }
        public Command OpenObjectCommand { get; }
        public UzytkownikViewModel()
            : base("Uzytkownicy")
        {
            OpenObjectCommand = new Command(OpenObjectPage);
            ProfileCommand = new Command(OnProfileClicked);
            ListCommand = new Command(OnListClicked);
            HomeCommand = new Command(OnHomeClicked);
        }
        public override async Task GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewUzytkownikPage));
        }
        public override async Task GoToDetailsPage(UzytkownikForView item)
        {
            await Shell.Current.GoToAsync($"{nameof(UzytkownikDetailPage)}?{nameof(UzytkownikDetailsViewModel.ItemId)}={item.Id}");
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
