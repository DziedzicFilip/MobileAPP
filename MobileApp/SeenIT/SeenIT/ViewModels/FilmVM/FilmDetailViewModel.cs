using SeenIT.Helpers;
using SeenIT.ServiceReference;
using SeenIT.Services;
using SeenIT.ViewModels.Abstract;
using SeenIT.Views.FilmViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SeenIT.ViewModels.FilmVM
{
    public class FilmDetailViewModel : AItemDetailsViewModel<FilmForView>
    {
        #region Fields
        private int id;
        private string tytul;
        private string opis;
        private int? rodzajId;
        private string urlFoto;
        private string rodzajData;
        private DateTimeOffset? dataPremiery;
        #endregion
        #region Properties
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
        public string Tytul
        {
            get => tytul;
            set => SetProperty(ref tytul, value);
        }
        public string Opis
        {
            get => opis;
            set => SetProperty(ref opis, value);
        }
        public int? RodzajId
        {
            get => rodzajId;
            set => SetProperty(ref rodzajId, value);
        }
        public string UrlFoto
        {
            get => urlFoto;
            set => SetProperty(ref urlFoto, value);
        }
        public string RodzajData
        {
            get => rodzajData;
            set => SetProperty(ref rodzajData, value);
        }
        public DateTimeOffset? DataPremiery
        {
            get => dataPremiery;
            set => SetProperty(ref dataPremiery, value);
        }
        //public string DataPremieryText => DataPremiery.ToString("yyyy-MM-dd") ?? "Brak daty";
        public ICommand DodajRecenzjeCommand { get; }
        public ObservableCollection<RecenzjaFilmuForView> Recenzje { get; set; } = new ObservableCollection<RecenzjaFilmuForView>();

        public Command LoadRecenzjeCommand { get; }

        public ICommand DodajDoObejrzanychCommand { get; }


        #endregion
        public FilmDetailViewModel()
            : base("Film details")
        {
            DodajRecenzjeCommand = new Command<int>(OnDodajRecenzje);
            DodajDoObejrzanychCommand = new Command<int>(OnDodajDoObejrzanych);
        }
        protected override async Task GoToUpdatePage()
        {
            try
            {
                await Shell.Current.GoToAsync($"{nameof(EditFilmPage)}?{nameof(EditFilmViewModel.ItemId)}={Id}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[Navigation Error] {ex}");
            }
        }


        public override async Task LoadItem(int id)
        {
            try
            {
                var item = await DataStore.GetItemAsync(id);
                //Debug.WriteLine($"[DEBUG] Pobrano film ID: {item.Id}, Tytul: {item.Tytul}, DataPremiery: {item.DataPremiery}");
                this.CopyProperties(item);
                Device.BeginInvokeOnMainThread(async () => await LoadRecenzje());
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        private async void OnDodajRecenzje(int filmId)
        {
            // Przejście do strony dodawania recenzji z ID filmu
            await Shell.Current.GoToAsync($"///AddReviewPage?filmId={filmId}");
        }
        private async Task LoadRecenzje()
        {
            if (IsBusy) return;
            IsBusy = true;
            try
            {
                Recenzje.Clear();
                var dataStore = DependencyService.Get<RecenzjaFilmuDataStore>();
                var all = await Task.Run(() => dataStore.GetItemsAsync(true)); // pobieranie w tle
                foreach (var rec in all)
                {
                    if (rec.FilmId == this.Id)
                        Recenzje.Add(rec);
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
        private async void OnDodajDoObejrzanych(int filmId)
        {
            // Przykładowo pobierz ID użytkownika z sesji lub ustaw na sztywno
            int uzytkownikId = 1; // TODO: pobierz prawidłowe ID użytkownika
            var nowy = new ListaObejrzaneForView
            {
                FilmId = filmId,
                UzytkownikId = uzytkownikId,
                DataDodania = DateTime.Now
            };

            // Załóż, że masz DataStore lub serwis do obsługi obejrzanych
            var dataStore = DependencyService.Get<IDataStore<ListaObejrzaneForView>>();
            var result = await dataStore.AddItemAsync(nowy);

            if (result)
                await Application.Current.MainPage.DisplayAlert("Sukces", "Dodano do obejrzanych!", "OK");
            else
                await Application.Current.MainPage.DisplayAlert("Błąd", "Nie udało się dodać do obejrzanych.", "OK");
        }

    }
}
