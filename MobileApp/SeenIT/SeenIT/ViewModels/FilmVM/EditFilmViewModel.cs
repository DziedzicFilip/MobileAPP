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

namespace SeenIT.ViewModels.FilmVM
{
    public class EditFilmViewModel : AItemUpdateViewModel<FilmForView>
    {
        #region Fields
        private int id;
        private string tytul;
        private string opis;
        private string urlFoto;
        private RodzajForView selectedRodzaj;
        private List<RodzajForView> rodzaje;

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
        public string UrlFoto
        {
            get => urlFoto;
            set => SetProperty(ref urlFoto, value);
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
        public EditFilmViewModel()
            : base("Edycja filmu!")
        {
            selectedRodzaj = new RodzajForView();
            rodzaje = DependencyService.Get<AListDataStore<RodzajForView>>().items;
            DataPremiery = DateTimeOffset.UtcNow.Date;
        }

        public override async Task LoadItem(int id)
        {
            try
            {
                var item = await DataStore.GetItemAsync(id);
                this.CopyProperties(item);
                //Debug.WriteLine($"Loaded film: RodzajId = {item.RodzajId}");
                SelectedRodzaj = DependencyService.Get<AListDataStore<RodzajForView>>().Find(item.RodzajId.Value);
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        public override bool ValidateSave() =>  selectedRodzaj.Id > 0;

        public override FilmForView SetItem()
           => new FilmForView()
           {
               Id = ItemId,
               RodzajId = SelectedRodzaj.Id,
               RodzajData = ""
           }
           .CopyProperties(this);
    }
}
