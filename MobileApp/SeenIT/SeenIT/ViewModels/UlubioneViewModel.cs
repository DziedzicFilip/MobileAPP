using SeenIT.ServiceReference;
using SeenIT.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using SeenIT.ViewModels.FilmVM;
using SeenIT.ViewModels.Abstract;
using SeenIT.Views.FilmViews;

namespace SeenIT.ViewModels
{
    public class UlubioneFilmDisplay
    {
        public int? FilmId { get; set; }
        public string Tytul { get; set; }
        public string UrlFoto { get; set; }
        public string DataDodania { get; set; }
    }

    public class UlubioneViewModel : AItemListViewModel<UlubioneForView>
    {
        public ObservableCollection<UlubioneFilmDisplay> Items { get; } = new ObservableCollection<UlubioneFilmDisplay>();

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        public ICommand LoadItemsCommand { get; }
        public ICommand ItemTappedCommand { get; }

        public UlubioneViewModel()
            : base("Ulubione")
        {
            LoadItemsCommand = new Command(async () => await LoadItems());
            ItemTappedCommand = new Command<UlubioneFilmDisplay>(OnItemTapped);
        }

        public override async Task GoToAddPage()
        {
            // Na przyszłość, jeśli chcesz dodać coś z widoku
        }
        private async void OnItemTapped(UlubioneFilmDisplay item)
        {
            if (item?.FilmId == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(FilmDetailPage)}?{nameof(FilmDetailViewModel.ItemId)}={item.FilmId}");
        }
        public override async Task GoToDetailsPage(UlubioneForView item)
        {
            if (item?.FilmId != null)
            {
                await Shell.Current.GoToAsync($"{nameof(FilmDetailPage)}?{nameof(FilmDetailViewModel.ItemId)}={item.FilmId}");
            }
        }

        public async Task LoadItems()
        {
            if (IsBusy) return;

            IsBusy = true;
            try
            {
                Items.Clear();

                var filmStore = DependencyService.Get<IDataStore<FilmForView>>();
                var ulubioneStore = DependencyService.Get<IDataStore<UlubioneForView>>();

                var ulubione = await ulubioneStore.GetItemsAsync(forceRefresh: true);

                foreach (var u in ulubione)
                {
                    if (u.FilmId.HasValue)
                    {
                        var film = await filmStore.GetItemAsync(u.FilmId.Value);
                        if (film != null)
                        {
                            Items.Add(new UlubioneFilmDisplay
                            {
                                FilmId = u.FilmId,
                                Tytul = film.Tytul,
                                UrlFoto = film.UrlFoto,
                                DataDodania = u.DataDodania?.ToString("yyyy-MM-dd")
                            });
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[UlubioneViewModel] Błąd ładowania: {ex.Message}");
                // Możesz też dodać DisplayAlert lub komunikat w UI
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
