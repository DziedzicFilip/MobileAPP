using SeenIT.Helpers;
using SeenIT.ServiceReference;
using SeenIT.ViewModels.Abstract;
using SeenIT.ViewModels.FilmVM;
using SeenIT.Views.FilmViews;
using SeenIT.Views.UzytkownikViews;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeenIT.ViewModels.UzytkownikVM
{
    public class UzytkownikDetailsViewModel : AItemDetailsViewModel<UzytkownikForView>
    {
        #region Fields
        private int id;
        private string email;
        private string haslo;
        private string nick;
        #endregion
        #region Properties
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        public string Haslo
        {
            get => haslo;
            set => SetProperty(ref haslo, value);
        }
        public string Nick
        {
            get => nick;
            set => SetProperty(ref nick, value);
        }
        #endregion
        public UzytkownikDetailsViewModel()
            : base("Uzytkownik details")
        {
        }
        protected override async Task GoToUpdatePage()
            => await Shell.Current.GoToAsync($"{nameof(EditUzytkownikPage)}?{nameof(EditUzytkownikViewModel.ItemId)}={Id}");


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
