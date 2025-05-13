using SeenIT.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using SeenIT.ServiceReference;
using SeenIT.ViewModels.Abstract;
using System.Collections.Generic;

namespace SeenIT.ViewModels.ReviewsVM
{
    public class AddReviewViewModel : BaseViewModel, IQueryAttributable
    {
        private int filmId;
        private string tresc;
        private int? ocena;
        private DateTime? data = DateTime.Now;

        public string Tresc
        {
            get => tresc;
            set => SetProperty(ref tresc, value);
        }

        public int? Ocena
        {
            get => ocena;
            set => SetProperty(ref ocena, value);
        }

        public DateTime? Data
        {
            get => data;
            set => SetProperty(ref data, value);
        }

        public ICommand SaveCommand { get; }

        public AddReviewViewModel()
        {
            SaveCommand = new Command(OnSave);
        }

        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            if (query.ContainsKey("filmId"))
                filmId = int.Parse(query["filmId"]);
        }

        private async void OnSave()
        {
            var recenzja = new RecenzjaFilmuForView
            {
                Tresc = this.Tresc,
                Ocena = this.Ocena,
                Data = this.Data,
                FilmId = filmId,
                UzytkownikId = 1, 

            };

            var dataStore = DependencyService.Get<RecenzjaFilmuDataStore>();
            var result = await dataStore.AddItemAsync(recenzja);

            if (result)
            {
                // np. cofnięcie do poprzedniej strony lub komunikat o sukcesie
                await Application.Current.MainPage.DisplayAlert("Sukces", "Recenzja dodana!", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Błąd", "Nie udało się dodać recenzji.", "OK");
            }
        }
    }
}
