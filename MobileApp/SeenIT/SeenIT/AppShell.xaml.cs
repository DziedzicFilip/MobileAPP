using SeenIT.ViewModels;
using SeenIT.Views;
using SeenIT.Views.FilmViews;
using SeenIT.Views.RodzajViews;
using SeenIT.Views.SerialViews;
using SeenIT.Views.UzytkownikViews;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SeenIT
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(FilmDetailPage), typeof(FilmDetailPage));
            Routing.RegisterRoute(nameof(NewFilmPage), typeof(NewFilmPage));
            Routing.RegisterRoute(nameof(EditFilmPage), typeof(EditFilmPage));
            Routing.RegisterRoute(nameof(RodzajDetailPage), typeof(RodzajDetailPage));
            Routing.RegisterRoute(nameof(NewRodzajPage), typeof(NewRodzajPage));
            Routing.RegisterRoute(nameof(EditRodzajPage), typeof(EditRodzajPage));
            Routing.RegisterRoute(nameof(UzytkownikDetailPage), typeof(UzytkownikDetailPage));
            Routing.RegisterRoute(nameof(NewUzytkownikPage), typeof(NewUzytkownikPage));
            Routing.RegisterRoute(nameof(EditUzytkownikPage), typeof(EditUzytkownikPage));
            Routing.RegisterRoute(nameof(SerialDetailPage), typeof(SerialDetailPage));
            Routing.RegisterRoute(nameof(NewSerialPage), typeof(NewSerialPage));
            Routing.RegisterRoute(nameof(EditSerialPage), typeof(EditSerialPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
