using SeenIT.ServiceReference;
using SeenIT.ViewModels.Abstract;
using SeenIT.ViewModels.FilmVM;
using SeenIT.Views;
using SeenIT.Views.FilmViews;
using SeenIT.Views.RodzajViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeenIT.ViewModels.RodzajVM
{
    public class RodzajViewModel : AItemListViewModel<RodzajForView>
    {
        public Command OpenObjectCommand { get; }
        public RodzajViewModel()
            : base("Rodzaje")
        {
            OpenObjectCommand = new Command(OpenObjectPage);
        }
        public override async Task GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewRodzajPage));
        }
        public override async Task GoToDetailsPage(RodzajForView item)
        {
            await Shell.Current.GoToAsync($"{nameof(RodzajDetailPage)}?{nameof(RodzajDetailsViewModel.ItemId)}={item.Id}");
        }
        private async void OpenObjectPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(ObjectPage)}");
        }
    }
}
