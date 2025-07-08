using SeenIT.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeenIT.Views.UlubioneViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UlubionePage : ContentPage
    {
        UlubioneViewModel _viewModel;
        public UlubionePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new UlubioneViewModel();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is UlubioneViewModel vm)
            {
                await vm.LoadItems(); 
            }
        }
    }
}