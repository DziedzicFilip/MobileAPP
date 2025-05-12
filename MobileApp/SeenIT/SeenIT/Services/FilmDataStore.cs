using SeenIT.ServiceReference;
using SeenIT.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SeenIT.Helpers;

namespace SeenIT.Services
{
    public class FilmDataStore : AListDataStore<FilmForView>
    {
        public FilmDataStore()
           => items = DependencyService.Get<SeenitService>().FilmAllAsync().GetAwaiter().GetResult().ToList();
        public override async Task<bool> AddItemToService(FilmForView item)
            => await DependencyService.Get<SeenitService>().FilmPOSTAsync(item).HandleRequest();
        public override async Task<bool> DeleteItemFromService(FilmForView item)
            => await DependencyService.Get<SeenitService>().FilmDELETEAsync(item.Id).HandleRequest();
        public override FilmForView Find(FilmForView item)
            => items.Where((FilmForView arg) => arg.Id == item.Id).FirstOrDefault();
        public override FilmForView Find(int id)
            => items.FirstOrDefault(s => s.Id == id);
        public override async Task Refresh()
            => items = (await DependencyService.Get<SeenitService>().FilmAllAsync()).ToList();

        public override async Task<bool> UpdateItemInService(FilmForView item)
            => await DependencyService.Get<SeenitService>().FilmPUTAsync(item.Id, item).HandleRequest();
    }
}
