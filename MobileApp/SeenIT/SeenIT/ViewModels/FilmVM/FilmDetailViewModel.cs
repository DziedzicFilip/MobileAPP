using SeenIT.Helpers;
using SeenIT.ServiceReference;
using SeenIT.Services;
using SeenIT.ViewModels.Abstract;
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
            //=> await Shell.Current.GoToAsync($"{nameof(EditClientPage)}?{nameof(EditClientViewModel.ItemId)}={IdClient}");
            //
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
