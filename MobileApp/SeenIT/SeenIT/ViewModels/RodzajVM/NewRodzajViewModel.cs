using SeenIT.Helpers;
using SeenIT.ServiceReference;
using SeenIT.Services.Abstract;
using SeenIT.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SeenIT.ViewModels.RodzajVM
{
    public class NewRodzajViewModel : ANewItemViewModel<RodzajForView>
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
        #endregion

        public NewRodzajViewModel()
            : base("Dodaj Rodzaj")
        { 
        }
        public override bool ValidateSave() { return true; }

        public override RodzajForView SetItem()
            => new RodzajForView()
            {
                Id = new Random().Next(),
                //RodzajId = SelectedRodzaj.Id
            }
            .CopyProperties(this);
    }
}
