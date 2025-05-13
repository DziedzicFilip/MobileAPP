using SeenIT.ServiceReference;
using SeenIT.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using SeenIT.ViewModels.FilmVM;
using SeenIT.Views.FilmViews;
namespace SeenIT.ViewModels
{
    public class WatchedFilmDisplay
    {
        public int? FilmId { get; set; }
        public string Tytul { get; set; }
        public string UrlFoto { get; set; }
        public string DataDodania { get; set; }
    }

    public class WatchedViewModel : BindableObject
    {
        public ObservableCollection<WatchedFilmDisplay> Items { get; set; } = new ObservableCollection<WatchedFilmDisplay>();

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set { isBusy = value; OnPropertyChanged(); }
        }

        public ICommand LoadItemsCommand { get; }

        public WatchedViewModel()
        {
            LoadItemsCommand = new Command(async () => await LoadItems());
            Task.Run(LoadItems);
        }

        private async Task LoadItems()
        {
            if (IsBusy) return;
            IsBusy = true;
            try
            {
                Items.Clear();
                var dataStore = DependencyService.Get<ListaObejrzaneDataStore>();
                var filmStore = DependencyService.Get<IDataStore<FilmForView>>();
                var obejrzane = await dataStore.GetItemsAsync(true);

                foreach (var item in obejrzane)
                {
                    if (item.FilmId.HasValue)
                    {
                        var film = await filmStore.GetItemAsync(item.FilmId.Value);
                        if (film != null)
                        {
                            Items.Add(new WatchedFilmDisplay
                            {
                                FilmId = item.FilmId,
                                Tytul = film.Tytul,
                                UrlFoto = film.UrlFoto,
                                DataDodania = item.DataDodania?.ToString("yyyy-MM-dd")
                            });
                        }
                    }
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
        public  async Task GoToDetailsPage(FilmForView item)
        {
            await Shell.Current.GoToAsync($"{nameof(FilmDetailPage)}?{nameof(FilmDetailViewModel.ItemId)}={item.Id}");
        }
    }
}
