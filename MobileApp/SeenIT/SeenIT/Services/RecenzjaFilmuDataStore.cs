using SeenIT.ServiceReference;
using SeenIT.Services.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using SeenIT.Helpers;

[assembly: Dependency(typeof(SeenIT.Services.RecenzjaFilmuDataStore))]
namespace SeenIT.Services
{
    public class RecenzjaFilmuDataStore : AListDataStore<RecenzjaFilmuForView>
    {
        public RecenzjaFilmuDataStore()
            => items = DependencyService.Get<SeenitService>().RecenzjaFilmuAllAsync().GetAwaiter().GetResult().ToList();

        public override async Task<bool> AddItemToService(RecenzjaFilmuForView item)
    => await DependencyService.Get<SeenitService>().RecenzjaFilmuPOSTAsync(item).HandleRequest();


        public override async Task<bool> DeleteItemFromService(RecenzjaFilmuForView item)
            => await DependencyService.Get<SeenitService>().RecenzjaFilmuDELETEAsync(item.Id).HandleRequest();

        public override RecenzjaFilmuForView Find(RecenzjaFilmuForView item)
            => items.FirstOrDefault(arg => arg.Id == item.Id);

        public override RecenzjaFilmuForView Find(int id)
            => items.FirstOrDefault(s => s.Id == id);

        public override async Task Refresh()
            => items = (await DependencyService.Get<SeenitService>().RecenzjaFilmuAllAsync()).ToList();

        public override async Task<bool> UpdateItemInService(RecenzjaFilmuForView item)
            => await DependencyService.Get<SeenitService>().RecenzjaFilmuPUTAsync(item.Id, item).HandleRequest();
    }
}
