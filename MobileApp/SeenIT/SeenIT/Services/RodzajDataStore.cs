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
    public class RodzajDataStore : AListDataStore<RodzajForView>
    {
        public RodzajDataStore()
            :base()
        {
            items = DependencyService.Get<SeenitService>().RodzajAllAsync().GetAwaiter().GetResult().ToList();
        }
        public override async Task<bool> AddItemToService(RodzajForView item)
            => await DependencyService.Get<SeenitService>()
            .RodzajPOSTAsync(item)
            .HandleRequest();

        public override async Task<bool> DeleteItemFromService(RodzajForView item)
            => await DependencyService.Get<SeenitService>()
            .RodzajDELETEAsync(item.Id)
            .HandleRequest();

        public override RodzajForView Find(RodzajForView item)
            => items.Where((RodzajForView arg) => arg.Id == item.Id).FirstOrDefault();
        public override RodzajForView Find(int id)
            => items.FirstOrDefault(s => s.Id == id);
        public override async Task Refresh()
            => items = (await DependencyService.Get<SeenitService>()
            .RodzajAllAsync())
            .ToList();

        public override async Task<bool> UpdateItemInService(RodzajForView item)
            => await DependencyService.Get<SeenitService>()
            .RodzajPUTAsync(item.Id, item)
            .HandleRequest();
    }
}
