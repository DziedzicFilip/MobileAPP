using SeenIT.Helpers;
using SeenIT.ServiceReference;
using SeenIT.Services;
using SeenIT.ViewModels.Abstract;
using SeenIT.Views.FilmViews;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
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
        #endregion
        public FilmDetailViewModel()
            : base("Film details")
        {
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
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
