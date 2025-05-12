using SeenIT.Helpers;
using SeenIT.ServiceReference;
using SeenIT.ViewModels.Abstract;
using SeenIT.ViewModels.FilmVM;
using SeenIT.Views.FilmViews;
using SeenIT.Views.RodzajViews;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeenIT.ViewModels.RodzajVM
{
    public class RodzajDetailsViewModel : AItemDetailsViewModel<RodzajForView>
    {
        #region Fields
        private int id;
        private string nazwa;
        #endregion
        #region Properties
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
        public string Nazwa
        {
            get => nazwa;
            set => SetProperty(ref nazwa, value);
        }
       
        //public string DataPremieryText => DataPremiery.ToString("yyyy-MM-dd") ?? "Brak daty";
        #endregion
        public RodzajDetailsViewModel()
            : base("Rodzaj details")
        {
        }
        protected override async Task GoToUpdatePage()
            => await Shell.Current.GoToAsync($"{nameof(EditRodzajPage)}?{nameof(EditRodzajViewModel.ItemId)}={Id}");


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
