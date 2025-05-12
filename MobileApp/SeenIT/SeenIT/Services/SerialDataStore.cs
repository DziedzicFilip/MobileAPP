using SeenIT.ServiceReference;
using SeenIT.Helpers;
using SeenIT.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeenIT.Services
{
    public class SerialDataStore : AListDataStore<SerialForView>
    {
        public SerialDataStore()
           => items = DependencyService.Get<SeenitService>().SerialAllAsync().GetAwaiter().GetResult().ToList();
        public override async Task<bool> AddItemToService(SerialForView item)
            => await DependencyService.Get<SeenitService>().SerialPOSTAsync(item).HandleRequest();
        public override async Task<bool> DeleteItemFromService(SerialForView item)
            => await DependencyService.Get<SeenitService>().SerialDELETEAsync(item.Id).HandleRequest();
        public override SerialForView Find(SerialForView item)
            => items.Where((SerialForView arg) => arg.Id == item.Id).FirstOrDefault();
        public override SerialForView Find(int id)
            => items.FirstOrDefault(s => s.Id == id);
        public override async Task Refresh()
            => items = (await DependencyService.Get<SeenitService>().SerialAllAsync()).ToList();

        public override async Task<bool> UpdateItemInService(SerialForView item)
            => await DependencyService.Get<SeenitService>().SerialPUTAsync(item.Id, item).HandleRequest();
    }
}
