using SeenIT.ServiceReference;
using SeenIT.Services.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using SeenIT.Helpers;

[assembly: Dependency(typeof(SeenIT.Services.UlubioneDataStore))]
namespace SeenIT.Services
{
    public class UlubioneDataStore : AListDataStore<UlubioneForView>
    {
        public UlubioneDataStore()
            => items = DependencyService.Get<SeenitService>().UlubioneAllAsync().GetAwaiter().GetResult().ToList();

        public override async Task<bool> AddItemToService(UlubioneForView item)
            => await DependencyService.Get<SeenitService>().UlubionePOSTAsync(item).HandleRequest();

        public override async Task<bool> DeleteItemFromService(UlubioneForView item)
            => await DependencyService.Get<SeenitService>().UlubioneDELETEAsync(item.Id).HandleRequest();

        public override UlubioneForView Find(UlubioneForView item)
            => items.FirstOrDefault(arg => arg.Id == item.Id);

        public override UlubioneForView Find(int id)
            => items.FirstOrDefault(s => s.Id == id);
        public async Task<UlubioneForView> GetFavoriteByFilmIdAsync(int filmId, int userId)
        {
            var all = await DependencyService.Get<SeenitService>().UlubioneAllAsync();
            return all.FirstOrDefault(x => x.FilmId == filmId && x.SerialId == 0 && x.UzytkownikId == userId);
        }
        public override async Task Refresh()
            => items = (await DependencyService.Get<SeenitService>().UlubioneAllAsync()).ToList();

        public override async Task<bool> UpdateItemInService(UlubioneForView item)
            => await DependencyService.Get<SeenitService>().UlubionePUTAsync(item.Id, item).HandleRequest();
    }
}
