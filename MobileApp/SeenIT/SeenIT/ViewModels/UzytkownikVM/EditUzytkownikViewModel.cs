using SeenIT.Helpers;
using SeenIT.ServiceReference;
using SeenIT.Services.Abstract;
using SeenIT.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeenIT.ViewModels.UzytkownikVM
{
    public class EditUzytkownikViewModel : AItemUpdateViewModel<UzytkownikForView>
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
        public EditUzytkownikViewModel()
                : base("Edycja Uzytkownika!")
            {
            }
            public override async Task LoadItem(int id)
            {
                try
                {
                    var item = await DataStore.GetItemAsync(id);
                    this.CopyProperties(item);
                    //SelectedUzytkownik = DependencyService.Get<AListDataStore<UzytkownikForView>>().Find(item.Id);
                }
                catch (Exception)
                {
                    Debug.WriteLine("Failed to Load Item");
                }
            }
            public override bool ValidateSave() { return true; }

            public override UzytkownikForView SetItem()
                => new UzytkownikForView()
                {
                    Id = ItemId,
                    //UzytkownikId = SelectedUzytkownik.Id,
                }
                .CopyProperties(this);
        }
    }
