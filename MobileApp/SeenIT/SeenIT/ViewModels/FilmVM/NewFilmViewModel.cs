using SeenIT.Helpers;
using SeenIT.ServiceReference;
using SeenIT.Services.Abstract;
using SeenIT.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace SeenIT.ViewModels.FilmVM
{
    public class NewFilmViewModel : ANewItemViewModel<FilmForView>
    {
        #region Fields
        private int id;
        private string tytul;
        private string opis;
        private string urlFoto;
        private DateTimeOffset? dataPremiery;
        private RodzajForView selectedRodzaj;
        private List<RodzajForView> rodzaje;
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
        public string UrlFoto
        {
            get => urlFoto;
            set => SetProperty(ref opis, value);
        }

        public DateTimeOffset? DataPremiery
        {
            get => dataPremiery;
            set => SetProperty(ref dataPremiery, value);
        }
        public List<RodzajForView> Rodzaje
        {
            get
            {
                return rodzaje;
            }
        }
        public RodzajForView SelectedRodzaj
        {
            get => selectedRodzaj;
            set => SetProperty(ref selectedRodzaj, value);
        }
        #endregion

        public NewFilmViewModel()
            : base("Dodaj Film")
        {
            selectedRodzaj = new RodzajForView();
            rodzaje = DependencyService.Get<AListDataStore<RodzajForView>>().items;
            DataPremiery = DateTimeOffset.UtcNow.Date;
        }
        public override bool ValidateSave() { return true; }

        public override FilmForView SetItem()
            => new FilmForView()
            {
                Id = new Random().Next(),
                RodzajId = SelectedRodzaj.Id
            }
            .CopyProperties(this);
    }
}
