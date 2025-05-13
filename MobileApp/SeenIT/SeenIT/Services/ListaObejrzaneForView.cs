using SeenIT.ServiceReference;
using SeenIT.Services.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using SeenIT.Helpers;

[assembly: Dependency(typeof(SeenIT.Services.ListaObejrzaneDataStore))]
namespace SeenIT.Services
{
    public class ListaObejrzaneDataStore : AListDataStore<ListaObejrzaneForView>
    {
        public ListaObejrzaneDataStore()
            => items = DependencyService.Get<SeenitService>().ListaObejrzaneAllAsync().GetAwaiter().GetResult().ToList();

        public override async Task<bool> AddItemToService(ListaObejrzaneForView item)
            => await DependencyService.Get<SeenitService>().ListaObejrzanePOSTAsync(item).HandleRequest();

        public override async Task<bool> DeleteItemFromService(ListaObejrzaneForView item)
            => await DependencyService.Get<SeenitService>().ListaObejrzaneDELETEAsync(item.Id).HandleRequest();

        public override ListaObejrzaneForView Find(ListaObejrzaneForView item)
            => items.FirstOrDefault(arg => arg.Id == item.Id);

        public override ListaObejrzaneForView Find(int id)
            => items.FirstOrDefault(s => s.Id == id);

        public override async Task Refresh()
            => items = (await DependencyService.Get<SeenitService>().ListaObejrzaneAllAsync()).ToList();

        public override async Task<bool> UpdateItemInService(ListaObejrzaneForView item)
            => await DependencyService.Get<SeenitService>().ListaObejrzanePUTAsync(item.Id, item).HandleRequest();
    }
}
