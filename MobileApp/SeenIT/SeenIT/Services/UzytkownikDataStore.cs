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
    public class UzytkownikDataStore : AListDataStore<UzytkownikForView>
    {
        public UzytkownikDataStore()
    : base()
        {
            items = DependencyService.Get<SeenitService>().UzytkownikAllAsync().GetAwaiter().GetResult().ToList();
        }
        public override async Task<bool> AddItemToService(UzytkownikForView item)
            => await DependencyService.Get<SeenitService>()
            .UzytkownikPOSTAsync(item)
            .HandleRequest();

        public override async Task<bool> DeleteItemFromService(UzytkownikForView item)
            => await DependencyService.Get<SeenitService>()
            .UzytkownikDELETEAsync(item.Id)
            .HandleRequest();

        public override UzytkownikForView Find(UzytkownikForView item)
            => items.Where((UzytkownikForView arg) => arg.Id == item.Id).FirstOrDefault();
        public override UzytkownikForView Find(int id)
            => items.FirstOrDefault(s => s.Id == id);
        public override async Task Refresh()
            => items = (await DependencyService.Get<SeenitService>()
            .UzytkownikAllAsync())
            .ToList();

        public override async Task<bool> UpdateItemInService(UzytkownikForView item)
            => await DependencyService.Get<SeenitService>()
            .UzytkownikPUTAsync(item.Id, item)
            .HandleRequest();
    }
}
