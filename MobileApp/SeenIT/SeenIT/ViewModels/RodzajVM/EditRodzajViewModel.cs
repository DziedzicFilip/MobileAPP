using SeenIT.Helpers;
using SeenIT.ServiceReference;
using SeenIT.Services.Abstract;
using SeenIT.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeenIT.ViewModels.RodzajVM
{
    public class EditRodzajViewModel : AItemUpdateViewModel<RodzajForView>
    {
            #region Fields
            private int id;
            private string nazwa;
            #endregion
            #region Properties
            public int Id
            {
                get => id;
                set => SetProperty(ref id, value);
            }
            public string Nazwa
            {
                get => nazwa;
                set => SetProperty(ref nazwa, value);
            }
            #endregion
            public EditRodzajViewModel()
                : base("Edycja Rodzaju!")
            {
            }
            public override async Task LoadItem(int id)
            {
                try
                {
                    var item = await DataStore.GetItemAsync(id);
                    this.CopyProperties(item);
                    //SelectedRodzaj = DependencyService.Get<AListDataStore<RodzajForView>>().Find(item.Id);
                }
                catch (Exception)
                {
                    Debug.WriteLine("Failed to Load Item");
                }
            }
            public override bool ValidateSave() { return true; }

            public override RodzajForView SetItem()
                => new RodzajForView()
                {
                    Id = ItemId,
                    //RodzajId = SelectedRodzaj.Id,
                }
                .CopyProperties(this);
        }
    }
