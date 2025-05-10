using SeenIT.Helpers;
using SeenIT.ServiceReference;
using SeenIT.Services.Abstract;
using SeenIT.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SeenIT.ViewModels.UzytkownikVM
{
    public class NewUzytkownikViewModel : ANewItemViewModel<UzytkownikForView>
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
        public NewUzytkownikViewModel()
            : base("Dodaj Uzytkownik")
        { 
        }
        public override bool ValidateSave() { return true; }

        public override UzytkownikForView SetItem()
            => new UzytkownikForView()
            {
                Id = new Random().Next(),
                //UzytkownikId = SelectedUzytkownik.Id
            }
            .CopyProperties(this);
    }
}
